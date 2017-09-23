using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class PayrollOfficer_GenerateEmpPay : System.Web.UI.Page
{
    Helper aud = new Helper();   
    SqlConnection mio = new SqlConnection(Helper.GetCon());
    protected void Page_Load(object sender, EventArgs e)
    {
        mio.Open();
        SqlCommand mirai = new SqlCommand();
        mirai.Connection = mio;

        mirai.CommandText = "Select EmployeeID, FirstName, MiddleName, LastName, DateEmployed, Position FROM Employee WHERE Status = 'Employed' ";
        SqlDataAdapter da = new SqlDataAdapter(mirai);
        DataSet ds = new DataSet();
        da.Fill(ds, "Employee");
        lvEmployeeList.DataSource = ds;
        lvEmployeeList.DataBind();
        mio.Close();
    }
    protected void btnGenPay_Click(object sender, EventArgs e)
    {

        int EmployeeID = 0;
        int PayTerm = 0;
        int BWD = 0;
        int HCount = 0;
        decimal SSScont, PhilHCont, PagibigCont = 0.0m;
        decimal SSSloan, HDMFLoan, PLoan = 0.0m;
        string empStatus = "";
        decimal WTax = 0.0m;
        decimal BaseSalary = 0.0m;
        decimal PayAfterDeduc = 0.0m;
        decimal Allowance = 0.0m;
        decimal HourlyRate = 0.0m;
        decimal netPay = 0.0m;
        decimal totaldeduc = 0.0m;
        decimal attendance = 0.0m;
        decimal leaveC = 0.0m;
        decimal LWopayDeduction = 0.0m;
        decimal OTpay = 0.0m;
        decimal grossPay = 0.0m;
        decimal attwpy = 0.0m; //holidaywithpay


        Allowance = decimal.Parse(txtAllowance.Text);
        PayTerm = GetPayTermID();

        
        SqlConnection mio2 = new SqlConnection(Helper.GetCon());
        mio2.Open();
        SqlCommand mirai = new SqlCommand();
        mirai.Connection = mio2;
        mirai.CommandText = "Select EmployeeID, FirstName, MiddleName, LastName, DateEmployed, Position FROM Employee WHERE Status = 'Employed'";
        SqlDataReader aki = mirai.ExecuteReader();
        if (aki.HasRows)
        {
            while (aki.Read())
            {
                EmployeeID = int.Parse(aki["EmployeeID"].ToString());
                mio.Open();
                BaseSalary = EmpBaseSalary(EmployeeID);
                mio.Close();
                mio.Open();
                
                //deductions
                SSScont = EmpSSScont(BaseSalary);
                mio.Close();
                mio.Open();
                PhilHCont = EmpPhilHCont(BaseSalary);
                mio.Close();
                mio.Open();
                PagibigCont = EmpPagibigCont(BaseSalary);
                mio.Close();
                mio.Open();
                SSSloan = getLoan(EmployeeID,"SSSLoan");
                mio.Close();
                mio.Open();
                HDMFLoan = getLoan(EmployeeID, "HDMFLoan");
                mio.Close();
                mio.Open();
                PLoan = getLoan(EmployeeID, "PersonalLoan");
                mio.Close();
                mio.Open();
                //end 


                HourlyRate = EmpHourlyRate(BaseSalary);
                mio.Close();
                mio.Open();
                HCount = checkHolidays(PayTerm);
                mio.Close();
                mio.Open();
                attendance = AttendanceCount(EmployeeID, PayTerm);
                mio.Close();
                mio.Open();
                leaveC = LeaveCount(EmployeeID, PayTerm);
                mio.Close();
                mio.Open();
                BWD = BWorkDays(PayTerm);
                mio.Close();
                mio.Open();
                holidayAtt(EmployeeID, PayTerm);
                mio.Close();
                mio.Open();
                if (BWD > (leaveC + attendance + HCount))
                {
                    LWopayDeduction = ((BWD - (leaveC + attendance)) * 8) * HourlyRate;
                }
                else
                    LWopayDeduction = 0.0m;
                mio.Close();
                mio.Open();
                attwpy = HourlyRate * holidayAtt(EmployeeID, PayTerm);
                mio.Close();
                mio.Open();
                OTpay = OvertimePay(EmployeeID, PayTerm);
                mio.Close();
                mio.Open();


                PayAfterDeduc = (BaseSalary + attwpy + OTpay) - (SSScont + PhilHCont + PagibigCont);
                grossPay = BaseSalary + attwpy + OTpay - LWopayDeduction;
                //tax
                mio.Close();
                mio.Open();
                empStatus = getEmpStatus(EmployeeID);
                mio.Close();
                mio.Open();
                WTax = getWTaxDeduc(PayAfterDeduc, empStatus);
                //end
                totaldeduc = WTax + SSScont + PhilHCont + PagibigCont + SSSloan + HDMFLoan + PLoan;

                netPay = grossPay - totaldeduc;
                mio.Close();
                mio.Open();
                insertPayrollData(EmployeeID, PayTerm, WTax, SSScont, PhilHCont, PagibigCont, SSSloan, HDMFLoan, LWopayDeduction, OTpay, PLoan, netPay, Allowance);
                mio.Close();

                String name = Session["firstname"].ToString() + " " + Session["lastname"].ToString();
                aud.AuditLog("Generate Payroll", int.Parse(Session["empid"].ToString()), name + "Generated Payroll for PaytermID" + PayTerm);
            }
        }

        mio2.Close();

    }
    public void insertPayrollData(int EmpID, int PTID, decimal Wtax, decimal SSScont, decimal PhicCont, decimal HdmfCont, decimal SSSloan, decimal HDMFLoan,decimal Lwopay, decimal otPay, decimal PLoan, decimal netpay, decimal allowance)
    {
        SqlCommand ruri = new SqlCommand();
        ruri.Connection = mio;
        ruri.CommandText = "Insert Into PayrollRecords Values (@EmployeeID, @PaytermID, @WTax, @SSScont, @PHICCont, @HDMFCont,"+
            " @SSSLoan, @HDMFLoan, @LWoPay, @OvertimePay, @PersonalLoan, @NetPay, @Allowance)";
        ruri.Parameters.AddWithValue("@EmployeeID", EmpID);
        ruri.Parameters.AddWithValue("@PaytermID", PTID);
        ruri.Parameters.AddWithValue("@WTax", Wtax);
        ruri.Parameters.AddWithValue("@SSScont", SSScont);
        ruri.Parameters.AddWithValue("@PHICCont", PhicCont);
        ruri.Parameters.AddWithValue("@HDMFCont", HdmfCont);
        ruri.Parameters.AddWithValue("@SSSLoan", SSSloan);
        ruri.Parameters.AddWithValue("@HDMFLoan", HDMFLoan);
        ruri.Parameters.AddWithValue("@LWoPay", Lwopay);
        ruri.Parameters.AddWithValue("@OvertimePay", otPay);
        ruri.Parameters.AddWithValue("@PersonalLoan", PLoan);
        ruri.Parameters.AddWithValue("@NetPay", netpay);
        ruri.Parameters.AddWithValue("@Allowance", allowance);
        ruri.ExecuteNonQuery();
    }
    public decimal getWTaxDeduc(decimal NTI, string status)
    {
        decimal pOver = 0.0m;
        decimal basetax = 0.0m;
        decimal tax = 0.0m;
        decimal low = 0.0m;

        SqlCommand riko = new SqlCommand();
        riko.Connection = mio;
        riko.CommandText = "  Select PercentageOver, BaseTax, Low from WithholdingTaxTable where Status = @Status AND Low <= @NetTI AND High > @NetTI ";
        riko.Parameters.AddWithValue("@Status", status);
        riko.Parameters.AddWithValue("@NetTI", NTI);
        SqlDataReader hana = riko.ExecuteReader();
        if (hana.HasRows)
        {
            while (hana.Read())
            {
                pOver = decimal.Parse(hana["PercentageOver"].ToString());
                basetax = decimal.Parse(hana["BaseTax"].ToString());
                low = decimal.Parse(hana["low"].ToString());
            }
        }
        tax = ((NTI - low) * pOver) + basetax;

        return tax;


    }
    public string getEmpStatus(int EmpID)
    {
        string status = "";
        int depC = 0;
        SqlCommand sena = new SqlCommand();
        sena.Connection = mio;
        sena.CommandText = "Select COUNT(*) as DepNo from EmployeeDependents where EmployeeID =@EmployeeID AND Status='Eligible'";
        sena.Parameters.AddWithValue("@EmployeeID", EmpID);
        SqlDataReader rika = sena.ExecuteReader();
        if (rika.HasRows)
        {
            while (rika.Read())
            {
                depC = int.Parse(rika["DepNo"].ToString());
            }
        }
        if (depC == 0)
        {
            status = "S/ME";
        } else if (depC == 1)
        {
            status = "ME1/S1";
        }
        else if (depC == 2)
        {
            status = "ME2/S2";
        }
        else if (depC == 3)
        {
            status = "ME3/S3";
        }
        else if (depC >= 4)
        {
            status = "ME4/S4";
        }
        return status;


    }
    public decimal getLoan(int EmpID, string LoanType)
    {
        decimal lRate = 0.0m;
        SqlCommand yui = new SqlCommand();
        yui.Connection = mio;
        yui.CommandText = " SELECT EmployeeID, LoanRate from EmployeeLoanRecords where TotalLoan != AmountPayed AND EmployeeID =@EmployeeID AND LoanType=@LoanType";
        yui.Parameters.AddWithValue("@EmployeeID",EmpID);
        yui.Parameters.AddWithValue("@LoanType", LoanType);
        SqlDataReader momo = yui.ExecuteReader();
        if (momo.HasRows)
        {
            while (momo.Read())
            {
                lRate = decimal.Parse(momo["LoanRate"].ToString());
            }
        }
        return lRate;
    }
    public decimal OvertimePay(int EmpID, int PaytermID)
    {
        var start = DateTime.Today;
        var end = DateTime.Today;
        int otHours = 0;
        int hours = 0;

        SqlCommand kyon = new SqlCommand();
        kyon.Connection = mio;
        kyon.CommandText = "Select StartingDate, EndingDate from PayTerm where PayTermID = @PaytermID";
        kyon.Parameters.AddWithValue("@PaytermID", PaytermID);
        SqlDataReader eru = kyon.ExecuteReader();
        if (eru.HasRows)
        {
            while (eru.Read())
            {
                DateTime.TryParse(eru["StartingDate"].ToString(), out start);
                DateTime.TryParse(eru["EndingDate"].ToString(), out end);
            }
        }
        mio.Close();
        mio.Open();
        SqlCommand karen = new SqlCommand();
        karen.Connection = mio;
        karen.CommandText = "Select Hours, StartTime, EndTime from OvertimeRecords where Date > @StartDate AND Date <= @EndDate AND Status='Approved' AND EmployeeID=@EmployeeID";
        karen.Parameters.AddWithValue("@StartDate", start.Date);
        karen.Parameters.AddWithValue("@EndDate", end.Date);
        karen.Parameters.AddWithValue("@EmployeeID", EmpID);
        SqlDataReader miyu = karen.ExecuteReader();
        if (miyu.HasRows)
        {
            while (miyu.Read())
            {
                otHours = int.Parse(miyu["Hours"].ToString());
                hours = hours + otHours;
            }
        }
        return hours;
    }
    public int checkHolidays(int PaytermID)
    {
        var start = DateTime.Today;
        var end = DateTime.Today;
        var day = DateTime.Today;
        string sDate = DateTime.Now.ToString();
        DateTime date = (Convert.ToDateTime(sDate.ToString()));
        int count = 0;

        string Year = date.Year.ToString();
        var h1 = "01-01-" + Year;
        var h2 = "09-04-" + Year;
        var h3 = "13-04-" + Year;
        var h4 = "14-04-" + Year;
        var h5 = "01-05-" + Year;
        var h6 = "12-06-" + Year;
        var h7 = "28-08-" + Year;
        var h8 = "30-10-" + Year;
        var h9 = "25-12-" + Year;
        var h10 = "30-12-" + Year;
        DateTime holiday1 = DateTime.Parse(h1);
        DateTime holiday2 = DateTime.Parse(h2);
        DateTime holiday3 = DateTime.Parse(h3);
        DateTime holiday4 = DateTime.Parse(h4);
        DateTime holiday5 = DateTime.Parse(h5);
        DateTime holiday6 = DateTime.Parse(h6);
        DateTime holiday7 = DateTime.Parse(h7);
        DateTime holiday8 = DateTime.Parse(h8);
        DateTime holiday9 = DateTime.Parse(h9);
        DateTime holiday10 = DateTime.Parse(h10);

        SqlCommand aiztan = new SqlCommand();
        aiztan.Connection = mio;
        aiztan.CommandText = "Select StartingDate, EndingDate from PayTerm where PayTermID = @PaytermID";
        aiztan.Parameters.AddWithValue("@PaytermID", PaytermID);
        SqlDataReader meguri = aiztan.ExecuteReader();
        if (meguri.HasRows)
        {
            while (meguri.Read())
            {
                DateTime.TryParse(meguri["StartingDate"].ToString(), out start);
                DateTime.TryParse(meguri["EndingDate"].ToString(), out end);
                if (start <= holiday1 && end >= holiday1)
                    count++;
                if (start <= holiday2 && end >= holiday2)
                    count++;
                if (start <= holiday3 && end >= holiday3)
                    count++;
                if (start <= holiday4 && end >= holiday4)
                    count++;
                if (start <= holiday5 && end >= holiday5)
                    count++;
                if (start <= holiday6 && end >= holiday6)
                    count++;
                if (start <= holiday7 && end >= holiday7)
                    count++;
                if (start <= holiday8 && end >= holiday8)
                    count++;
                if (start <= holiday9 && end >= holiday9)
                    count++;
                if (start <= holiday10 && end >= holiday10)
                    count++;

            }
        }
        return count;
    }
    public decimal holidayAtt(int EmployeeID,int PayTermID)
    {
        var start = DateTime.Today;
        var end = DateTime.Today;
        var day = DateTime.Today;
        decimal holidayC = 0.0m;
        string sDate = DateTime.Now.ToString();
        DateTime date = (Convert.ToDateTime(sDate.ToString()));
        string status = "";

        string Year = date.Year.ToString();
        var h1 = "01-01-" + Year;
        var h2 = "09-04-" + Year;
        var h3 = "13-04-" + Year;
        var h4 = "14-04-" + Year;
        var h5 = "01-05-" + Year;
        var h6 = "12-06-" + Year;
        var h7 = "28-08-" + Year;
        var h8 = "30-10-" + Year;
        var h9 = "25-12-" + Year;
        var h10 = "30-12-" + Year;
        DateTime holiday1 = DateTime.Parse(h1);
        DateTime holiday2 = DateTime.Parse(h2);
        DateTime holiday3 = DateTime.Parse(h3);
        DateTime holiday4 = DateTime.Parse(h4);
        DateTime holiday5 = DateTime.Parse(h5);
        DateTime holiday6 = DateTime.Parse(h6);
        DateTime holiday7 = DateTime.Parse(h7);
        DateTime holiday8 = DateTime.Parse(h8);
        DateTime holiday9 = DateTime.Parse(h9);
        DateTime holiday10 = DateTime.Parse(h10);

        SqlCommand amichan = new SqlCommand();
        amichan.Connection = mio;
        amichan.CommandText = "Select StartingDate, EndingDate from PayTerm where PayTermID = @PaytermID";
        amichan.Parameters.AddWithValue("@PaytermID", PayTermID);
        SqlDataReader megumi = amichan.ExecuteReader();
        if (megumi.HasRows)
        {
            while (megumi.Read())
            {
                DateTime.TryParse(megumi["StartingDate"].ToString(), out start);
                DateTime.TryParse(megumi["EndingDate"].ToString(), out end);
            }
        }
        mio.Close();
        mio.Open();
        SqlCommand taiga = new SqlCommand();
        taiga.Connection = mio;
        taiga.CommandText = "Select TimeIn, TimeOut, Status From AttendanceRecord where "+
            "(EmployeeID = @EmployeeID AND Type='Biometrics' AND TimeIn > @StartDate AND TimeIn < @EndDate) OR"+
            " (EmployeeID = @EmployeeID AND Type='Manual' AND TimeIn > @StartDate AND TimeIn < @EndDate)";
        taiga.Parameters.AddWithValue("@EmployeeID", EmployeeID);
        taiga.Parameters.AddWithValue("@StartDate", start);
        taiga.Parameters.AddWithValue("@EndDate", end.AddDays(1));
        SqlDataReader katou = taiga.ExecuteReader();
        if (katou.HasRows)
        {
            while (katou.Read())
            {
                day = DateTime.Parse(katou["TimeIn"].ToString());
                status = katou["Status"].ToString();
                if(day.Date == holiday1.Date || day.Date == holiday2.Date || day.Date == holiday3.Date || day.Date == holiday4.Date || day.Date == holiday5.Date || day.Date == holiday6.Date || day.Date == holiday7.Date || day.Date == holiday8.Date || day.Date == holiday9.Date || day.Date == holiday10.Date)
                {
                    if(status == "Fullday")
                    {
                        holidayC += 1;
                    }else if (status == "Halfday")
                    {
                        holidayC += 0.5m;
                    }
                }
            }
        }
        return holidayC;
    }
    public decimal AttendanceCount(int EmpID, int PaytermID)
    {
        int FDayCount = 0;
        int HDayCount = 0;
        decimal Pay = 0;
        var start = DateTime.Today;
        var end = DateTime.Today;


        SqlCommand mirai5 = new SqlCommand();
        mirai5.Connection = mio;
        mirai5.CommandText = "Select StartingDate, EndingDate from PayTerm where PayTermID = @PaytermID";
        mirai5.Parameters.AddWithValue("@PaytermID", PaytermID);
        SqlDataReader aki5 = mirai5.ExecuteReader();
        if (aki5.HasRows)
        {
            while (aki5.Read())
            {
                DateTime.TryParse(aki5["StartingDate"].ToString(), out start);
                DateTime.TryParse(aki5["EndingDate"].ToString(), out end);
            }
        }
        mio.Close();
        mio.Open();
        SqlCommand mirai6 = new SqlCommand();
        mirai6.Connection = mio;
        mirai6.CommandText = "  Select Count(*) as Total From AttendanceRecord where" +
            " (TimeIn > @Start AND TimeIn < @End AND Type = 'Biometrics' AND Status ='Fullday' AND EmployeeID=@EmpID)" +
            " OR (TimeIn > @Start AND TimeIn < @End AND Type = 'Manual' AND Status ='Fullday' And EmployeeID=@EmpID)";
        mirai6.Parameters.AddWithValue("@Start", start);
        mirai6.Parameters.AddWithValue("@End", end.AddDays(1));
        mirai6.Parameters.AddWithValue("@EmpID", EmpID);
        SqlDataReader aki51 = mirai6.ExecuteReader();
        if (aki51.HasRows)
        {
            while (aki51.Read())
            {
                FDayCount = int.Parse(aki51["Total"].ToString());
            }
        }
        mio.Close();
        mio.Open();
        SqlCommand mirai7 = new SqlCommand();
        mirai7.Connection = mio;
        mirai7.CommandText = "Select Count(*) as Total From AttendanceRecord where" +
            " (TimeIn > @Start AND TimeIn < @End AND Type = 'Biometrics' AND Status ='Halfday' AND EmployeeID=@EmpID)" +
            " OR (TimeIn > @Start AND TimeIn < @End AND Type = 'Manual' AND Status ='Halfday' And EmployeeID=@EmpID)";
        mirai7.Parameters.AddWithValue("@Start", start);
        mirai7.Parameters.AddWithValue("@End", end.AddDays(1));
        mirai7.Parameters.AddWithValue("@EmpID", EmpID);
        SqlDataReader aki52 = mirai7.ExecuteReader();
        if (aki52.HasRows)
        {
            while (aki52.Read())
            {
                HDayCount = int.Parse(aki52["Total"].ToString());
            }
        }
        Pay = FDayCount + (HDayCount * 0.5m);
        return Pay;


    }
    public decimal LeaveCount(int EmpID, int PaytermID)
    {
        var start = DateTime.Today;
        var end = DateTime.Today;
        decimal lvCount = 0.0m;
        DateTime Lstart;
        DateTime Lend;

        SqlCommand com1 = new SqlCommand();
        com1.Connection = mio;
        com1.CommandText = "Select StartingDate, EndingDate from PayTerm where PayTermID=@PayTermID";
        com1.Parameters.AddWithValue("@PayTermID", PaytermID);
        SqlDataReader akicom1 = com1.ExecuteReader();
        if (akicom1.HasRows)
        {
            while (akicom1.Read())
            {
                DateTime.TryParse(akicom1["StartingDate"].ToString(), out start);
                DateTime.TryParse(akicom1["EndingDate"].ToString(), out end);
            }
        }
        mio.Close();
        mio.Open();
        SqlCommand com2 = new SqlCommand();
        com2.Connection = mio;
        com2.CommandText = "Select StartingDate, EndingDate From LeaveRecords where (EmployeeID =@EmployeeID AND StartingDate > @StartDate AND EndingDate <@EndDate AND Status='Approved')" +
            " OR (EmployeeID = @EmployeeID AND StartingDate <= @EndDate AND EndingDate >= @EndDate AND Status='Approved') " +
            "OR (EmployeeID = @EmployeeID AND StartingDate <= @StartDate AND EndingDate >= @StartDate AND Status='Approved')";
        com2.Parameters.AddWithValue("@StartDate", start);
        com2.Parameters.AddWithValue("@EndDate", end);
        com2.Parameters.AddWithValue("@EmployeeID",EmpID );
        SqlDataReader mayoi = com2.ExecuteReader();
        if (mayoi.HasRows)
        {
            while (mayoi.Read())
            {
                Lstart = DateTime.Parse(mayoi["StartingDate"].ToString());
                Lend = DateTime.Parse(mayoi["EndingDate"].ToString());

                if (start >= Lstart && start >= Lend)
                {
                    TimeSpan ts = Lend - start;
                    lvCount += ts.Days;

                } else if(end >= Lstart && end <= Lend)
                {
                    TimeSpan ts = end - Lstart;
                    lvCount += ts.Days;
                }
                else if(Lstart > start && Lend < end)
                {
                    TimeSpan ts = Lstart - Lend;
                    if(ts.Days < 1)
                    {
                        lvCount += 0.5m;
                    }
                    else
                    {
                        lvCount += ts.Days;
                    }
                }
            }
        }
        return lvCount;

    }
    public int BWorkDays(int PayTermID)
    {
        var start = DateTime.Today;
        var end = DateTime.Today;
        int totalDays = 0;
        int totalBD = 0;
        int count = 1;

        SqlCommand mirai8 = new SqlCommand();
        mirai8.Connection = mio;
        mirai8.CommandText = "Select StartingDate, EndingDate from PayTerm where PayTermID = @PaytermID";
        mirai8.Parameters.AddWithValue("@PaytermID", PayTermID);
        SqlDataReader aki6 = mirai8.ExecuteReader();
        if (aki6.HasRows)
        {
            while (aki6.Read())
            {
                DateTime.TryParse(aki6["StartingDate"].ToString(), out start);
                DateTime.TryParse(aki6["EndingDate"].ToString(), out end);
            }
        }
        if (start > end)
        {

        }
        else
        {
            TimeSpan totaldays = end - start;
            totalDays = totaldays.Days;
        }
        DateTime date = start.Date;
        while (count <= totalDays)
        {
            if ((int)date.DayOfWeek == 0 || (int)date.DayOfWeek == 6)
            {

            }
            else
            {
                totalBD += 1;
            }
            date = date.AddDays(1);
            count += 1;

        }
        return totalBD;



    }
    public int GetPayTermID()
    {
        int PaytermID = 0;
        mio.Open();
        SqlCommand mirai2 = new SqlCommand();
        mirai2.Connection = mio;
        mirai2.CommandText = "Select PayTermID from PayTerm where StartingDate < @DateNow AND EndingDate > @DateNow";
        mirai2.Parameters.AddWithValue("@DateNow", DateTime.Today.ToString("MM-dd-yyyy"));
        SqlDataReader aki2 = mirai2.ExecuteReader();
        if (aki2.HasRows)
        {
            while (aki2.Read())
            {
                PaytermID = int.Parse(aki2["PaytermID"].ToString());
            }
        }
        mio.Close();
        return PaytermID;
    }
    public decimal EmpBaseSalary(int ID)
    {
        decimal BaseSalary = 0.0m;
        SqlCommand com = new SqlCommand();
        com.Connection = mio;
        com.CommandText = "Select BaseSalary From Employee where EmployeeID = @EmployeeID";
        com.Parameters.AddWithValue("@EmployeeID", ID);
        SqlDataReader dr = com.ExecuteReader();
        if (dr.HasRows)
        {
            while (dr.Read())
            {
                BaseSalary = decimal.Parse(dr["BaseSalary"].ToString());
                
            }
        }
        return BaseSalary;
    }
    public decimal EmpSSScont(decimal BasePay)
    {
        decimal empCont = 0.0m;
        decimal total = 0.0m;

        SqlCommand mirai3 = new SqlCommand();
        mirai3.Connection = mio;
        mirai3.CommandText = "select SSSBracketID, Total from SSSContribution where Minimum <= @BasePay AND Maximum > @BasePay";
        mirai3.Parameters.AddWithValue("@BasePay", BasePay);
        SqlDataReader aki3 = mirai3.ExecuteReader();
        if (aki3.HasRows)
        {
            while (aki3.Read())
            {
                total = decimal.Parse(aki3["Total"].ToString());
            }

        }
        empCont = total * 0.33m;
        decimal.Round(empCont, 1);
        return empCont;
    }
    public decimal EmpPhilHCont(decimal BasePay)
    {
        decimal empCont = 0.0m;
        decimal total = 0.0m;

        SqlCommand mirai4 = new SqlCommand();
        mirai4.Connection = mio;
        mirai4.CommandText = "Select PHICBracketID, TotalPremium From PhilHealthContribution where Minimum <= @Basepay AND Maximum > @BasePay";
        mirai4.Parameters.AddWithValue("@BasePay", BasePay);
        SqlDataReader aki4 = mirai4.ExecuteReader();
        if (aki4.HasRows)
        {
            while (aki4.Read())
            {
                total = decimal.Parse(aki4["TotalPremium"].ToString());
            }
        }
        empCont = total * 0.50m;
        return decimal.Round(empCont,1);
        
    }
    public decimal EmpPagibigCont(decimal BasePay)
    {
        decimal empCont = 0.0m;
        if(BasePay > 1500.0m)
        {
            empCont = BasePay * 0.1m;
        }
        else
        {
           empCont = BasePay * 0.02m;
        }

        return decimal.Round(empCont, 1);
    }
    public decimal EmpHourlyRate(decimal BasePay)
    {
        decimal HourlyRate = 0.0m;
        HourlyRate = ((BasePay * 12.0m) / 52.0m) / 40.0m;
        return decimal.Round(HourlyRate, 2);
        
    }
}
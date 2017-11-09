using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class MasterPages_Admin : System.Web.UI.MasterPage
{
    SqlConnection con = new SqlConnection(Helper.GetCon());
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Session["userid"] != null)
        {

            GetLeave();
            GetOvertime();
            GetPayslip();
            getLeaveNo();
            getOvertimeNo();
            getPayslipNo();

            ltFN.Text = Session["FirstName"].ToString();
            ltLN.Text = Session["LastName"].ToString();
            ltUser.Text = Session["Position"].ToString();
        }
        else
        {
            Response.Redirect("~/Login.aspx");
        }

        //if (Session["empid"] != null)
        //{

        //}
        //else
        //{
        //    Response.Redirect("../Login.aspx");
        //}

    }
    //LEAVE
    void GetLeave()
    {
        var DateToday = DateTime.Today;
        con.Open();
        SqlCommand com = new SqlCommand();
        com.Connection = con;
        com.CommandText = "SELECT LeaveRID, LeaveType, Status FROM LeaveRecords WHERE StartingDate >= @DateToday";
        com.Parameters.AddWithValue("@DateToday", DateToday.ToString("yyyy-MM-dd"));
        SqlDataAdapter da = new SqlDataAdapter(com);
        SqlDataReader dr = com.ExecuteReader();
        lvLeave.DataSource = dr;
        lvLeave.DataBind();
        con.Close();
    }
    void getLeaveNo()
    {
        var DateToday = DateTime.Today;
        con.Open();
        SqlCommand com = new SqlCommand();
        com.Connection = con;
        com.CommandText = "SELECT COUNT (*) AS LeaveCount FROM LeaveRecords WHERE StartingDate >= @DateToday";
        com.Parameters.AddWithValue("@DateToday", DateToday.ToString("yyyy-MM-dd"));
        SqlDataReader dr = com.ExecuteReader();
        if (dr.HasRows)
        {
            while (dr.Read())
            {
                ltLeave.Text = dr["LeaveCount"].ToString();
            }
            con.Close();
        }
    }

    //OVERTIME
    void GetOvertime()
    {
        var DateToday = DateTime.Today;
        con.Open();
        SqlCommand com = new SqlCommand();
        com.Connection = con;
        com.CommandText = "SELECT OTRID, Date, Status FROM OvertimeRecords WHERE Date = @DateToday";
        com.Parameters.AddWithValue("@DateToday", DateToday.ToString("yyyy-MM-dd"));
        SqlDataAdapter da = new SqlDataAdapter(com);
        SqlDataReader dr = com.ExecuteReader();
        lvOvertime.DataSource = dr;
        lvOvertime.DataBind();
        con.Close();
    }
    void getOvertimeNo()
    {
        var DateToday = DateTime.Today;
        con.Open();
        SqlCommand com = new SqlCommand();
        com.Connection = con;
        com.CommandText = "SELECT COUNT (*) AS OvertimeCount FROM OvertimeRecords WHERE Date = @DateToday";
        com.Parameters.AddWithValue("@DateToday", DateToday.ToString("yyyy-MM-dd"));
        SqlDataReader dr = com.ExecuteReader();
        if (dr.HasRows)
        {
            while (dr.Read())
            {
                ltOvertime.Text = dr["OvertimeCount"].ToString();
            }
            con.Close();
        }
    }

    //PAYSLIP
    void GetPayslip()
    {
        var DateToday = DateTime.Today;
        var DateTom = DateToday.AddDays(1).AddMinutes(-1);

        con.Open();
        SqlCommand com = new SqlCommand();
        com.Connection = con;
        com.CommandText = "SELECT pr.PayslipID FROM PayrollRecords pr INNER JOIN PayTerm pt ON pr.PayTermID = pt.PayTermID INNER JOIN Employee e ON pr.EmployeeID = e.EmployeeID where pt.EndingDate > @DateToday AND pt.EndingDate < @DateTom ";
        com.Parameters.AddWithValue("@DateToday", DateToday.ToString("MM-dd-yyyy HH:mm:ss"));
        com.Parameters.AddWithValue("@DateTom", DateTom.ToString("MM-dd-yyyy HH:mm:ss"));
        SqlDataAdapter da = new SqlDataAdapter(com);
        SqlDataReader dr = com.ExecuteReader();
        lvPayslip.DataSource = dr;
        lvPayslip.DataBind();
        con.Close();
    }
    void getPayslipNo()
    {
        var DateToday = DateTime.Today;
        var DateTom = DateToday.AddDays(1).AddMinutes(-1);
        con.Open();
        SqlCommand com = new SqlCommand();
        com.Connection = con;
        com.CommandText = "SELECT Count(*) as PayslipCount FROM PayrollRecords pr INNER JOIN PayTerm pt ON pr.PayTermID = pt.PayTermID INNER JOIN Employee e ON pr.EmployeeID = e.EmployeeID where pt.EndingDate > @DateToday AND pt.EndingDate < @DateTom ";
        com.Parameters.AddWithValue("@DateToday", DateToday.ToString("MM-dd-yyyy HH:mm:ss"));
        com.Parameters.AddWithValue("@DateTom", DateTom.ToString("MM-dd-yyyy HH:mm:ss"));
        SqlDataAdapter da = new SqlDataAdapter(com);
        SqlDataReader dr = com.ExecuteReader();
        if (dr.HasRows)
        {
            while (dr.Read())
            {
                ltPayslip.Text = dr["PayslipCount"].ToString();
            }
            con.Close();
        }
    }

    //Attendance override
    // Helper aud = new Helper();
    //SqlConnection mio = new SqlConnection(Helper.GetCon());

    //protected void btnTimeIn_Click(object sender, EventArgs e)
    //{
    //    checkOverride();
    //    aud.AuditLog(EncryptHelper.Encrypt("Attendance Override", Helper.GetSalt()), int.Parse(Session["empid"].ToString()), EncryptHelper.Encrypt("Timed-in", Helper.GetSalt()));
    //}

    //protected void btnTimeOut_Click(object sender, EventArgs e)
    //{
    //    mio.Open();
    //    SqlCommand mirai = new SqlCommand();
    //    mirai.Connection = mio;
    //    mirai.CommandText = "UPDATE AttendanceRecord SET TimeOut= @TimeOut where ARID = (Select ARID FROM (Select ARID, EmployeeID, CONVERT(date, TimeIn) as TimeInDate, TimeOut, Type, Status From AttendanceRecord) e where e.TimeInDate = @TimeIn  AND e.TimeOut IS NULL AND EmployeeID=@EmployeeID)";
    //    mirai.Parameters.AddWithValue("@EmployeeID", Session["empid"].ToString());
    //    mirai.Parameters.AddWithValue("@TimeIn", DateTime.Today.ToString("MM-dd-yyyy"));
    //    mirai.Parameters.AddWithValue("@TimeOut", DateTime.Now.ToString("MM-dd-yyyy HH:mm:ss"));
    //    mirai.ExecuteNonQuery();
    //    mio.Close();
    //    aud.AuditLog(EncryptHelper.Encrypt("Attendance Override", Helper.GetSalt()), int.Parse(Session["empid"].ToString()), EncryptHelper.Encrypt("Timed-out", Helper.GetSalt()));
    //}
    //void checkOverride()
    //{
    //    var dateNtimetoday = DateTime.Today;
    //    var dateNtimeTom = dateNtimetoday.AddSeconds(-1).AddDays(1);

    //    mio.Open();
    //    SqlCommand mirai = new SqlCommand();
    //    mirai.Connection = mio;
    //    mirai.CommandText = "Select a.ARID, convert(date, a.TimeIn) as DateTimeIn, convert(varchar(8), convert(time, a.TimeIn)) as TimeIn,convert(date, a.TimeOut) " +
    //        "as DateTimeOut, convert(varchar(8), convert(time, a.TimeOut)) as TimeOut, a.Type, a.Status, e.FirstName, e.LastName, e.Position From AttendanceRecord as a" +
    //        " INNER JOIN Employee as e ON a.EmployeeID = e.EmployeeID where a.TimeIn > @DateNnow AND a.TimeIn < @DateNtom AND a.Status = 'Override'";
    //    mirai.Parameters.AddWithValue("@DateNnow", dateNtimetoday.ToString("MM-dd-yyyy HH:mm:ss"));
    //    mirai.Parameters.AddWithValue("@DateNtom", dateNtimeTom.ToString("MM-dd-yyyy HH:mm:ss"));
    //    SqlDataReader aki = mirai.ExecuteReader();
    //    if (aki.HasRows)
    //    {
    //        mio.Close();
    //        timeIn("Manual");
    //    }
    //    else
    //    {
    //        mio.Close();
    //        timeIn("M-Pending");
    //    }


    //}
    //void timeIn(string Type)
    //{
    //    mio.Open();
    //    SqlCommand mirai = new SqlCommand();
    //    mirai.Connection = mio;
    //    mirai.CommandText = "INSERT INTO AttendanceRecord VALUES (@EmployeeID, @TimeIn, @TimeOut, @Type, @Status)";
    //    mirai.Parameters.AddWithValue("EmployeeID", Session["empid"].ToString());
    //    mirai.Parameters.AddWithValue("TimeIn", DateTime.Now.ToString("MM-dd-yyyy HH:mm:ss"));
    //    mirai.Parameters.AddWithValue("TimeOut", DBNull.Value);
    //    mirai.Parameters.AddWithValue("Type", Type);
    //    mirai.Parameters.AddWithValue("Status", "Present");
    //    mirai.ExecuteNonQuery();
    //    mio.Close();
    //    btnTimeOut.Visible = true;
    //    btnTimeIn.Visible = false;
    //}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Leave_AddLeave : System.Web.UI.Page
{
    Helper aud = new Helper();
    SqlConnection con = new SqlConnection(Helper.GetCon());
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userid"] != null)
        {
            if (Session["position"].ToString() == "Payroll Officer")
            {
                if (!IsPostBack) { changeddlist(); }
            }
            else
            {
                Response.Redirect("../Login.aspx");
            }
        }
        else
        {
            Response.Redirect("../Login.aspx");
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {

        if (ddLeaveType.SelectedItem.Text == "Maternity")
        {
            bool overlap = overlaps();
            if (overlap)
            {
                DateTime dt1 = DateTime.Parse(startDateTxt.Text);
                DateTime dt2 = dt1;
                if (ddlMatType.SelectedItem.Text == "Normal Delivery/Miscarriage")
                {
                    dt2 = dt2.AddDays(60);
                }
                else if (ddlMatType.SelectedItem.Text == "Caesarian section delivery")
                {
                    dt2 = dt2.AddDays(78);
                }

                Response.Write(dt2.ToString());

                TimeSpan ts = dt2 - dt1;
                int days = int.Parse(ts.TotalDays.ToString());

                con.Open();
                SqlCommand com = new SqlCommand();
                com.Connection = con;
                com.CommandText = "INSERT INTO LeaveRecords VALUES (@EmployeeID, @Status, @LeaveType, @Days, @StartingDate, @EndingDate)";

                com.Parameters.AddWithValue("@EmployeeID", Session["empid"].ToString());
                com.Parameters.AddWithValue("@Status", "Pending");
                com.Parameters.AddWithValue("@LeaveType", ddLeaveType.SelectedValue);
                com.Parameters.AddWithValue("@Days", days);
                com.Parameters.AddWithValue("@StartingDate", startDateTxt.Text);
                com.Parameters.AddWithValue("@EndingDate", dt2.ToString("yyyy-MM-dd"));
                com.ExecuteNonQuery();
                con.Close();

                string name = Session["firstname"].ToString() + " " + Session["lastname"].ToString();
                aud.AuditLog(EncryptHelper.Encrypt("Applied Leave", Helper.GetSalt()), int.Parse(Session["empid"].ToString()), EncryptHelper.Encrypt(name + "Applied for a " + ddLeaveType.SelectedValue + " Leave", Helper.GetSalt()));

                Response.Redirect("getLeaveApplicationHistory.aspx");
            }
            else
            {
                Response.Write("<script>alert('The date is already covered');</script>");
            }
        }
        else if (ddLeaveType.SelectedItem.Text == "Paternity")
        {
            bool overlap = overlaps();
            if (overlap)
            {
                DateTime dt1 = DateTime.Parse(startDateTxt.Text);
                DateTime dt2 = dt1;

                dt2 = dt2.AddDays(7);
                TimeSpan ts = dt2 - dt1;
                int days = int.Parse(ts.TotalDays.ToString());

                con.Open();
                SqlCommand com = new SqlCommand();
                com.Connection = con;
                com.CommandText = "INSERT INTO LeaveRecords VALUES (@EmployeeID, @Status, @LeaveType, @Days, @StartingDate, @EndingDate)";

                com.Parameters.AddWithValue("@EmployeeID", Session["empid"].ToString());
                com.Parameters.AddWithValue("@Status", "Pending");
                com.Parameters.AddWithValue("@LeaveType", ddLeaveType.SelectedValue);
                com.Parameters.AddWithValue("@Days", days);
                com.Parameters.AddWithValue("@StartingDate", startDateTxt.Text);
                com.Parameters.AddWithValue("@EndingDate", dt2.ToString("yyyy-MM-dd"));
                com.ExecuteNonQuery();
                con.Close();

                string name = Session["firstname"].ToString() + " " + Session["lastname"].ToString();
                aud.AuditLog(EncryptHelper.Encrypt("Applied Leave", Helper.GetSalt()), int.Parse(Session["empid"].ToString()), EncryptHelper.Encrypt(name + "Applied for a " + ddLeaveType.SelectedValue + " Leave", Helper.GetSalt()));

                Response.Redirect("getLeaveApplicationHistory.aspx");
            }
            else
            {
                Response.Write("<script>alert('The date is already covered');</script>");
            }
        }
        else
        {
            if (ddLeaveType.SelectedItem.Text == "Service Incentive")
            {
                if (DateTime.Parse(startDateTxt.Text) < DateTime.Parse(endDateTxt.Text))
                {
                    DateTime dt1 = DateTime.Parse(startDateTxt.Text);
                    DateTime dt2 = DateTime.Parse(endDateTxt.Text);
                    bool weekEnd = noWeekends(dt1, dt2);
                    bool holiday = holidays(dt1, dt2);
                    bool overlap = overlaps();
                    bool dholiday = checkDhols(dt1, dt2);
                    TimeSpan ts = dt2 - dt1;
                    int daysTxt = int.Parse(ts.TotalDays.ToString());
                    DayOfWeek check = dt1.DayOfWeek;
                    DayOfWeek check2 = dt2.DayOfWeek;
                    if (overlap)
                    {
                        if (holiday)
                        {
                            if (weekEnd)
                            {
                                if (dholiday)
                                {
                                    con.Open();
                                    SqlCommand com = new SqlCommand();
                                    com.Connection = con;
                                    com.CommandText = "INSERT INTO LeaveRecords VALUES (@EmployeeID, @Status, @LeaveType, @Days, @StartingDate, @EndingDate)";
                                    com.Parameters.AddWithValue("@EmployeeID", Session["empid"].ToString());
                                    com.Parameters.AddWithValue("@Status", "Pending");
                                    com.Parameters.AddWithValue("@LeaveType", ddLeaveType.SelectedValue);
                                    com.Parameters.AddWithValue("@Days", daysTxt);
                                    com.Parameters.AddWithValue("@StartingDate", startDateTxt.Text);
                                    com.Parameters.AddWithValue("@EndingDate", endDateTxt.Text);
                                    com.ExecuteNonQuery();
                                    con.Close();

                                    string name = Session["firstname"].ToString() + " " + Session["lastname"].ToString();
                                    aud.AuditLog(EncryptHelper.Encrypt("Applied Leave", Helper.GetSalt()), int.Parse(Session["empid"].ToString()), EncryptHelper.Encrypt(name + "Applied for a Leave", Helper.GetSalt()));

                                    Response.Redirect("getLeaveApplicationHistory.aspx");
                                }
                                else
                                {
                                    Response.Write("<script>alert('The date you picked is a holiday bes');</script>");
                                }
                            }
                            else
                            {
                                Response.Write("<script>alert('the date should not has weekend');</script>");
                            }
                        }
                        else
                        {
                            Response.Write("<script>alert('The date you picked is a holiday bes');</script>");
                        }
                    }
                    else
                    {
                        Response.Write("<script>alert('The date is already covered');</script>");
                    }
                }
                else
                {
                    Response.Write("<script>alert('The end date of the leave should always be after the start date');</script>");
                }
            }
            else if (ddlDayType.SelectedItem.Text == "Whole")
            {
                if (DateTime.Parse(startDateTxt.Text) < DateTime.Parse(endDateTxt.Text))
                {
                    DateTime dt1 = DateTime.Parse(startDateTxt.Text);
                    DateTime dt2 = DateTime.Parse(endDateTxt.Text);
                    bool weekEnd = noWeekends(dt1, dt2);
                    bool holiday = holidays(dt1, dt2);
                    bool overlap = overlaps();
                    bool dholiday = checkDhols(dt1, dt2);
                    TimeSpan ts = dt2 - dt1;
                    int daysTxt = int.Parse(ts.TotalDays.ToString());
                    DayOfWeek check = dt1.DayOfWeek;
                    DayOfWeek check2 = dt2.DayOfWeek;
                    if (overlap)
                    {
                        if (holiday)
                        {
                            if (weekEnd)
                            {
                                if (dholiday)
                                {
                                    con.Open();
                                    SqlCommand com = new SqlCommand();
                                    com.Connection = con;
                                    com.CommandText = "INSERT INTO LeaveRecords VALUES (@EmployeeID, @Status, @LeaveType, @Days, @StartingDate, @EndingDate)";
                                    com.Parameters.AddWithValue("@EmployeeID", Session["empid"].ToString());
                                    com.Parameters.AddWithValue("@Status", "Pending");
                                    com.Parameters.AddWithValue("@LeaveType", ddLeaveType.SelectedValue);
                                    com.Parameters.AddWithValue("@Days", daysTxt);
                                    com.Parameters.AddWithValue("@StartingDate", startDateTxt.Text);
                                    com.Parameters.AddWithValue("@EndingDate", endDateTxt.Text);
                                    com.ExecuteNonQuery();
                                    con.Close();

                                    string name = Session["firstname"].ToString() + " " + Session["lastname"].ToString();
                                    aud.AuditLog(EncryptHelper.Encrypt("Applied Leave", Helper.GetSalt()), int.Parse(Session["empid"].ToString()), EncryptHelper.Encrypt(name + "Applied for a Leave", Helper.GetSalt()));

                                    Response.Redirect("getLeaveApplicationHistory.aspx");
                                }
                                else
                                {
                                    Response.Write("<script>alert('The date you picked is a holiday bes');</script>");
                                }
                            }
                            else
                            {
                                Response.Write("<script>alert('the date should not has weekend');</script>");
                            }
                        }
                        else
                        {
                            Response.Write("<script>alert('The date you picked is a holiday bes');</script>");
                        }
                    }
                    else
                    {
                        Response.Write("<script>alert('The date is already covered');</script>");
                    }
                }
                else
                {
                    Response.Write("<script>alert('The end date of the leave should always be after the start date');</script>");
                }
            }
            else if (ddlDayType.SelectedItem.Text == "Half")
            {

                DateTime dt1 = DateTime.Parse(startDateTxt.Text);

                bool weekEnd = noWeekends(dt1, dt1);
                bool halfdayoverlap = halfoverlaps();
                bool holiday = holidays(dt1, dt1);
                bool dholiday = checkDhols(dt1, dt1);
                DayOfWeek check = dt1.DayOfWeek;
                if (halfdayoverlap)
                {
                    if (holiday)
                    {
                        if (dholiday)
                        {
                            if (weekEnd)
                            {
                                con.Open();
                                SqlCommand com = new SqlCommand();
                                com.Connection = con;
                                com.CommandText = "INSERT INTO LeaveRecords VALUES (@EmployeeID, @Status, @LeaveType, @Days, @StartingDate, @EndingDate)";
                                com.Parameters.AddWithValue("@EmployeeID", Session["empid"].ToString());
                                com.Parameters.AddWithValue("@Status", "Pending");
                                com.Parameters.AddWithValue("@LeaveType", ddLeaveType.SelectedValue);
                                com.Parameters.AddWithValue("@Days", "0.5");
                                com.Parameters.AddWithValue("@StartingDate", startDateTxt.Text);
                                com.Parameters.AddWithValue("@EndingDate", startDateTxt.Text);
                                com.ExecuteNonQuery();
                                con.Close();

                                string name = Session["firstname"].ToString() + " " + Session["lastname"].ToString();
                                aud.AuditLog(EncryptHelper.Encrypt("Applied Leave", Helper.GetSalt()), int.Parse(Session["empid"].ToString()), EncryptHelper.Encrypt(name + "Applied for a Leave", Helper.GetSalt()));

                                Response.Redirect("getLeaveApplicationHistory.aspx");
                            }
                            else
                            {
                                Response.Write("<script>alert('The Date should not have weekend');</script>");
                            }
                        }
                        else
                        {
                            Response.Write("<script>alert('The date you picked is a holiday bes');</script>");
                        }
                    }
                    else
                    {
                        Response.Write("<script>alert('The date you picked is a holiday bes');</script>");
                    }
                }
                else
                {
                    Response.Write("<script>alert('The Date is already have covered');</script>");
                }
            }
        }
    }

    protected void ddlDayType_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlDayType.SelectedItem.Text == "Whole")
        {
            endDateTxt.Enabled = true;
        }
        else if (ddlDayType.SelectedItem.Text == "Half")
        {
            endDateTxt.Enabled = false;
        }
    }
    protected void ddLeaveType_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddLeaveType.SelectedItem.Text == "Maternity")
        {
            DayType.Style.Add("display", "none");
            enddate.Style.Add("display", "none");
            MatType.Style.Add("display", "block");
        }
        else if (ddLeaveType.SelectedItem.Text == "Paternity")
        {
            DayType.Style.Add("display", "none");
            enddate.Style.Add("display", "none");
            MatType.Style.Add("display", "none");
        }
        else if (ddLeaveType.SelectedItem.Text == "Service Incentive")
        {
            DayType.Style.Add("display", "none");
            enddate.Style.Add("display", "block");
            MatType.Style.Add("display", "none");
        }
        else
        {
            DayType.Style.Add("display", "block");
            MatType.Style.Add("display", "none");
            enddate.Style.Add("display", "block");
        }
    }
    void changeddlist()
    {
        DateTime startdate = DateTime.Parse(Session["DateEmployed"].ToString());
        Response.Write(Session["sex"].ToString());

        if (Session["sex"].ToString() == "Female")
        {
            ddLeaveType.Items.Add("Maternity");
        }
        else if (Session["sex"].ToString() != "Female")
        {
            ddLeaveType.Items.Add("Paternity");
        }
        if (startdate.AddYears(1) < DateTime.Today)
        {
            ddLeaveType.Items.Add("Service Incentive");
        }
    }
    bool noWeekends(DateTime start, DateTime end)
    {
        bool weekEnd = true;
        TimeSpan dateDiff = end - start;
        int totalDays = dateDiff.Days;
        for (var i = 0; i <= totalDays; i++)
        {
            DateTime leave = start.AddDays(i);
            if (leave.DayOfWeek == DayOfWeek.Sunday || leave.DayOfWeek == DayOfWeek.Saturday)
            {
                weekEnd = false;
                break;
            }
            else
            {
                weekEnd = true;
            }
        }
        return weekEnd;
    }

    bool holidays(DateTime start, DateTime end)
    {
        bool holiday = true;
        TimeSpan ts = end - start;
        int daysTxt = int.Parse(ts.TotalDays.ToString());

        string sDate = DateTime.Now.ToString();
        DateTime date = (Convert.ToDateTime(sDate.ToString()));

        int Year = int.Parse(date.Year.ToString());
        DateTime holiday1 = new DateTime(Year, 1, 1);
        DateTime holiday2 = new DateTime(Year, 4, 9);
        DateTime holiday3 = new DateTime(Year, 4, 13);
        DateTime holiday4 = new DateTime(Year, 4, 14);
        DateTime holiday5 = new DateTime(Year, 5, 1);
        DateTime holiday6 = new DateTime(Year, 6, 12);
        DateTime holiday7 = new DateTime(Year, 8, 28);
        DateTime holiday8 = new DateTime(Year, 11, 30);
        DateTime holiday9 = new DateTime(Year, 12, 25);
        DateTime holiday10 = new DateTime(Year, 12, 30);

        if ((start <= holiday1 && end >= holiday1) || (start <= holiday2 && end >= holiday2) || (start <= holiday3 && end >= holiday3)
            || (start <= holiday4 && end >= holiday4) || (start <= holiday5 && end >= holiday5) || (start <= holiday6 && end >= holiday6)
            || (start <= holiday7 && end >= holiday7) || (start <= holiday8 && end >= holiday8) || (start <= holiday9 && end >= holiday9)
            || (start <= holiday10 && end >= holiday10))
        {
            holiday = false;
        }
        else
        {
            holiday = true;
        }
        return holiday;
    }

    bool checkDhols(DateTime start, DateTime end)
    {
        SqlConnection prvcon = new SqlConnection(Helper.GetCon());
        prvcon.Open();

        SqlCommand aiztan = new SqlCommand();
        aiztan.Connection = prvcon;
        aiztan.CommandText = "Select * from Holidays where Date <= @startdate AND Date >= @enddate";
        aiztan.Parameters.AddWithValue("@startdate", start);
        aiztan.Parameters.AddWithValue("@enddate", end);
        SqlDataReader nyan = aiztan.ExecuteReader();
        bool validateholiday;
        validateholiday = nyan.HasRows;
        prvcon.Close();
        if (validateholiday == true)
        {
            return false;
        }
        else
        {
            return true;
        }


    }

    bool overlaps()
    {
        //overlapping
        con.Open();
        SqlCommand com = new SqlCommand();
        com.Connection = con;
        com.CommandText = "select EmployeeID, StartingDate, EndingDate from LeaveRecords where EmployeeID = @EmployeeID AND StartingDate <= @startdate";
        com.Parameters.AddWithValue("@EmployeeID", Session["empid"].ToString());
        com.Parameters.AddWithValue("@startdate", startDateTxt.Text);
        SqlDataReader meguri = com.ExecuteReader();
        bool validatestart;
        validatestart = meguri.HasRows;
        con.Close();

        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "select EmployeeID, StartingDate, EndingDate from LeaveRecords where EmployeeID = @EmployeeID AND EndingDate >= @enddate";
        cmd.Parameters.AddWithValue("@EmployeeID", Session["empid"].ToString());
        cmd.Parameters.AddWithValue("@enddate", endDateTxt.Text);
        SqlDataReader meguri2 = cmd.ExecuteReader();
        bool validateend;
        validateend = meguri2.HasRows;
        con.Close();


        if (validatestart && validateend == true)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    bool halfoverlaps()
    {
        //overlapping
        con.Open();
        SqlCommand com = new SqlCommand();
        com.Connection = con;
        com.CommandText = "select EmployeeID, StartingDate, EndingDate from LeaveRecords where EmployeeID = @EmployeeID AND StartingDate = @startdate";
        com.Parameters.AddWithValue("@EmployeeID", Session["empid"].ToString());
        com.Parameters.AddWithValue("@startdate", startDateTxt.Text);
        SqlDataReader meguri = com.ExecuteReader();
        bool validatestart;
        validatestart = meguri.HasRows;
        con.Close();


        if (validatestart == true)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

}
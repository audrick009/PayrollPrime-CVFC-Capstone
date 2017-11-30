using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

public partial class Admin_ViewAttendance : System.Web.UI.Page
{
    Helper aud = new Helper();
    SqlConnection mio = new SqlConnection(Helper.GetCon());
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userid"] != null)
        {
            if(Session["position"].ToString() == "Admin")
            {
                    getAttendanceRecord();
                    checkOverride();
                    GetEmployees();
                
            }else
            {
                Response.Redirect("../Login.aspx");
            }
        }else
        {
            Response.Redirect("../Login.aspx");
        }

    }
    void getAttendanceRecord()
    {
        mio.Open();
        SqlCommand mirai = new SqlCommand();
        mirai.Connection = mio;
        mirai.CommandText = "Select a.ARID, convert(date, a.TimeIn) as DateTimeIn, convert(varchar(8), convert(time, a.TimeIn)) as TimeIn,convert(date, a.TimeOut) as DateTimeOut,  convert(varchar(8), convert(time, a.TimeOut)) as TimeOut, " +
            "a.Type, a.Status, e.FirstName, e.LastName, e.Position From AttendanceRecord as a INNER JOIN Employee as e ON a.EmployeeID = e.EmployeeID where a.Status != 'Override'";
        SqlDataAdapter da = new SqlDataAdapter(mirai);
        DataSet ds = new DataSet();
        da.Fill(ds, "Attendance");
        lvAttendance.DataSource = ds;
        lvAttendance.DataBind();
        mio.Close();
    }

    protected void btnAttOverride_Click(object sender, EventArgs e)
    {
        OverrideAttendance();
        UpdatePendingAttendance();
        aud.AuditLog(EncryptHelper.Encrypt("Attendance Override", Helper.GetSalt()), int.Parse(Session["empid"].ToString()), EncryptHelper.Encrypt("Allowed attendance override", Helper.GetSalt()));

    }
    void UpdatePendingAttendance()
    {
        var dateNtimetoday = DateTime.Today;
        var dateNtimeTom = dateNtimetoday.AddSeconds(-1).AddDays(1);

        mio.Open();
        SqlCommand mirai = new SqlCommand();
        mirai.Connection = mio;
        mirai.CommandText = "UPDATE AttendanceRecord SET Type='Manual' where Type='M-Pending' AND TimeIn > @DateNnow AND TimeIn < @DateNtom";
        mirai.Parameters.AddWithValue("@DateNnow", dateNtimetoday.ToString("MM-dd-yyyy HH:mm:ss"));
        mirai.Parameters.AddWithValue("@DateNtom", dateNtimeTom.ToString("MM-dd-yyyy HH:mm:ss"));
        mirai.ExecuteNonQuery();
        mio.Close();
        Response.Redirect("ViewAttendance.aspx");
    }
    void OverrideAttendance()
    {
        mio.Open();
        SqlCommand mirai = new SqlCommand();
        mirai.Connection = mio;
        mirai.CommandText = "INSERT INTO AttendanceRecord VALUES (@EmployeeID, @TimeIn, @TimeOut,'Override','Override')";
        mirai.Parameters.AddWithValue("@EmployeeID", Session["empid"].ToString());
        mirai.Parameters.AddWithValue("@TimeIn", DateTime.Now);
        mirai.Parameters.AddWithValue("@TimeOut", DateTime.Now);
        mirai.ExecuteNonQuery();
        mio.Close();
    }
    void checkOverride()
    {
        var dateNtimetoday = DateTime.Today;
        var dateNtimeTom = dateNtimetoday.AddSeconds(-1).AddDays(1);
        ltGG.Text = dateNtimetoday.ToString("MM-dd-yyyy HH:mm:ss") + dateNtimeTom.ToString("MM-dd-yyyy HH:mm:ss");

        mio.Open();
        SqlCommand mirai = new SqlCommand();
        mirai.Connection = mio;
        mirai.CommandText = "Select a.ARID, convert(date, a.TimeIn) as DateTimeIn, convert(varchar(8), convert(time, a.TimeIn)) as TimeIn,convert(date, a.TimeOut) " +
            "as DateTimeOut, convert(varchar(8), convert(time, a.TimeOut)) as TimeOut, a.Type, a.Status, e.FirstName, e.LastName, e.Position From AttendanceRecord as a" +
            " INNER JOIN Employee as e ON a.EmployeeID = e.EmployeeID where a.TimeIn > @DateNnow AND a.TimeIn < @DateNtom AND a.Status = 'Override'";
        mirai.Parameters.AddWithValue("@DateNnow", dateNtimetoday.ToString("MM-dd-yyyy HH:mm:ss"));
        mirai.Parameters.AddWithValue("@DateNtom", dateNtimeTom.ToString("MM-dd-yyyy HH:mm:ss"));
        SqlDataReader aki = mirai.ExecuteReader();
        if (aki.HasRows)
        {
            btnAttOverride.Visible= false;
            ltAlert.Text = "Attendance Override allowed for the day.";
            ltAlert.Visible = true;
        }
        mio.Close();

    }
    void getReportPCov()
    {
        DateTime start = DateTime.Parse(txtStart.Text);
        DateTime end = DateTime.Parse(txtEnd.Text);
        ReportDocument rpt = new ReportDocument();
        rpt.Load(Server.MapPath("~/Reports/attendanceReport1.rpt"));
        rpt.SetDatabaseLogon("sa", "dbpass", "DESKTOP-JQC0U4J", "CVFCPayroll");
        rpt.SetParameterValue("startdate", txtStart.Text);
        rpt.SetParameterValue("enddate", txtEnd.Text);
        rpt.SetParameterValue("starttext", start.ToString(" MMMM dd,yyyy "));
        rpt.SetParameterValue("endtext", end.ToString(" MMMM dd,yyyy "));
        rpt.SetParameterValue("fullname", Session["firstname"].ToString() + " " + Session["lastname"].ToString());
        rpt.ExportToHttpResponse(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, Response, true, "Employee Audit Log Records as of " + DateTime.Now.ToString());
    }
    void getReportEmp()
    {
        ReportDocument rpt = new ReportDocument();
        rpt.Load(Server.MapPath("~/Reports/attendanceReport2.rpt"));
        rpt.SetDatabaseLogon("sa", "dbpass", "DESKTOP-JQC0U4J", "CVFCPayroll");
        rpt.SetParameterValue("EmployeeID", ddlEmployees.SelectedValue);
        rpt.SetParameterValue("fullname", Session["firstname"].ToString() + " " + Session["lastname"].ToString());
        rpt.ExportToHttpResponse(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, Response, true, "Employee Audit Log Records as of " + DateTime.Now.ToString());
    }
    protected void btnGenRep_Click(object sender, EventArgs e)
    {
        aud.AuditLog(EncryptHelper.Encrypt("Attendance Report", Helper.GetSalt()), int.Parse(Session["empid"].ToString()), EncryptHelper.Encrypt("Generated by date", Helper.GetSalt()));
        getReportPCov();
    }

    protected void btnGenRepEmp_Click(object sender, EventArgs e)
    {
        aud.AuditLog(EncryptHelper.Encrypt("Attendance Report", Helper.GetSalt()), int.Parse(Session["empid"].ToString()), EncryptHelper.Encrypt("Generated audit logs of " + ddlEmployees.SelectedItem.Text, Helper.GetSalt()));
        getReportEmp();
    }
    public void GetEmployees()
    {
        mio.Open();
        SqlCommand com = new SqlCommand();
        com.Connection = mio;
        com.CommandText = "SELECT EmployeeID, (FirstName +' '+ MiddleName +' '+ LastName) AS FullName FROM Employee";
        SqlDataReader dr = com.ExecuteReader();
        ddlEmployees.DataSource = dr;
        ddlEmployees.DataTextField = "FullName";
        ddlEmployees.DataValueField = "EmployeeID";
        ddlEmployees.DataBind();

    
        mio.Close();
    }
    
}
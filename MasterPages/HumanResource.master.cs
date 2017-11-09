using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class MasterPages_HumanResource : System.Web.UI.MasterPage
{
    SqlConnection con = new SqlConnection(Helper.GetCon());
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["userid"] != null)
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
}


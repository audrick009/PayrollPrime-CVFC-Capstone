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
        if(Session["userid"] != null)
        {

        }
        else
        {
            Response.Redirect("../Login.aspx");
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        con.Open();
        SqlCommand com = new SqlCommand();
        com.Connection = con;
        com.CommandText = "INSERT INTO LeaveRecords VALUES (@EmployeeID, @Status, @LeaveType, @Days, @StartingDate, @EndingDate)";

        com.Parameters.AddWithValue("@EmployeeID", Session["empid"].ToString());
        com.Parameters.AddWithValue("@Status", "Pending");
        com.Parameters.AddWithValue("@LeaveType", ddLeaveType.SelectedValue);
        com.Parameters.AddWithValue("@Days", daysTxt.Text);
        com.Parameters.AddWithValue("@StartingDate", startDateTxt.Text);
        com.Parameters.AddWithValue("@EndingDate", endDateTxt.Text);
        com.ExecuteNonQuery();
        con.Close();

        String name = Session["firstname"].ToString() + " " + Session["lastname"].ToString();
        aud.AuditLog("Applied Leave", int.Parse(Session["empid"].ToString()), name + " Applied Leave");

        Response.Redirect("getLeaveApplicationHistory.aspx");
    }
}
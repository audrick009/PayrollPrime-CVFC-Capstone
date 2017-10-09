using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Employee_getLeaveApplicationHistory : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(Helper.GetCon());
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["empid"] != null)
        {
            GetLeaveApplicationHistory();
        }
        else
        {
            Response.Redirect("../login.aspx");
        }        
            
    }
        
   

    void GetLeaveApplicationHistory()
    {
        con.Open();
        SqlCommand com = new SqlCommand();
        com.Connection = con;
        com.CommandText = "SELECT LeaveRID, EmployeeID, Status, LeaveType, Days, StartingDate, EndingDate FROM LeaveRecords WHERE EmployeeID = @empid";
        com.Parameters.AddWithValue("@empid", Session["empid"].ToString());
        SqlDataReader dr = com.ExecuteReader();
        lvLeaveApp.DataSource = dr;
        lvLeaveApp.DataBind();
        con.Close();
    }
}

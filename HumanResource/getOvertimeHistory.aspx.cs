using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Employee_getOvertimeHistory : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(Helper.GetCon());
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["empid"] != null )
        {
            getOvertimeHistory();
        }
        else
        {
            Response.Redirect("../Login.aspx");
        }
    }
    void getOvertimeHistory()
    {
        con.Open();
        SqlCommand com = new SqlCommand();
        com.Connection = con;
        com.CommandText = "SELECT OTRID, EmployeeID, Date, Hours, StartTime, EndTime, Reason, Status FROM OvertimeRecords WHERE EmployeeID = @empid";
        com.Parameters.AddWithValue("@empid", Session["empid"].ToString());
        SqlDataReader dr = com.ExecuteReader();
        lvOvertimeHistory.DataSource = dr;
        lvOvertimeHistory.DataBind();
        con.Close();

    }
}
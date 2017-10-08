using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class addOvertime : System.Web.UI.Page
{
    Helper aud = new Helper();
    SqlConnection con = new SqlConnection(Helper.GetCon());
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userid"] != null)
        {

        }
        else
        {
            Response.Redirect("../Login.aspx");
        }
    }


    protected void addOvertimeBTN_Click(object sender, EventArgs e)
    {
        string appby = Session["FirstName"].ToString() + ' ' + Session["LastName"].ToString();
        var date = DateTime.Parse(dateTXT.Text);
        con.Open();
        SqlCommand com = new SqlCommand();
        com.Connection = con;
        com.CommandText = "INSERT INTO OvertimeRecords VALUES (@EmployeeID, @Date, @Hours, @StartTime, @EndTime, @Reason, @Status, @ApprovedBy)";
        com.Parameters.AddWithValue("@EmployeeID", Session["empid"].ToString());
        com.Parameters.AddWithValue("@Date", date);
        com.Parameters.AddWithValue("@Hours", hoursTXT.Text);
        com.Parameters.AddWithValue("@StartTime", date.AddHours(17));
        com.Parameters.AddWithValue("@EndTime", date.AddHours(17 + int.Parse(hoursTXT.Text)));
        com.Parameters.AddWithValue("@Reason", reasonTXT.Text);
        com.Parameters.AddWithValue("@Status", "Pending");
        com.Parameters.AddWithValue("@ApprovedBy", DBNull.Value);
        com.ExecuteNonQuery();
        con.Close();
        String name = Session["firstname"].ToString() + " " + Session["lastname"].ToString();
        aud.AuditLog("Applied Overtime", int.Parse(Session["empid"].ToString()), name + " Applied Overtime");

        Response.Redirect("ThanksOvertime.aspx");
    }
}
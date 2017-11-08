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
            if(Session["position"].ToString() == "Admin")
            {

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
        if (ddlDayType.SelectedItem.Text == "Whole")
        {
            if (DateTime.Parse(startDateTxt.Text) < DateTime.Parse(endDateTxt.Text))
            {
                DateTime dt1 = DateTime.Parse(startDateTxt.Text);
                DateTime dt2 = DateTime.Parse(endDateTxt.Text);
                TimeSpan ts = dt2 - dt1;
                int daysTxt = int.Parse(ts.TotalDays.ToString());
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
                Response.Write("<script>alert('The end date of the leave should always be after the start date');</script>");
        }
        else if (ddlDayType.SelectedItem.Text == "Half")
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
    }

    protected void ddlDayType_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlDayType.SelectedIndex == 0)
        {
            endDateTxt.Enabled = true;
        }
        else if (ddlDayType.SelectedIndex == 1)
        {
            endDateTxt.Enabled = false;
        }
    }

}
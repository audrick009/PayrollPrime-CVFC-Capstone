using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class updateLeaveForm : System.Web.UI.Page
{
    Helper aud = new Helper();
    SqlConnection con = new SqlConnection(Helper.GetCon());
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Request.QueryString["LeaveRID"] != null)
        {
            int LeaveRID = 0;
            bool validLeaveRID = int.TryParse(Request.QueryString["LeaveRID"].ToString(), out LeaveRID);

            if (validLeaveRID)
            {
                if (!IsPostBack)
                {
                    GetLeaveApplication(LeaveRID);
                }
            }
            else
            {
                Response.Redirect("getLeaveApplication.aspx");
            }
        }

        if (Session["userid"] != null)
        {
            if (Session["position"].ToString() == "Department Head")
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

    void GetLeaveApplication(int LeaveRID)
    {
        con.Open();
        SqlCommand com = new SqlCommand();
        com.Connection = con;
        com.CommandText = "SELECT LeaveRID, EmployeeID, Status, LeaveType, Days, StartingDate, EndingDate FROM LeaveRecords WHERE LeaveRID = @LeaveRID";
        com.Parameters.AddWithValue("@LeaveRID", LeaveRID);
        SqlDataReader dr = com.ExecuteReader();
        if (dr.HasRows)
        {
            while(dr.Read())
            {
                leaveRIDTXT.Text = dr["LeaveRID"].ToString();
                employeeTXT.Text = dr["EmployeeID"].ToString();
                statusTXT.Text = dr["Status"].ToString();
                leavetypeTXT.Text = dr["LeaveType"].ToString();
                daysTXT.Text = dr["Days"].ToString();
                startingDateTXT.Text = dr["StartingDate"].ToString();
                endingDateTXT.Text = dr["EndingDate"].ToString();
            }
        }
       

    }

    protected void approveBTN_Click(object sender, EventArgs e)
    {
        con.Open();
        SqlCommand com = new SqlCommand();
        com.Connection = con;
        com.CommandText = "UPDATE LeaveRecords SET Status='Approved' WHERE LeaveRID = @LeaveRID";
        com.Parameters.AddWithValue("@LeaveRID", Request.QueryString["LeaveRID"].ToString());
        com.ExecuteNonQuery();
        con.Close();
        String name = Session["firstname"].ToString() + " " + Session["lastname"].ToString();
        aud.AuditLog("Approved Leave", int.Parse(Session["empid"].ToString()), name + "Approved Leave for LeaveRID" + Request.QueryString["LeaveRID"].ToString());
        Response.Redirect("GetLeaveApplication.aspx");
    }

    protected void rejectBTN_Click(object sender, EventArgs e)
    {
        con.Open();
        SqlCommand com = new SqlCommand();
        com.Connection = con;
        com.CommandText = "UPDATE LeaveRecords SET Status='Rejected' WHERE LeaveRID = @LeaveRID";
        com.Parameters.AddWithValue("@LeaveRID", Request.QueryString["LeaveRID"].ToString());
        com.ExecuteNonQuery();
        con.Close();
        String name = Session["firstname"].ToString() + " " + Session["lastname"].ToString();
        aud.AuditLog("Rejected Leave", int.Parse(Session["empid"].ToString()), name + "Rejected Leave for LeaveRID" + Request.QueryString["LeaveRID"].ToString());
        Response.Redirect("GetLeaveApplication.aspx");
    }
}
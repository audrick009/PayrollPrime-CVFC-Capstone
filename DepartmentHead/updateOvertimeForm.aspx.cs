using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class DepartmentHead_updateOvertimeForm : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(Helper.GetCon());
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["OTRID"] != null)
        {
            int OTRID = 0;
            bool validOTRID = int.TryParse(Request.QueryString["OTRID"].ToString(), out OTRID);

            if (validOTRID)
            {
                if (!IsPostBack)
                {
                    GetOvertimeApplication(OTRID);
                }
            }
            else
            {
                Response.Redirect("getOvertimeApplication.aspx");
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

    void GetOvertimeApplication(int OTRID)
    {
        con.Open();
        SqlCommand com = new SqlCommand();
        com.Connection = con;
        com.CommandText = "SELECT OTRID, EmployeeID, Date, Hours, StartTime, EndTime, Reason, Status, ApprovedBy FROM OvertimeRecords WHERE OTRID =  @OTRID";
        com.Parameters.AddWithValue("@OTRID", OTRID);
        SqlDataReader dr = com.ExecuteReader();
        if (dr.HasRows)
        {
            while(dr.Read())
            {
                otRIDTXT.Text = dr["OTRID"].ToString();
                employeeIDTXT.Text = dr["EmployeeID"].ToString();
                dateTXT.Text = dr["Date"].ToString();
                hoursTXT.Text = dr["Hours"].ToString();
                startTXT.Text = dr["StartTime"].ToString();
                endTXT.Text = dr["EndTime"].ToString();
                reasonTXT.Text = dr["Reason"].ToString();
                statusTXT.Text = dr["Status"].ToString();
                approveTXT.Text = dr["ApprovedBy"].ToString();
            }
        }

    }

    protected void approveBTN_Click(object sender, EventArgs e)
    {
        string appby = Session["FirstName"].ToString() + ' ' + Session["LastName"].ToString();
        con.Open();
        SqlCommand com = new SqlCommand();
        com.Connection = con;
        com.CommandText = "UPDATE OvertimeRecords SET Status='Approved', ApprovedBy=@ApprovedBy WHERE OTRID = @OTRID";
        com.Parameters.AddWithValue("@OTRID", Request.QueryString["OTRID"].ToString());
        com.Parameters.AddWithValue("@ApprovedBy", appby);
        com.ExecuteNonQuery();
        con.Close();
        Response.Redirect("getOvertimeApplication.aspx");
    }

    protected void rejectBTN_Click(object sender, EventArgs e)
    {
        string appby = Session["FirstName"].ToString() + ' ' + Session["LastName"].ToString();
        con.Open();
        SqlCommand com = new SqlCommand();
        com.Connection = con;
        com.CommandText = "UPDATE OvertimeRecords SET Status='Rejected', ApprovedBy= @ApprovedBy WHERE OTRID = @OTRID";
        com.Parameters.AddWithValue("@OTRID", Request.QueryString["OTRID"].ToString());
        com.Parameters.AddWithValue("@ApprovedBy", appby);
        com.ExecuteNonQuery();
        con.Close();
        Response.Redirect("getOvertimeApplication.aspx");
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class DepartmentHead_RejectLeave : System.Web.UI.Page
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
                    string name = Session["firstname"].ToString() + " " + Session["lastname"].ToString();
                    aud.AuditLog(EncryptHelper.Encrypt("Rejected Leave", Helper.GetSalt()), int.Parse(Session["empid"].ToString()), EncryptHelper.Encrypt(name + "Rejected Leave for LeaveRID " + Request.QueryString["LeaveRID"].ToString(), Helper.GetSalt()));
                    Reject(LeaveRID);
                }
            }
            else
            {
                Response.Redirect("getLeaveApplication.aspx");
            }
        }
        //if (Session["userid"] != null)
        //{
        //    if (Session["position"].ToString() == "Department Head")
        //    {

        //    }
        //    else
        //    {
        //        Response.Redirect("../Login.aspx");
        //    }
        //}
        //else
        //{
        //    Response.Redirect("../Login.aspx");
        //}
    }
    void Reject(int ID)
    {
        con.Open();
        SqlCommand com = new SqlCommand();
        com.Connection = con;
        com.CommandText = "UPDATE LeaveRecords SET Status='Rejected' WHERE LeaveRID = @LeaveRID";
        com.Parameters.AddWithValue("@LeaveRID", Request.QueryString["LeaveRID"].ToString());
        com.ExecuteNonQuery();
        con.Close();
        Response.Redirect("getLeaveApplication.aspx");
    }
}
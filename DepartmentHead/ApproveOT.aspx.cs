using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class DepartmentHead_Approve : System.Web.UI.Page
{
    Helper aud = new Helper();
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
                    string name = Session["firstname"].ToString() + " " + Session["lastname"].ToString();
                    aud.AuditLog(EncryptHelper.Encrypt("Approved OT", Helper.GetSalt()), int.Parse(Session["empid"].ToString()), EncryptHelper.Encrypt(name + "Approved OT for OTRID " + Request.QueryString["OTRID"].ToString(), Helper.GetSalt()));
                    Approve(OTRID);
                }
            }
            else
            {
                Response.Redirect("getOvertimeApplication.aspx");
            }
        }
    }
       void Approve(int ID)
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
        //string name = Session["firstname"].ToString() + " " + Session["lastname"].ToString();
        //aud.AuditLog(EncryptHelper.Encrypt("Approved OT", Helper.GetSalt()), int.Parse(Session["empid"].ToString()), EncryptHelper.Encrypt(name + "Approved OT for OTRID" + Request.QueryString["OTRID"].ToString(), Helper.GetSalt()));
        Response.Redirect("getOvertimeApplication.aspx");
    }

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class DepartmentHead_Reject : System.Web.UI.Page
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
                    Reject(OTRID);
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

    void Reject(int ID)
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
    

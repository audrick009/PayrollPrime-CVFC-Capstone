using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Admin_ViewUserAccountDetails : System.Web.UI.Page
{
    Helper aud = new Helper();
    SqlConnection con = new SqlConnection(Helper.GetCon());
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["position"].ToString() != null)
        {
            if (Session["position"].ToString() == "Admin")
            {
                if (Request.QueryString["ID"].ToString() != null)
                {
                    int userid = 0;
                    bool validuserID = int.TryParse(Request.QueryString["ID"].ToString(), out userid);
                    if (validuserID)
                    {
                        aud.AuditLog("View Account Details", int.Parse(Session["empid"].ToString()), "Viewed: " + EmployeeName());
                        getUserAccountDetails(userid);
                    }
                    else
                        Response.Redirect("ViewUserAccount.aspx");
                }
                else
                    Response.Redirect("ViewUserAccount.aspx");
            }
            else
                Response.Redirect("../Login.aspx");
        }
        else
        {
            Response.Redirect("../Login.aspx");
        }
            
        
    }

    void getUserAccountDetails(int ID)
    {
        con.Open();
        SqlCommand com = new SqlCommand();
        com.Connection = con;
        com.CommandText = "SELECT u.UserID, e.FirstName + ' ' + e.MiddleName + ' ' + e.LastName AS FullName, " + 
            "u.Username, u.Password, e.Status, u.DateAdded FROM Users u INNER JOIN Employee e ON u.EmployeeID = e.EmployeeID WHERE UserID=@UserID";
        com.Parameters.AddWithValue("@UserID", ID);
        SqlDataReader dr = com.ExecuteReader();
        if (dr.HasRows)
        {
            while (dr.Read())
            {
                ltID.Text = dr["UserID"].ToString();
                ltName.Text = dr["FullName"].ToString();
                ltUname.Text = dr["Username"].ToString();
                ltStatus.Text = dr["Status"].ToString();
               ltDateAdded.Text = dr["DateAdded"].ToString();
            }
            con.Close();
        }
    }
   
    public string EmployeeName()
    {
        string fullname = null;
        con.Open();
        SqlCommand com = new SqlCommand();
        com.Connection = con;
        com.CommandText = "SELECT u.UserID, e.FirstName + ' ' + e.MiddleName + ' ' + e.LastName AS FullName FROM Users u INNER JOIN Employee e ON u.EmployeeID = e.EmployeeID WHERE UserID=@UserID";
        com.Parameters.AddWithValue("@UserID", Request.QueryString["ID"].ToString());
        SqlDataReader dr = com.ExecuteReader();
        if (dr.HasRows)
        {
            while (dr.Read())
            {
                fullname = dr["FullName"].ToString();
            }
        }
        con.Close();
        return fullname;
        
    }


}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class UpdateAccountDetails : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(Helper.GetCon());
    Helper aud = new Helper();
   
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["position"].ToString() != null)
        {
            if (Session["position"].ToString() == "Admin")
            {
                if (Request.QueryString["ID"] != null)
                {
                    int userID = 0;
                    bool validUser = int.TryParse(Request.QueryString["ID"].ToString(), out userID);

                    if (validUser)
                    {
                        if (!IsPostBack)
                        {
                            GetAccountDetails(userID);
                        }
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
            Response.Redirect("../Login.aspx");
            
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        if(ReEnterNP.Text == txtPassword.Text)
        {
            string name = Session["FirstName"].ToString() + ' ' + Session["LastName"].ToString();
            con.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandText = "UPDATE Users SET Password=@Password, DateModified=@DateModified, ModifiedBy=@ModifiedBy WHERE UserID=@UserID";

            com.Parameters.AddWithValue("@Password", Helper.CreateSHAHash(txtPassword.Text));
            com.Parameters.AddWithValue("@DateModified", DateTime.Now);
            com.Parameters.AddWithValue("@ModifiedBy", name);
            com.Parameters.AddWithValue("@UserID", Request.QueryString["ID"].ToString());
            com.ExecuteNonQuery();
            con.Close();
            aud.AuditLog("Update Password", int.Parse(Session["empid"].ToString()), "Updated: " + EmployeeName());
            Response.Redirect("ViewUserAccount.aspx");
            validatealert.Visible = false;
        }
        else
        {
            validatealert.Visible = true;
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
        return fullname;

    }

    void GetAccountDetails(int ID)
    {
        con.Open();
        SqlCommand com = new SqlCommand();
        com.Connection = con;
        com.CommandText = "SELECT u.UserID, e.FirstName + ' ' + e.MiddleName + ' ' + e.LastName AS FullName, " +
            "u.Username, u.Password, u.DateModified, u.ModifiedBy FROM Users u INNER JOIN Employee e ON u.EmployeeID = e.EmployeeID WHERE UserID=@UserID";
        com.Parameters.AddWithValue("@UserID", Request.QueryString["ID"].ToString());
        SqlDataReader dr = com.ExecuteReader();

        if (dr.HasRows)
        {
            while (dr.Read())
            {
                txtID.Text = dr["UserID"].ToString();
                txtName.Text = dr["FullName"].ToString();
                txtUname.Text = dr["Username"].ToString();
                
            }
            con.Close();
        }
        else
        {
            con.Close();
            Response.Redirect("ViewUserAccount.aspx");
        }
    }

    
}
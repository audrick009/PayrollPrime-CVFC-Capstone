using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class Admin_ChangePasswordAdmin : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(Helper.GetCon());
    Helper aud = new Helper();
    string cpassword;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["position"].ToString() != null)
        {
            if (Session["position"].ToString() == "Admin")
            {
                GetCurrentPassword();
            }
        }
    }

    protected void btnChangePassword_Click(object sender, EventArgs e)
    {
        string name = Session["firstname"].ToString() + Session["lastname"].ToString();
        string cpass = Helper.CreateSHAHash(txtCPassword.Text);
        con.Open();
        SqlCommand com = new SqlCommand();
        com.Connection = con;

        if (cpass == cpassword.ToString())
        {
            if (txtNPassword.Text == txtReEnterNP.Text)
            {
                com.CommandText = "UPDATE Users SET Password=@Password WHERE UserID=@UserID";
                com.Parameters.AddWithValue("@Password", Helper.CreateSHAHash(txtNPassword.Text));
                com.Parameters.AddWithValue("@UserID", Session["userid"].ToString());
                com.ExecuteNonQuery();
                con.Close();
                aud.AuditLog("Change Password", int.Parse(Session["empid"].ToString()), "Updated: " + name + "'s" + " Password");
                validatealert.Visible = false;
                validatealert2.Visible = false;

            }
            else
            {
                validatealert.Visible = false;
                validatealert2.Visible = true;
            }
        }
        else
        {
            validatealert.Visible = true;
            validatealert2.Visible = false;
        }
    }

    void GetCurrentPassword()
    {
        con.Open();
        SqlCommand com = new SqlCommand();
        com.Connection = con;
        com.CommandText = "SELECT Password FROM Users WHERE UserID=@UserID";
        com.Parameters.AddWithValue("@UserID", Session["userid"].ToString());
        SqlDataReader dr = com.ExecuteReader();
        if (dr.HasRows)
        {
            while (dr.Read())
            {
                cpassword = dr["Password"].ToString();
            }
            con.Close();
        }

    }

}
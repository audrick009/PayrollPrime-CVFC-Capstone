using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class AddUserAccount : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(Helper.GetCon());
    Helper aud = new Helper();
  

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["position"].ToString() != null)
        {
            if (Session["position"].ToString() == "Admin")
            {

                if (!IsPostBack)
                {
                    GetEmployeeNames();
                    //checkIfExisting();
                }
            }
            else
                Response.Redirect("../Login.aspx");
        }
        else
            Response.Redirect("../Login.aspx");

    }

    void GetEmployeeNames() // this method is a function for the btnAdd to insert the selected names as Employee ID in the database (for add user account)
    {

        con.Open();
        SqlCommand com = new SqlCommand();
        com.Connection = con;
        com.CommandText = "SELECT EmployeeID, FirstName +' '+ MiddleName +' '+ LastName AS FullName FROM Employee WHERE Status = 'Employed' AND EmployeeID NOT IN(SELECT UserID FROM Users)";
        SqlDataReader dr = com.ExecuteReader();
        ddlEmployees.DataSource = dr;
        ddlEmployees.DataTextField = "FullName";
        ddlEmployees.DataValueField = "EmployeeID";
        ddlEmployees.DataBind();
        con.Close();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        int checkInput;
        if (int.TryParse(txtUname.Text, out checkInput))
        {

            con.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = con;

            com.CommandText = "SELECT Count(*) FROM Users WHERE Username=@Username";
            com.Parameters.AddWithValue("@Username", txtUname.Text);
            int uname = (int)com.ExecuteScalar();

            if(uname == 0)
            {
                com.CommandText = "INSERT INTO Users VALUES(@EmployeeID, @Username, @Password, @DateAdded, @DateModified, @ModifiedBy)";
                com.Parameters.AddWithValue("@EmployeeID", ddlEmployees.SelectedValue);
                com.Parameters.AddWithValue("@Username2", txtUname.Text);
                com.Parameters.AddWithValue("@Password", Helper.CreateSHAHash(txtPword.Text));
                com.Parameters.AddWithValue("@DateAdded", DateTime.Now);
                com.Parameters.AddWithValue("@DateModified", DBNull.Value);
                com.Parameters.AddWithValue("@ModifiedBy", DBNull.Value);
                com.ExecuteNonQuery();
                con.Close();

                aud.AuditLog("Added a User Account", int.Parse(Session["empid"].ToString()), "Added: " + ddlEmployees.SelectedItem.Text);
                Response.Redirect("ViewUserAccount.aspx");
                validatealert2.Visible = false;
            }
            else
            {
                validatealert2.Visible = true;
            }
        }
        else
        {
            validatealert.Visible = true;
        }
    }

}
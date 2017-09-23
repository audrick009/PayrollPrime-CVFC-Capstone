using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class ViewUserAccount : System.Web.UI.Page
{
    Helper aud = new Helper();
    SqlConnection con = new SqlConnection(Helper.GetCon());
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Session["position"] != null)
        {
            if(Session["position"].ToString() == "Admin"){
                if (!IsPostBack)
                {
                    GetAccounts();
                }
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

    void GetAccounts() // This method is for displaying the data to the table.
    {
        con.Open();
        SqlCommand com = new SqlCommand();
        com.Connection = con;
        com.CommandText = "SELECT u.UserID, e.FirstName + ' ' + e.MiddleName + ' ' + e.LastName AS FullName, u.Username, e.Position, e.Status," +
            "u.DateAdded, u.DateModified, u.ModifiedBy FROM Users u INNER JOIN Employee e ON u.EmployeeID = e.EmployeeID WHERE Status = 'Employed'";
        SqlDataAdapter da = new SqlDataAdapter(com);
        DataSet ds = new DataSet();
        da.Fill(ds, "Accounts");
        lvAccounts.DataSource = ds;
        lvAccounts.DataBind();
        con.Close();
    }





    protected void btnSearch_Click(object sender, EventArgs e)
    {
     
        con.Open();
        SqlCommand com = new SqlCommand();
        com.Connection = con;
        com.CommandText = "SELECT u.UserID, e.FirstName + ' ' + e.MiddleName + ' ' + e.LastName AS FullName, u.Username, " +
                "u.Password, e.Status, e.Position, u.DateAdded, u.DateModified, u.ModifiedBy FROM Users u INNER JOIN " +
                "Employee e ON u.EmployeeID=e.EmployeeID WHERE Status = 'Employed' AND " + ddlCat.SelectedItem.Text + " ='" + txtSearch.Text + "'";
        SqlDataAdapter da = new SqlDataAdapter(com);
        DataSet ds = new DataSet();
        da.Fill(ds, "Users");
        lvAccounts.DataSource = ds;
        lvAccounts.DataBind();
        con.Close();

        String name = Session["firstname"].ToString() + " " + Session["lastname"].ToString();
        aud.AuditLog("Search Users", int.Parse(Session["empid"].ToString()), name + "searched for users using " + ddlCat.SelectedItem.Text + " : " + txtSearch.Text);


    }
}
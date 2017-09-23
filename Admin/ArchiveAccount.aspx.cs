using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class ArchiveAccount : System.Web.UI.Page
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
                    int employeeID = 0;
                    bool validEmpID = int.TryParse(Request.QueryString["ID"].ToString(), out employeeID);

                    if (validEmpID)
                    {
                        if (!IsPostBack)
                        {
                            aud.AuditLog("Archive", int.Parse(Session["empid"].ToString()), "Account Archived: " + EmployeeName());
                            ArchiveRecord(employeeID);
                        }
                    }
                    else Response.Redirect("ViewUserAccount.aspx");
                }
                else Response.Redirect("ViewUserAccount.aspx");
            }
            else
                Response.Redirect("../Login.aspx");
        }
        else
                Response.Redirect("../Login.aspx");
        }
      
       
    void ArchiveRecord(int ID)
    {
        con.Open();
        SqlCommand com = new SqlCommand();
        com.Connection = con;
        com.CommandText = "UPDATE Employee SET Status='Archived' WHERE EmployeeID=@EmployeeID";
        com.Parameters.AddWithValue("@EmployeeID", ID);
        com.ExecuteNonQuery();
        con.Close();
        Response.Redirect("ViewUserAccount.aspx");
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
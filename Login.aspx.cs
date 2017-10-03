using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Login : System.Web.UI.Page
{
    SqlConnection mio = new SqlConnection(Helper.GetCon());
    Helper aud = new Helper();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userid"] != null)
        {
            if (Session["Position"].ToString() == "Admin")
            {
                Response.Redirect("Admin/ViewAuditLog.aspx");
            }
            else if (Session["Position"].ToString() == "Department Head")
            {
                Response.Redirect("DepartmentHead/getLeaveApplication.aspx");
            }
            else if (Session["Position"].ToString() == "Employee")
            {
                Response.Redirect("Employee/AddLeave.aspx");
            }
            else if (Session["Position"].ToString() == "Human Resource")
            {
                Response.Redirect("HumanResource/EmployeeInfo.aspx");
            }
            else if (Session["Position"].ToString() == "Payroll Officer")
            {
                Response.Redirect("PayrollOfficer/GenerateEmpPay.aspx");
            }
            else
            {
                Response.Redirect("Errorpage.aspx");
            }
        }
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        string name = "";
        mio.Open();
        SqlCommand mirai = new SqlCommand();
        mirai.Connection = mio;
        //nag dagdag ako ng status para pag na archived di na accessible ung account
        //lagay mo to dyan sa taas kasi di sia kita sa gilid mga 1 hr nako nagtataka bat di ako maka login pota haha
        mirai.CommandText = "Select Users.UserID, Users.Username, Users.Password, Employee.EmployeeID, Employee.Position, Employee.LastName, Employee.FirstName From Users INNER JOIN Employee ON Users.EmployeeID = Employee.EmployeeID Where Username=@username AND Password=@password AND Status='Employed'"; 
        mirai.Parameters.AddWithValue("@username", txtUsername.Text);
        mirai.Parameters.AddWithValue("@password", Helper.CreateSHAHash(txtPassword.Text));
        SqlDataReader aki = mirai.ExecuteReader();
        if (aki.HasRows)
        {
            while (aki.Read())
            {
                Session["userid"] = aki["UserID"].ToString();
                Session["empid"] = aki["EmployeeID"].ToString();
                Session["position"] = aki["Position"].ToString();
                Session["lastname"] = aki["LastName"].ToString();
                Session["firstname"] = aki["FirstName"].ToString();
            }
            mio.Close();
            if (Session["Position"].ToString() == "Admin")
            {
                Response.Redirect("Admin/ViewAuditLog.aspx");
            }
            else if (Session["Position"].ToString() == "Department Head")
            {
                Response.Redirect("DepartmentHead/getLeaveApplication.aspx");
            }
            else if (Session["Position"].ToString() == "Employee")
            {
                Response.Redirect("Employee/AddLeave.aspx");
            }
            else if (Session["Position"].ToString() == "Human Resource")
            {
                Response.Redirect("HumanResource/EmployeeInfo.aspx");
            }
            else if (Session["Position"].ToString() == "Payroll Officer")
            {
                Response.Redirect("PayrollOfficer/GenerateEmpPay.aspx");
            }
            else
            {
                Response.Redirect("Errorpage.aspx");
            }
            mio.Close();
            name = Session["firstname"].ToString() + " " + Session["lastname"].ToString();
            aud.AuditLog("Log In", int.Parse(Session["empid"].ToString()), name + "logged in");

        }
        else
        {
            mio.Close();
            error.Visible = true;
        }
        
        
    }
}
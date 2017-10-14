using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


public partial class Logout : System.Web.UI.Page
{
    Helper aud = new Helper();
    protected void Page_Load(object sender, EventArgs e)
    {
        String name = Session["firstname"].ToString() + " " + Session["lastname"].ToString();
        int EmpID = int.Parse(Session["empid"].ToString());
        Session.Abandon();
        Session.Clear();

        aud.AuditLog("Logged Out", EmpID, name + " logged out");
        Response.Redirect("Login.aspx");
    }
}
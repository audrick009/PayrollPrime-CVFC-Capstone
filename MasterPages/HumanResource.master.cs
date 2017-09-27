using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class MasterPages_HumanResource : System.Web.UI.MasterPage
{
    SqlConnection con = new SqlConnection(Helper.GetCon());
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userid"] != null)
        {
            ltFN.Text = Session["LastName"].ToString();
            ltLN.Text = Session["FirstName"].ToString();
            ltUser.Text = Session["Position"].ToString();
        }
        else
        {
            Response.Redirect("~/Login.aspx");
        }
    }
}
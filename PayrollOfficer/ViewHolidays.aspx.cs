using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class PayrollOfficer_ViewHolidays : System.Web.UI.Page
{
    SqlConnection mio = new SqlConnection(Helper.GetCon());

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userid"] != null)
        {
            mio.Open();
            SqlCommand mirai = new SqlCommand();
            mirai.Connection = mio;
            mirai.CommandText = "SELECT hName, Date, hDesc FROM Holidays";
            SqlDataAdapter da = new SqlDataAdapter(mirai);
            DataSet ds = new DataSet();
            da.Fill(ds, "Holidays");
            lvHoliday.DataSource = ds;
            lvHoliday.DataBind();
            mio.Close();
        }
        else
        {
            Response.Redirect("../Login.aspx");
        }
    }
}
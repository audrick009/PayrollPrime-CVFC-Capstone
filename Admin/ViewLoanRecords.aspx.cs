using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class HumanResource_EmpLoanRecords : System.Web.UI.Page
{
    SqlConnection mio = new SqlConnection(Helper.GetCon());
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userid"] != null)
        {
            mio.Open();
            SqlCommand mirai = new SqlCommand();
            mirai.Connection = mio;
            mirai.CommandText = "Select * from EmployeeLoanRecords where EmployeeID=@EmployeeID";
            mirai.Parameters.AddWithValue("EmployeeID", Session["empid"].ToString());
            SqlDataAdapter da = new SqlDataAdapter(mirai);
            DataSet ds = new DataSet();
            da.Fill(ds, "Loan Records");
            lvLRec.DataSource = ds;
            lvLRec.DataBind();
            mio.Close();
        }
        else
        {
            Response.Redirect("../Login.aspx");
        }
    }
}
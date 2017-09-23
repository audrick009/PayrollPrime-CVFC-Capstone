using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


public partial class HumanResource_EmpContRecords : System.Web.UI.Page
{
    SqlConnection mio = new SqlConnection(Helper.GetCon());
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Session["userid"] != null)
        {
            mio.Open();
            SqlCommand mirai = new SqlCommand();
            mirai.Connection = mio;
            mirai.CommandText = "select ContributionType, ContributionRate, NoOfCont, TotalContribution,DateStarted from EmployeeContributionRecords where EmployeeID=@EmployeeID";
            mirai.Parameters.AddWithValue("EmployeeID", Session["empid"].ToString());
            SqlDataAdapter da = new SqlDataAdapter(mirai);
            DataSet ds = new DataSet();
            da.Fill(ds, "Contribution Records");
            lvContRec.DataSource = ds;
            lvContRec.DataBind();
            mio.Close();
        }
        else
        {
            Response.Redirect("../Login.aspx");
        }
    }
    int GetColNum()
    {
        int ColCount = 0;
        mio.Open();
        SqlCommand mirai = new SqlCommand();
        mirai.Connection = mio;
        mirai.CommandText = "SELECT COUNT (EmployeeID) AS ColNum FROM Employee where status = 'Employed' ";
        SqlDataReader aki = mirai.ExecuteReader();
        if (aki.HasRows)
        {
            while (aki.Read())
            {
                ColCount = int.Parse(aki["ColNum"].ToString());
            }
        }
        mio.Close();
        return ColCount;
    }


}

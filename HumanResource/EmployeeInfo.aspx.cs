using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class HumanResource_EmployeeInfo : System.Web.UI.Page
{
    SqlConnection mio = new SqlConnection(Helper.GetCon());
    Helper aud = new Helper();
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Session["position"] != null)
        {
            if (Session["position"].ToString() == "Human Resource")
            {
                mio.Open();
                SqlCommand mirai = new SqlCommand();
                mirai.Connection = mio;

                mirai.CommandText = "Select EmployeeID, FirstName, MiddleName, LastName, DateEmployed, Position FROM Employee WHERE Status = 'Employed' ";
                SqlDataAdapter da = new SqlDataAdapter(mirai);
                DataSet ds = new DataSet();
                da.Fill(ds, "Employee");
                lvEmployees.DataSource = ds;
                lvEmployees.DataBind();
                mio.Close();
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

}
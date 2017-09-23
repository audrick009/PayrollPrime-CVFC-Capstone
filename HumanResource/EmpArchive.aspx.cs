using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class HumanResource_EmpArchive : System.Web.UI.Page
{
    SqlConnection mio = new SqlConnection(Helper.GetCon());

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["position"].ToString() == "Human Resource")
        {
            if (Request.QueryString["ID"] != null)
            {
                int employeeID = 0;
                bool validEmpID = int.TryParse(Request.QueryString["ID"].ToString(), out employeeID);

                if (validEmpID)
                {
                    if (!IsPostBack)
                    {
                        ArchiveEmployee(employeeID);
                    }
                }
                else Response.Redirect("EmployeeInfo.aspx");
            }
            else Response.Redirect("EmployeeInfo.aspx");
        }
        else Response.Redirect("../Login.aspx");
        
    }
    void ArchiveEmployee(int ID)
    {
        mio.Open();
        SqlCommand mirai = new SqlCommand();
        mirai.Connection = mio;
        mirai.CommandText = "UPDATE Employee SET Status = 'Archived' WHERE EmployeeID=@EmployeeID";
        mirai.Parameters.AddWithValue("@EmployeeID", ID);
        mirai.ExecuteNonQuery();
        mio.Close();
        Response.Redirect("EmployeeInfo.aspx");
    }
}
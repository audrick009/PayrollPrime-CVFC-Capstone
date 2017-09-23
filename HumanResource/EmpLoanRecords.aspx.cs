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
        if (Request.QueryString["ID"] != null)
        {
            int employeeID = 0;
            bool validEmpID = int.TryParse(Request.QueryString["ID"].ToString(), out employeeID);

            if (validEmpID)
            {
             
            }
            else Response.Redirect("EmployeeInfo.aspx");
        }
        else Response.Redirect("EmployeeInfo.aspx");

        if (Session["userid"] != null)
        {
            if(Session["position"].ToString() == "Human Resource")
            {

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

    protected void btnInsertLoan_Click(object sender, EventArgs e)
    {
        mio.Open();
        SqlCommand mirai = new SqlCommand();
        mirai.Connection = mio;
        mirai.CommandText = "INSERT INTO EmployeeLoanRecords VALUES (@EmployeeID, @LoanType, @LoanRate, @TotalLoan, @NoOfTimesPayed, @AmountPayed)";
        mirai.Parameters.AddWithValue("@EmployeeID", Request.QueryString["ID"].ToString());
        mirai.Parameters.AddWithValue("@LoanType", txtLType.Text);
        mirai.Parameters.AddWithValue("@LoanRate", txtLRate.Text);
        mirai.Parameters.AddWithValue("@TotalLoan", txtLTotal.Text);
        mirai.Parameters.AddWithValue("@NoOfTimesPayed", 0);
        mirai.Parameters.AddWithValue("@AmountPayed", 0);
        mirai.ExecuteNonQuery();
        mio.Close();
        Response.Redirect("EmployeeInfo.aspx");
    }
}
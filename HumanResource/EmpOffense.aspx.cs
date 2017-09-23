using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class HumanResource_EmpOffense : System.Web.UI.Page
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
    }

    protected void btnAddOffense_Click(object sender, EventArgs e)
    {
        mio.Open();
        SqlCommand mirai = new SqlCommand();
        mirai.Connection = mio;
        mirai.CommandText = "INSERT INTO OffenseRecords VALUES (@EmployeeID, @Event, @OffenseNo, @DateAdded, @Days, @DateStarted,@DateEnd)";
        mirai.Parameters.AddWithValue("@EmployeeID", Request.QueryString["ID"].ToString());
        mirai.Parameters.AddWithValue("@Event", txtEvent.Text);
        mirai.Parameters.AddWithValue("@OffenseNo", txtOffenseNo.Text);
        mirai.Parameters.AddWithValue("@DateAdded", DateTime.Now.Date.ToString("MM-dd-yyyy"));
        mirai.Parameters.AddWithValue("@Days", txtDays.Text);
        mirai.Parameters.AddWithValue("@DateStarted", DateTime.Parse(txtDateStart.Text).ToString("MM-dd-yyy"));
        mirai.Parameters.AddWithValue("@DateEnd", DateTime.Parse(txtDateEnd.Text).ToString("MM-dd-yyy"));
        mirai.ExecuteNonQuery();
        mio.Close();
        Response.Redirect("EmpDetails.aspx?ID=" + Request.QueryString["ID"].ToString());
    }
}
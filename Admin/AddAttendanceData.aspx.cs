using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Admin_AddAttendanceData : System.Web.UI.Page
{
    SqlConnection mio = new SqlConnection(Helper.GetCon());
    protected void Page_Load(object sender, EventArgs e)
    {
        GetEmployeeNames();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        DateTime date = DateTime.Today.Date;
        string status = "";
        string timein = date.ToString("MM-dd-yyyy") + " " + txtTimeIn.Text;
        string timeout = date.ToString("MM-dd-yyyy") + " " + txtTimeOut.Text;
        var TimeIn = DateTime.Parse(timein);
        var TimeOut = DateTime.Parse(timeout);
        TimeSpan ts = TimeOut - TimeIn;
        int diff = ts.Hours;
        if(diff > 4)
        {
            status = "Fullday";
        }
        else
        {
            status = "Halfday";
        }

        mio.Open();
        SqlCommand mirai = new SqlCommand();
        mirai.Connection = mio;
        mirai.CommandText = "INSERT INTO AttendanceRecords VALUES (@EmployeeID,@TimeIn,@TimeOut,@Type,@Status)";
        mirai.Parameters.AddWithValue("@EmployeeID",ddlEmployees.SelectedValue);
        mirai.Parameters.AddWithValue("@TimeIn", TimeIn);
        mirai.Parameters.AddWithValue("@TimeOut", TimeOut);
        mirai.Parameters.AddWithValue("@Type","Manual");
        mirai.Parameters.AddWithValue("@Status", status);

    }
    void GetEmployeeNames() // this method is a function for the btnAdd to insert the selected names as Employee ID in the database (for add user account)
    {

        mio.Open();
        SqlCommand mirai = new SqlCommand();
        mirai.Connection = mio;
        mirai.CommandText = "SELECT EmployeeID, FirstName +' '+ MiddleName +' '+ LastName AS FullName FROM Employee WHERE Status = 'Employed'";
        SqlDataReader dr = mirai.ExecuteReader();
        ddlEmployees.DataSource = dr;
        ddlEmployees.DataTextField = "FullName";
        ddlEmployees.DataValueField = "EmployeeID";
        ddlEmployees.DataBind();
        mio.Close();
    }
}
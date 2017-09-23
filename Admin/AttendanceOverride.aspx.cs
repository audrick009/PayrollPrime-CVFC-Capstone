using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Employee_AttendanceOverride : System.Web.UI.Page
{
    SqlConnection mio = new SqlConnection(Helper.GetCon());
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["empid"] != null)
        {

        }else
        {
            Response.Redirect("../Login.aspx");
        }
    }

    protected void btnTimeIn_Click(object sender, EventArgs e)
    {
        checkOverride();
    }

    protected void btnTimeOut_Click(object sender, EventArgs e)
    {
        mio.Open();
        SqlCommand mirai = new SqlCommand();
        mirai.Connection = mio;
        mirai.CommandText = "UPDATE AttendanceRecord SET TimeOut= @TimeOut where ARID = (Select ARID FROM (Select ARID, EmployeeID, CONVERT(date, TimeIn) as TimeInDate, TimeOut, Type, Status From AttendanceRecord) e where e.TimeInDate = @TimeIn  AND e.TimeOut IS NULL AND EmployeeID=@EmployeeID)";
        mirai.Parameters.AddWithValue("@EmployeeID", Session["empid"].ToString());
        mirai.Parameters.AddWithValue("@TimeIn", DateTime.Today.ToString("MM-dd-yyyy"));
        mirai.Parameters.AddWithValue("@TimeOut", DateTime.Now.ToString("MM-dd-yyyy HH:mm:ss"));
        mirai.ExecuteNonQuery();
        mio.Close();
    }
    void checkOverride()
    {
        var dateNtimetoday = DateTime.Today;
        var dateNtimeTom = dateNtimetoday.AddSeconds(-1).AddDays(1);

        mio.Open();
        SqlCommand mirai = new SqlCommand();
        mirai.Connection = mio;
        mirai.CommandText = "Select a.ARID, convert(date, a.TimeIn) as DateTimeIn, convert(varchar(8), convert(time, a.TimeIn)) as TimeIn,convert(date, a.TimeOut) " +
            "as DateTimeOut, convert(varchar(8), convert(time, a.TimeOut)) as TimeOut, a.Type, a.Status, e.FirstName, e.LastName, e.Position From AttendanceRecord as a" +
            " INNER JOIN Employee as e ON a.EmployeeID = e.EmployeeID where a.TimeIn > @DateNnow AND a.TimeIn < @DateNtom AND a.Status = 'Override'";
        mirai.Parameters.AddWithValue("@DateNnow", dateNtimetoday.ToString("MM-dd-yyyy HH:mm:ss"));
        mirai.Parameters.AddWithValue("@DateNtom", dateNtimeTom.ToString("MM-dd-yyyy HH:mm:ss"));
        SqlDataReader aki = mirai.ExecuteReader();
        if (aki.HasRows)
        {
            mio.Close();
            timeIn("Manual");
        }
        else
        {
            mio.Close();
            timeIn("M-Pending");
        }
        

    }
    void timeIn(string Type)
    {
        mio.Open();
        SqlCommand mirai = new SqlCommand();
        mirai.Connection = mio;
        mirai.CommandText = "INSERT INTO AttendanceRecord VALUES (@EmployeeID, @TimeIn, @TimeOut, @Type, @Status)";
        mirai.Parameters.AddWithValue("EmployeeID", Session["empid"].ToString());
        mirai.Parameters.AddWithValue("TimeIn", DateTime.Now.ToString("MM-dd-yyyy HH:mm:ss"));
        mirai.Parameters.AddWithValue("TimeOut", DBNull.Value);
        mirai.Parameters.AddWithValue("Type", Type);
        mirai.Parameters.AddWithValue("Status", "Present");
        mirai.ExecuteNonQuery();
        mio.Close();
        btnTimeOut.Visible = true;
        btnTimeIn.Visible = false;
    }
}
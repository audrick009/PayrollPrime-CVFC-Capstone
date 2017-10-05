using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


public partial class HumanResource_EmpCreate : System.Web.UI.Page
{
    Helper aud = new Helper();
    SqlConnection mio = new SqlConnection(Helper.GetCon());
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["position"] != null)
        {
            if (Session["position"].ToString() == "Human Resource")
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
    protected void btnInsertNewEmp_Click(object sender, EventArgs e)
    {
        InsertPermAdd();
        InsertProvAdd();
        PermAddID();
        ProvAddID();
        if (ProvAddID() != 0 && PermAddID() != 0)
        {
            InsertEmpDetails(PermAddID(), ProvAddID());
            String name = Session["firstname"].ToString() + " " + Session["lastname"].ToString();
            aud.AuditLog("Added new Employee", int.Parse(Session["empid"].ToString()), "Added new employee data");
            Response.Redirect("EmployeeInfo.aspx");
        }
        else
        {
            Response.Redirect("EmployeeCreate.aspx");
        }
    }
    int PermAddID()
    {
        int PermAddID = 0;
        mio.Open();
        SqlCommand mirai = new SqlCommand();
        mirai.Connection = mio;
        mirai.CommandText = "Select PermAddressID FROM EmployeePermanentAddress where Street=@Street AND Municipality=@Municipality AND City=@City AND ZipCode=@ZipCode";
        mirai.Parameters.AddWithValue("@Street", txtPermStreet.Text);
        mirai.Parameters.AddWithValue("@Municipality", txtPermMuni.Text);
        mirai.Parameters.AddWithValue("@City", txtPermCity.Text);
        mirai.Parameters.AddWithValue("@ZipCode", txtPermZip.Text);
        SqlDataReader aki = mirai.ExecuteReader();
        if (aki.HasRows)
        {
            while (aki.Read())
            {
                PermAddID = int.Parse(aki["PermAddressID"].ToString());
            }
        }
        mio.Close();
        return PermAddID;
    }
    int ProvAddID()
    {
        int PrvAddID = 0;
        mio.Open();
        SqlCommand mirai = new SqlCommand();
        mirai.Connection = mio;
        mirai.CommandText = "Select ProvAddressID FROM EmployeeProvAddress where Street=@Street AND Municipality=@Municipality AND City=@City AND ZipCode=@ZipCode";
        mirai.Parameters.AddWithValue("@Street", txtProvStreet.Text);
        mirai.Parameters.AddWithValue("@Municipality", txtProvMuni.Text);
        mirai.Parameters.AddWithValue("@City", txtProvCity.Text);
        mirai.Parameters.AddWithValue("@ZipCode", txtProvZip.Text);
        SqlDataReader aki = mirai.ExecuteReader();
        if (aki.HasRows)
        {
            while (aki.Read())
            {
                PrvAddID = int.Parse(aki["ProvAddressID"].ToString());
            }
        }
        mio.Close(); 
        return PrvAddID;
    }
    void InsertEmpDetails(int ProvID, int PermID)
    {
        mio.Open();
        SqlCommand mirai = new SqlCommand();
        mirai.Connection = mio;
        mirai.CommandText = "INSERT INTO Employee VALUES (@FirstName, @LastName, @MiddleName, @BirthDate, @Sex, @ProvAddressID," +
            "@PermAddressID, @SSSno, @TINno, @BIRno, @HDMFno, @PhoneNo,@MobileNo, @CivilStatus, @Status, @Position, @DateEmployed, " +
            "@DateCreated, @DateModified, @ModifiedBy, @DateResigned, @RVacLeave, @RSickLeave, @BaseSalary, @FingerPrint) ";
        mirai.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
        mirai.Parameters.AddWithValue("@LastName", txtLastName.Text);
        mirai.Parameters.AddWithValue("@MiddleName", txtMiddleName.Text);
        mirai.Parameters.AddWithValue("@BirthDate", txtBDate.Text);
        mirai.Parameters.AddWithValue("@Sex", ddlSex.SelectedItem.Text);
        mirai.Parameters.AddWithValue("@ProvAddressID", ProvID.ToString());
        mirai.Parameters.AddWithValue("@PermAddressID", PermID.ToString());
        mirai.Parameters.AddWithValue("@SSSno", txtSSS.Text);
        mirai.Parameters.AddWithValue("@TINno", txtTin.Text);
        mirai.Parameters.AddWithValue("@BIRno", ddlCivStat.SelectedItem.Text);
        mirai.Parameters.AddWithValue("@HDMFno", txtHDMF.Text);
        mirai.Parameters.AddWithValue("@PhoneNo", txtPhoneNo.Text);
        mirai.Parameters.AddWithValue("@MobileNo", txtMobileNo.Text);
        mirai.Parameters.AddWithValue("@CivilStatus", ddlCivStat.SelectedItem.Text);
        mirai.Parameters.AddWithValue("@Status", "Employed");
        mirai.Parameters.AddWithValue("@Position", ddlPosition.SelectedItem.Text);
        mirai.Parameters.AddWithValue("@DateEmployed", DateTime.Now);
        mirai.Parameters.AddWithValue("@DateCreated", DateTime.Now);
        mirai.Parameters.AddWithValue("@DateModified", DBNull.Value);
        mirai.Parameters.AddWithValue("@ModifiedBy", DBNull.Value);
        mirai.Parameters.AddWithValue("@DateResigned", DBNull.Value);
        mirai.Parameters.AddWithValue("@RVacLeave", 15);
        mirai.Parameters.AddWithValue("@RSickLeave",15);
        mirai.Parameters.AddWithValue("@BaseSalary", txtBaseSalary.Text);
        mirai.Parameters.AddWithValue("@FingerPrint", DBNull.Value);
        mirai.ExecuteNonQuery();
        mio.Close();
    }
    void InsertProvAdd()
    {
        mio.Open();
        SqlCommand mirai = new SqlCommand();
        mirai.Connection = mio;
        mirai.CommandText = "Insert Into EmployeeProvAddress VALUES (@Street, @Municipality, @City, @ZipCode)";
        mirai.Parameters.AddWithValue("@Street", txtProvStreet.Text);
        mirai.Parameters.AddWithValue("@Municipality", txtProvMuni.Text);
        mirai.Parameters.AddWithValue("@City", txtProvCity.Text);
        mirai.Parameters.AddWithValue("@ZipCode", txtProvZip.Text);
        mirai.ExecuteNonQuery();
        mio.Close();
    }
    void InsertPermAdd()
    {
        mio.Open();
        SqlCommand mirai = new SqlCommand();
        mirai.Connection = mio;
        mirai.CommandText = "Insert Into EmployeePermanentAddress VALUES (@Street, @Municipality, @City, @ZipCode)";
        mirai.Parameters.AddWithValue("@Street", txtPermStreet.Text);
        mirai.Parameters.AddWithValue("@Municipality", txtPermMuni.Text);
        mirai.Parameters.AddWithValue("@City", txtPermCity.Text);
        mirai.Parameters.AddWithValue("@ZipCode", txtPermZip.Text);
        mirai.ExecuteNonQuery();
        mio.Close();
    }
}
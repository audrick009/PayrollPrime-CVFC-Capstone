using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class HumanResource_EmpUpdate : System.Web.UI.Page
{
    Helper aud = new Helper();
    SqlConnection mio = new SqlConnection(Helper.GetCon());
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["ID"] != null)
        {
            int employeeID = 0;
            bool validEmpID = int.TryParse(Request.QueryString["ID"].ToString(), out employeeID);

            if (validEmpID)
            {
                if (!IsPostBack)
                {
                    GetData(employeeID);
                    GetPermAdd(employeeID);
                    GetProvAdd(employeeID);
                }
            }
            else Response.Redirect("EmployeeInfo.aspx");
        }
        else Response.Redirect("EmployeeInfo.aspx");

        if (Session["Update"] != null)
        {
            if(Session["update"].ToString() == "updated")
            {
                updatealert.Visible = true;
                Session.Remove("update");
            }
            
        }
        else
        {
            updatealert.Visible = false;
        }

        if (Session["userid"] != null)
        {
           
        }
        else
        {
            Response.Redirect("~/Login.aspx");
        }
    }

    void GetData(int ID)
    {
        mio.Open();
        SqlCommand mirai = new SqlCommand();
        mirai.Connection = mio;
        mirai.CommandText = "Select  FirstName, LastName, MiddleName, BirthDate,  Sex, SSSno, TINno, BIRno, HDMFno, PhoneNo, MobileNo, CivilStatus, Position, BaseSalary From Employee where EmployeeID=@EmployeeID";
        mirai.Parameters.AddWithValue("@EmployeeID", ID);
        SqlDataReader aki = mirai.ExecuteReader();
        if (aki.HasRows)
        {
            while (aki.Read())
            {
                txtFirstName.Text = aki["FirstName"].ToString();
                txtLastName.Text = aki["LastName"].ToString();
                txtMiddleName.Text = aki["MiddleName"].ToString();
                txtBDate.Text = aki["BirthDate"].ToString();
                txtSex.Text = aki["Sex"].ToString();
                txtSSS.Text = aki["SSSno"].ToString();
                txtTin.Text = aki["TINno"].ToString();
                txtBIR.Text = aki["BIRno"].ToString();
                txtHDMF.Text = aki["HDMFno"].ToString();
                txtPhoneNo.Text = aki["PhoneNo"].ToString();
                txtMobileNo.Text = aki["MobileNo"].ToString();
                txtCivStat.Text = aki["CivilStatus"].ToString();
                txtPosition.Text = aki["Position"].ToString();
                txtBaseSalary.Text = aki["BaseSalary"].ToString();
            }
            mio.Close();
        }
        else
        {
            mio.Close();
            Response.Redirect("EmployeeInfo.aspx");
        }
    }
    void GetPermAdd(int ID)
    {
        mio.Open();
        SqlCommand mirai = new SqlCommand();
        mirai.Connection = mio;
        mirai.CommandText = "Select EmployeePermanentAddress.Street, EmployeePermanentAddress.Municipality, EmployeePermanentAddress.City, EmployeePermanentAddress.ZipCode From EmployeePermanentAddress " +
            "INNER JOIN Employee ON EmployeePermanentAddress.PermAddressID = Employee.PermAddressID where EmployeeID=@EmployeeID";
        mirai.Parameters.AddWithValue("@EmployeeID", ID);
        SqlDataReader aki = mirai.ExecuteReader();
        if (aki.HasRows)
        {
            while (aki.Read())
            {
                txtPermStreet.Text = aki["Street"].ToString();
                txtPermMuni.Text = aki["Municipality"].ToString();
                txtPermCity.Text = aki["City"].ToString();
                txtPermZip.Text = aki["ZipCode"].ToString();
            }
            mio.Close();
        }
        else
        {
            mio.Close();
            Response.Redirect("EmployeeInfo.aspx");
        }

    }
    void GetProvAdd(int ID)
    {
        mio.Open();
        SqlCommand mirai = new SqlCommand();
        mirai.Connection = mio;
        mirai.CommandText = "Select EmployeeProvAddress.Street, EmployeeProvAddress.Municipality, EmployeeProvAddress.City, EmployeeProvAddress.ZipCode From EmployeeProvAddress INNER JOIN Employee ON EmployeeProvAddress.ProvAddressID = Employee.ProvAddressID where EmployeeID=@EmployeeID";
        mirai.Parameters.AddWithValue("@EmployeeID", ID);
        SqlDataReader aki = mirai.ExecuteReader();
        if (aki.HasRows)
        {
            while (aki.Read())
            {
                txtProvStreet.Text = aki["Street"].ToString();
                txtProvMuni.Text = aki["Municipality"].ToString();
                txtProvCity.Text = aki["City"].ToString();
                txtProvZip.Text = aki["ZipCode"].ToString();
            }
            mio.Close();
        }
        else
        {
            mio.Close();
            Response.Redirect("EmployeeInfo.aspx");
        }
    }
    void InsertEmpData()
    {
        
        DateTime bDate = Convert.ToDateTime(txtBDate.Text);

        mio.Open();
        SqlCommand mirai = new SqlCommand();
        mirai.Connection = mio;
        mirai.CommandText = "Update Employee SET FirstName=@FirstName, LastName=@LastName, MiddleName=@MiddleName," +
            " BirthDate=@BirthDate, Sex=@Sex, SSSno=@SSSno, TINno=@TINno, BIRno=@BIRno, HDMFno=@HDMFno, PhoneNo=@PhoneNo," +
            " MobileNo=@MobileNo, CivilStatus=@CivilStatus, Position=@Position, BaseSalary=@BaseSalary " +
            " From Employee where EmployeeID=@EmployeeID";
        mirai.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
        mirai.Parameters.AddWithValue("@LastName", txtLastName.Text);
        mirai.Parameters.AddWithValue("@MiddleName", txtMiddleName.Text);
        mirai.Parameters.AddWithValue("@BirthDate", bDate);
        mirai.Parameters.AddWithValue("@Sex", txtSex.Text);
        mirai.Parameters.AddWithValue("@SSSno", txtSSS.Text);
        mirai.Parameters.AddWithValue("@TINno", txtTin.Text);
        mirai.Parameters.AddWithValue("@BIRno", txtBIR.Text);
        mirai.Parameters.AddWithValue("@HDMFno", txtHDMF.Text);
        mirai.Parameters.AddWithValue("@PhoneNo", txtPhoneNo.Text);
        mirai.Parameters.AddWithValue("@MobileNo", txtMobileNo.Text);
        mirai.Parameters.AddWithValue("@CivilStatus", txtCivStat.Text);
        mirai.Parameters.AddWithValue("@Position", txtPosition.Text);
        mirai.Parameters.AddWithValue("@BaseSalary", txtBaseSalary.Text);
        mirai.Parameters.AddWithValue("@EmployeeID", Request.QueryString["ID"].ToString());
        mirai.ExecuteNonQuery();
        mio.Close();
    }
    void InsertPermAdd()
    {
        mio.Open();
        SqlCommand mirai = new SqlCommand();
        mirai.Connection = mio;
        mirai.CommandText = "Update EM SET EM.Street=@Street, EM.Municipality=@Municipality, EM.City=@City, EM.ZipCode=@ZipCode" +
            " FROM EmployeePermanentAddress AS EM INNER JOIN Employee As EP ON EM.PermAddressID = EP.PermAddressID where EP.EmployeeID=@EmployeeID";
        mirai.Parameters.AddWithValue("@Street", txtPermStreet.Text);
        mirai.Parameters.AddWithValue("@Municipality", txtPermMuni.Text);
        mirai.Parameters.AddWithValue("@City", txtPermCity.Text);
        mirai.Parameters.AddWithValue("@ZipCode", txtPermZip.Text);
        mirai.Parameters.AddWithValue("@EmployeeID", Request.QueryString["ID"].ToString());
        mirai.ExecuteNonQuery();
        mio.Close();
    }
    void InsertProvAdd()
    {
        mio.Open();
        SqlCommand mirai = new SqlCommand();
        mirai.Connection = mio;
        mirai.CommandText = "Update EM SET EM.Street=@Street, EM.Municipality=@Municipality, EM.City=@City, EM.ZipCode=@ZipCode" +
            " FROM EmployeeProvAddress AS EM INNER JOIN Employee As EP ON EM.ProvAddressID = EP.ProvAddressID where EP.EmployeeID=@EmployeeID";
        mirai.Parameters.AddWithValue("@Street", txtProvStreet.Text);
        mirai.Parameters.AddWithValue("@Municipality", txtProvMuni.Text);
        mirai.Parameters.AddWithValue("@City", txtProvCity.Text);
        mirai.Parameters.AddWithValue("@ZipCode", txtProvZip.Text);
        mirai.Parameters.AddWithValue("@EmployeeID", Request.QueryString["ID"].ToString());
        mirai.ExecuteNonQuery();
        mio.Close();
    }

    protected void btnUpdateInfo_Click(object sender, EventArgs e)
    {
        InsertEmpData();
        InsertPermAdd();
        InsertProvAdd();
        Session["update"] = "updated";
        String name = Session["firstname"].ToString() + " " + Session["lastname"].ToString();
        aud.AuditLog("Updated Employee Info", int.Parse(Session["empid"].ToString()), name + "Updated employee ID " + Session["empid"].ToString() + "'s details.");
        Response.Redirect("EmpUpdate.aspx");
    }
}
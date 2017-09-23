using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class HumanResource_EmpDetails : System.Web.UI.Page
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
                        GetEmpDetails(employeeID);
                        GetEmpOffense(employeeID);
                        GetEmpLoanRec(employeeID);
                    }
                }
                else Response.Redirect("EmployeeInfo.aspx");
            }
            else Response.Redirect("EmployeeInfo.aspx");
        }
        else Response.Redirect("../Login.aspx");

    }
    void GetEmpDetails(int ID)
    {
        mio.Open();
        SqlCommand mirai = new SqlCommand();
        mirai.Connection = mio;
        mirai.CommandText = "SELECT e.LastName + ',' + e.FirstName + ' ' + e.MiddleName AS Name, convert(date,e.BirthDate) AS Bdate," + 
            " e.Sex, e.SSSno, e.TINno, e.BIRno, e.HDMFno, e.PhoneNo, e.MobileNo, e.CivilStatus, e.Status, e.Position, e.DateEmployed, " + 
            " e.DateCreated, pv.Street + ',' + pv.Municipality + ',' + pv.City As ProvAddress, pm.Street + ',' + pm.Municipality + ',' + pm.City AS " + 
            "PermAddress  FROM Employee AS e INNER JOIN EmployeePermanentAddress AS pm ON e.PermAddressID = pm.PermAddressID INNER JOIN " + 
            "EmployeeProvAddress as pv ON e.ProvAddressID = pv.ProvAddressID where e.EmployeeID=@EmployeeID";
        mirai.Parameters.AddWithValue("@EmployeeID", ID);
        SqlDataReader aki = mirai.ExecuteReader();
        if (aki.HasRows)
        {
            while (aki.Read())
            {
                ltName.Text = aki["Name"].ToString();
                ltBirthDate.Text = aki["BDate"].ToString();
                ltSex.Text = aki["Sex"].ToString();
                ltSSSno.Text = aki["SSSno"].ToString();
                ltTINno.Text = aki["TINno"].ToString();
                ltBIRno.Text = aki["BIRno"].ToString();
                ltHDMFno.Text = aki["HDMFno"].ToString();
                ltPhoneNo.Text = aki["PhoneNo"].ToString();
                ltMobileNo.Text = aki["MobileNo"].ToString();
                ltCivStatus.Text = aki["CivilStatus"].ToString();
                ltStatus.Text = aki["Status"].ToString();
                ltPosition.Text = aki["Position"].ToString();
                ltDateEmp.Text = aki["DateEmployed"].ToString();
                ltDateCrt.Text = aki["DateCreated"].ToString();
                ltProvAdd.Text = aki["ProvAddress"].ToString();
                ltPermAdd.Text = aki["PermAddress"].ToString();
            }
            mio.Close();
        }
    } 
    void GetEmpOffense(int ID)
    {
        mio.Open();
        SqlCommand mirai = new SqlCommand();
        mirai.Connection = mio;
        mirai.CommandText = "Select * From OffenseRecords where EmployeeID = @EmployeeID";
        mirai.Parameters.AddWithValue("@EmployeeID", ID);
        SqlDataAdapter da = new SqlDataAdapter(mirai);
        DataSet ds = new DataSet();
        da.Fill(ds, "OffenseRecord");
        lvOffenseRecord.DataSource = ds;
        lvOffenseRecord.DataBind();
        mio.Close();
        
    }
    void GetEmpLoanRec(int ID)
    {
        mio.Open();
        SqlCommand mirai = new SqlCommand();
        mirai.Connection = mio;
        mirai.CommandText = "  Select LoanType, LoanRate, TotalLoan, NoOfTimesPayed, AmountPayed From EmployeeLoanRecords where EmployeeID =@EmployeeID";
        mirai.Parameters.AddWithValue("@EmployeeID", ID);
        SqlDataAdapter da = new SqlDataAdapter(mirai);
        DataSet ds = new DataSet();
        da.Fill(ds, "LoanRecord");
        lvLoanRec.DataSource = ds;
        lvLoanRec.DataBind();
        mio.Close();
    }
}
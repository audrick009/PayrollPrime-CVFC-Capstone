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
    Helper aud = new Helper();
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
                        aud.AuditLog(EncryptHelper.Encrypt("View Employee Details", Helper.GetSalt()), int.Parse(Session["empid"].ToString()), EncryptHelper.Encrypt("Viewed: " + EmployeeName(), Helper.GetSalt()));
                        GetEmpDetails(employeeID);
                        GetEmpOffense(employeeID);
                        GetEmpLoanRec(employeeID);
                        GetEmpDependents(employeeID);
                        EmployeeName();
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
            " e.Sex, e.SSSno, e.TINno, e.HDMFno, e.PhoneNo, e.MobileNo, e.CivilStatus, e.Status, e.Position, e.DateEmployed, " +
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
                ltBirthDate.Text = DateTime.Parse(aki["BDate"].ToString()).ToString("MMMM dd, yyyy");
                ltSex.Text = aki["Sex"].ToString();
                ltSSSno.Text = aki["SSSno"].ToString();
                ltTINno.Text = aki["TINno"].ToString();
                ltHDMFno.Text = aki["HDMFno"].ToString();
                ltPhoneNo.Text = aki["PhoneNo"].ToString();
                ltMobileNo.Text = aki["MobileNo"].ToString();
                ltCivStatus.Text = aki["CivilStatus"].ToString();
                ltStatus.Text = aki["Status"].ToString();
                ltPosition.Text = aki["Position"].ToString();
                ltDateEmp.Text = DateTime.Parse(aki["DateEmployed"].ToString()).ToString("MMMM dd, yyyy");
                ltDateCrt.Text = DateTime.Parse(aki["DateCreated"].ToString()).ToString("MMMM dd, yyyy");
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

    void GetEmpDependents(int ID)
    {
        mio.Open();
        SqlCommand mirai = new SqlCommand();
        mirai.Connection = mio;
        mirai.CommandText = "SELECT Name, Address, Relationship, DateAdded, Birthdate FROM EmployeeDependents WHERE EmployeeID = @EmployeeID";
        mirai.Parameters.AddWithValue("@EmployeeID", ID);
        SqlDataAdapter da = new SqlDataAdapter(mirai);
        DataSet ds = new DataSet();
        da.Fill(ds, "Dependents");
        lvdependents.DataSource = ds;
        lvdependents.DataBind();
        mio.Close();
    }

    public string EmployeeName()
    {
        string fullname = null;
        mio.Open();
        SqlCommand com = new SqlCommand();
        com.Connection = mio;
        com.CommandText = "SELECT u.UserID, e.FirstName + ' ' + e.MiddleName + ' ' + e.LastName AS FullName FROM Users u INNER JOIN Employee e ON u.EmployeeID = e.EmployeeID WHERE UserID=@UserID";
        com.Parameters.AddWithValue("@UserID", Request.QueryString["ID"].ToString());
        SqlDataReader dr = com.ExecuteReader();
        if (dr.HasRows)
        {
            while (dr.Read())
            {
                fullname = dr["FullName"].ToString();
            }
        }
        mio.Close();
        return fullname;

    }
}
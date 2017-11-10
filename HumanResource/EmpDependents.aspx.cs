﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class HumanResource_EmpDependents : System.Web.UI.Page
{
    Helper aud = new Helper();
    SqlConnection mio = new SqlConnection(Helper.GetCon());
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["ID"] != null)
        {
            int employeeID = 0;
            bool validEmpID = int.TryParse(Request.QueryString["ID"].ToString(), out employeeID);

            if (!validEmpID)
            {
                Response.Redirect("EmployeeInfo.aspx");
            }
        }
        else
        {
            Response.Redirect("EmployeeInfo.aspx");
        }

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

    protected void btnAddDept_Click(object sender, EventArgs e)
    {
        DateTime bDate = Convert.ToDateTime(txtBdate.Text);
        string name = txtFirstName.Text + ' ' + txtLastName.Text;
        string address = txtStreet.Text + ',' + txtMuni.Text + ',' + txtCity.Text;
        mio.Open();
        SqlCommand mirai = new SqlCommand();
        mirai.Connection = mio;
        mirai.CommandText = "Insert Into EmployeeDependents VALUES (@EmployeeID, @Name, @Address, @Relationship, @DateAdded, @Birthdate, @Status)";
        mirai.Parameters.AddWithValue("@EmployeeID", Session["empid"].ToString());
        mirai.Parameters.AddWithValue("@Name", name);
        mirai.Parameters.AddWithValue("@Address", address);
        mirai.Parameters.AddWithValue("@Relationship", txtRelation.Text);
        mirai.Parameters.AddWithValue("@DateAdded", DateTime.Today.ToString("yyyy-MM-dd"));
        mirai.Parameters.AddWithValue("@Birthdate", bDate);
        mirai.Parameters.AddWithValue("@Status", "Eligible");
        mirai.ExecuteNonQuery();
        mio.Close();
        string name2 = Session["firstname"].ToString() + " " + Session["lastname"].ToString();
        aud.AuditLog(EncryptHelper.Encrypt("Added a dependent", Helper.GetSalt()), int.Parse(Session["empid"].ToString()), EncryptHelper.Encrypt(name2 + "Added a dependent", Helper.GetSalt()));
        Response.Redirect("EmployeeInfo.aspx");
    }
}
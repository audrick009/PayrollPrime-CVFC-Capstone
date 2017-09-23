using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class HumanResource_EmployeeInfo : System.Web.UI.Page
{
    SqlConnection mio = new SqlConnection(Helper.GetCon());
    Helper aud = new Helper();
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Session["position"] != null)
        {
            if (Session["position"].ToString() == "Human Resource")
            {
                mio.Open();
                SqlCommand mirai = new SqlCommand();
                mirai.Connection = mio;

                mirai.CommandText = "Select EmployeeID, FirstName, MiddleName, LastName, DateEmployed, Position FROM Employee WHERE Status = 'Employed' ";
                SqlDataAdapter da = new SqlDataAdapter(mirai);
                DataSet ds = new DataSet();
                da.Fill(ds, "Employee");
                lvEmployees.DataSource = ds;
                lvEmployees.DataBind();
                mio.Close();
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

    protected void rbDsc_CheckedChanged(object sender, EventArgs e)
    {
        if (rbDsc.Checked == true)
        {
            mio.Open();
            SqlCommand mirai = new SqlCommand();
            mirai.Connection = mio;
            mirai.CommandText = "Select EmployeeID, FirstName, MiddleName, LastName, convert(date,DateEmployed) as DateStarted, Position FROM Employee WHERE Status = 'Employed' ORDER BY " + ddlCat.SelectedItem.Text + " DESC";
            SqlDataAdapter da = new SqlDataAdapter(mirai);
            DataSet ds = new DataSet();
            da.Fill(ds, "Employee");
            lvEmployees.DataSource = ds;
            lvEmployees.DataBind();
            mio.Close();
           
        }
        else if (rbAsc.Checked == true)
        {
            mio.Open();
            SqlCommand mirai = new SqlCommand();
            mirai.Connection = mio;
            mirai.CommandText = "Select EmployeeID, FirstName, MiddleName, LastName, convert(date,DateEmployed) as DateStarted, Position FROM Employee WHERE Status = 'Employed' ORDER BY " + ddlCat.SelectedItem.Text + " ASC";
            SqlDataAdapter da = new SqlDataAdapter(mirai);
            DataSet ds = new DataSet();
            da.Fill(ds, "Employee");
            lvEmployees.DataSource = ds;
            lvEmployees.DataBind();
            mio.Close();
        }

    }

    protected void rbAsc_CheckedChanged(object sender, EventArgs e)
    {
        if (rbAsc.Checked == true)
        {
            mio.Open();
            SqlCommand mirai = new SqlCommand();
            mirai.Connection = mio;
            mirai.CommandText = "Select EmployeeID, FirstName, MiddleName, LastName, convert(date,DateEmployed) as DateStarted, Position FROM Employee WHERE Status = 'Employed' ORDER BY " + ddlCat.SelectedItem.Text + " ASC";
            SqlDataAdapter da = new SqlDataAdapter(mirai);
            DataSet ds = new DataSet();
            da.Fill(ds, "Employee");
            lvEmployees.DataSource = ds;
            lvEmployees.DataBind();
            mio.Close();
        }
        else if(rbDsc.Checked == true)
        {
            mio.Open();
            SqlCommand mirai = new SqlCommand();
            mirai.Connection = mio;
            mirai.CommandText = "Select EmployeeID, FirstName, MiddleName, LastName, convert(date,DateEmployed) as DateStarted, Position FROM Employee WHERE Status = 'Employed' ORDER BY " + ddlCat.SelectedItem.Text + " DESC";
            SqlDataAdapter da = new SqlDataAdapter(mirai);
            DataSet ds = new DataSet();
            da.Fill(ds, "Employee");
            lvEmployees.DataSource = ds;
            lvEmployees.DataBind();
            mio.Close();
        }
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        if (ddlCat.SelectedItem.Text == "DateEmployed")
        {
            DateTime dateE;
            if (DateTime.TryParse(txtSearch.Text, out dateE))
            {
                mio.Open();
                SqlCommand mirai = new SqlCommand();
                mirai.Connection = mio;
                mirai.CommandText = "Select EmployeeID, FirstName, MiddleName, LastName, DateEmployed, Position FROM Employee WHERE Status = 'Employed' AND DateEmployed= '" + dateE + "'";
                SqlDataAdapter da = new SqlDataAdapter(mirai);
                DataSet ds = new DataSet();
                da.Fill(ds, "Employee");
                lvEmployees.DataSource = ds;
                lvEmployees.DataBind();
                mio.Close();
                String name = Session["firstname"].ToString() + " " + Session["lastname"].ToString();
                aud.AuditLog("Search Employee", int.Parse(Session["empid"].ToString()), name + "searched for employee using employee date: " + txtSearch.Text);

            }
            else
            {
                validatealert.Visible = true;
            }
        }
        else
        {
            mio.Open();
            SqlCommand mirai = new SqlCommand();
            mirai.Connection = mio;
            mirai.CommandText = "Select EmployeeID, FirstName, MiddleName, LastName, DateEmployed, Position FROM Employee WHERE Status = 'Employed' AND " + ddlCat.SelectedItem.Text + " ='" + txtSearch.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(mirai);
            DataSet ds = new DataSet();
            da.Fill(ds, "Employee");
            lvEmployees.DataSource = ds;
            lvEmployees.DataBind();
            mio.Close();

            String name = Session["firstname"].ToString() + " " + Session["lastname"].ToString();
            aud.AuditLog("Search Employee", int.Parse(Session["empid"].ToString()), name + "searched for employee using " + ddlCat.SelectedItem.Text + " : " + txtSearch.Text);
        }
        
    }
}
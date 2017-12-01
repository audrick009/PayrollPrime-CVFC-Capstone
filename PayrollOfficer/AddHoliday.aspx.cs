using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class PayrollOfficer_AddHoliday : System.Web.UI.Page
{
    Helper aud = new Helper();
    SqlConnection con = new SqlConnection(Helper.GetCon());

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userid"] != null)
        {

        }
        else
        {
            Response.Redirect("../Login.aspx");
        }
    }
    protected void addHoliday_Click(object sender, EventArgs e)
    {
        string appby = Session["FirstName"].ToString() + ' ' + Session["LastName"].ToString();
        var date = DateTime.Parse(txtDateHD.Text);
        con.Open();
        SqlCommand com = new SqlCommand();
        com.Connection = con;
        com.CommandText = "INSERT INTO Holidays VALUES (@Type, @Name, @Date, @Description)";
        com.Parameters.AddWithValue("@Type", ddlhType.SelectedItem.Text);
        com.Parameters.AddWithValue("@Name", txtNameHD.Text);
        com.Parameters.AddWithValue("@Date", date);
        com.Parameters.AddWithValue("@Description", txtHDDesc.Text);
        com.ExecuteNonQuery();
        con.Close();

        Response.Redirect("AddHoliday.aspx");

        string name = Session["firstname"].ToString() + " " + Session["lastname"].ToString();
        aud.AuditLog(EncryptHelper.Encrypt("Added Holiday", Helper.GetSalt()), int.Parse(Session["empid"].ToString()), EncryptHelper.Encrypt(name + " Apply Applied Holiday", Helper.GetSalt()));
    }
}
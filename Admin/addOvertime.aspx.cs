﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class addOvertime : System.Web.UI.Page
{
    Helper aud = new Helper();
    SqlConnection con = new SqlConnection(Helper.GetCon());
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userid"] != null)
        {
            if (Session["position"].ToString() == "Admin")
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


    protected void addOvertimeBTN_Click(object sender, EventArgs e)
    {

        if (DateTime.Parse(dateTXT.Text) <= DateTime.Today)
        {

            string appby = Session["FirstName"].ToString() + ' ' + Session["LastName"].ToString();
            string date = DateTime.Parse(dateTXT.Text).ToString("yyyy-MM-dd");



            con.Open();
            SqlCommand mirai = new SqlCommand();
            mirai.Connection = con;
            mirai.CommandText = "SELECT EmployeeID, Date FROM OvertimeRecords WHERE EmployeeID=@EmployeeID AND Date=@Date";
            mirai.Parameters.AddWithValue("@EmployeeID", Session["empid"].ToString());
            mirai.Parameters.AddWithValue("@Date", date);
            SqlDataReader aki = mirai.ExecuteReader();

            if (aki.HasRows)
            {

                error.Visible = true;

            }
            else
            {
                if (DateTime.Parse(dateTXT.Text) <= DateTime.Today)
                {
                    con.Close();
                    con.Open();
                    SqlCommand com = new SqlCommand();
                    com.Connection = con;
                    com.CommandText = "INSERT INTO OvertimeRecords VALUES (@EmployeeID, @Date, @Hours, @StartTime, @EndTime, @Reason, @Status, @ApprovedBy)";
                    com.Parameters.AddWithValue("@EmployeeID", Session["empid"].ToString());
                    com.Parameters.AddWithValue("@Date", date);
                    com.Parameters.AddWithValue("@Hours", hoursTXT.Text);
                    com.Parameters.AddWithValue("@StartTime", DateTime.Parse(dateTXT.Text).AddHours(17).ToString("yyyy-MM-dd HH:mm:ss"));
                    com.Parameters.AddWithValue("@EndTime", DateTime.Parse(dateTXT.Text).AddHours(17 + double.Parse(hoursTXT.Text)).ToString("yyyy-MM-dd HH:mm:ss"));
                    com.Parameters.AddWithValue("@Reason", reasonTXT.Text);
                    com.Parameters.AddWithValue("@Status", "Pending");
                    com.Parameters.AddWithValue("@ApprovedBy", DBNull.Value);
                    com.ExecuteNonQuery();
                    con.Close();

                    string name = Session["firstname"].ToString() + " " + Session["lastname"].ToString();
                    aud.AuditLog(EncryptHelper.Encrypt("Applied Overtime", Helper.GetSalt()), int.Parse(Session["empid"].ToString()), EncryptHelper.Encrypt(name + " Applied for Overtime", Helper.GetSalt()));

                    Response.Redirect("getOvertimeHistory.aspx");

                }

            }
            con.Close();
        }
        else { Response.Write("<script>alert('Date of applying overtime should not be in the future.');</script>"); }
    }
}

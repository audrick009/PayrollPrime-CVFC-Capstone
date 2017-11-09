using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class PayrollOfficer_ViewTaxTable : System.Web.UI.Page
{
    SqlConnection mio = new SqlConnection(Helper.GetCon());
    protected void Page_Load(object sender, EventArgs e)
    {
        getTaxTable();
    }
    void getTaxTable()
    {
        if (!IsPostBack)
        {
            getZeroEx();
            getSME();
            getSME1();
            getSME2();
            getSME3();
            getSME4();
        }
        
    }
    void getZeroEx()
    {
        mio.Open();
        SqlCommand com = new SqlCommand();
        com.Connection = mio;
        com.CommandText = "Select * from WithHoldingTaxTable where Status = 'Z'";
        SqlDataReader dr = com.ExecuteReader();
        int count = 0;
        if (dr.HasRows)
        {
            while (dr.Read())
            {
                count++;
                if (count == 1)
                {
                    Z1Desc.Text = dr["Description"].ToString();
                    Z1Cat.Text = dr["Category"].ToString();
                    Z1Low.Text = dr["Low"].ToString();
                    Z1High.Text = dr["High"].ToString();
                    Z1PercOver.Text = dr["PercentageOver"].ToString();
                    Z1Base.Text = dr["BaseTax"].ToString();
                }
                else if (count == 2)
                {
                    Z2Desc.Text = dr["Description"].ToString();
                    Z2Cat.Text = dr["Category"].ToString();
                    Z2Low.Text = dr["Low"].ToString();
                    Z2High.Text = dr["High"].ToString();
                    Z2PercOver.Text = dr["PercentageOver"].ToString();
                    Z2Base.Text = dr["BaseTax"].ToString();
                }
                else if (count == 3)
                {
                    Z3Desc.Text = dr["Description"].ToString();
                    Z3Cat.Text = dr["Category"].ToString();
                    Z3Low.Text = dr["Low"].ToString();
                    Z3High.Text = dr["High"].ToString();
                    Z3PercOver.Text = dr["PercentageOver"].ToString();
                    Z3Base.Text = dr["BaseTax"].ToString();
                }
                else if (count == 4)
                {
                    Z4Desc.Text = dr["Description"].ToString();
                    Z4Cat.Text = dr["Category"].ToString();
                    Z4Low.Text = dr["Low"].ToString();
                    Z4High.Text = dr["High"].ToString();
                    Z4PercOver.Text = dr["PercentageOver"].ToString();
                    Z4Base.Text = dr["BaseTax"].ToString();
                }
                else if (count == 5)
                {
                    Z5Desc.Text = dr["Description"].ToString();
                    Z5Cat.Text = dr["Category"].ToString();
                    Z5Low.Text = dr["Low"].ToString();
                    Z5High.Text = dr["High"].ToString();
                    Z5PercOver.Text = dr["PercentageOver"].ToString();
                    Z5Base.Text = dr["BaseTax"].ToString();
                }
                else if (count == 6)
                {
                    Z6Desc.Text = dr["Description"].ToString();
                    Z6Cat.Text = dr["Category"].ToString();
                    Z6Low.Text = dr["Low"].ToString();
                    Z6High.Text = dr["High"].ToString();
                    Z6PercOver.Text = dr["PercentageOver"].ToString();
                    Z6Base.Text = dr["BaseTax"].ToString();
                }
                else if (count == 7)
                {
                    Z7Desc.Text = dr["Description"].ToString();
                    Z7Cat.Text = dr["Category"].ToString();
                    Z7Low.Text = dr["Low"].ToString();
                    Z7High.Text = dr["High"].ToString();
                    Z7PercOver.Text = dr["PercentageOver"].ToString();
                    Z7Base.Text = dr["BaseTax"].ToString();
                }
                else if (count == 8)
                {
                    Z8Desc.Text = dr["Description"].ToString();
                    Z8Cat.Text = dr["Category"].ToString();
                    Z8Low.Text = dr["Low"].ToString();
                    Z8High.Text = dr["High"].ToString();
                    Z8PercOver.Text = dr["PercentageOver"].ToString();
                    Z8Base.Text = dr["BaseTax"].ToString();
                }
            }
        }
        mio.Close();
    }
    void getSME() {
        mio.Open();
        SqlCommand com = new SqlCommand();
        com.Connection = mio;
        com.CommandText = "Select * from WithHoldingTaxTable where Status = 'S/ME'";
        SqlDataReader dr = com.ExecuteReader();
        int count = 0;
        if (dr.HasRows) {
            while (dr.Read()) {
                count++;
                if (count == 1)
                {
                    SME1Desc.Text = dr["Description"].ToString();
                    SME1Cat.Text = dr["Category"].ToString();
                    SME1Low.Text = dr["Low"].ToString();
                    SME1High.Text = dr["High"].ToString();
                    SME1PercOver.Text = dr["PercentageOver"].ToString();
                    SME1Base.Text = dr["BaseTax"].ToString();

                }
                else if (count == 2)
                {
                    SME2Desc.Text = dr["Description"].ToString();
                    SME2Cat.Text = dr["Category"].ToString();
                    SME2Low.Text = dr["Low"].ToString();
                    SME2High.Text = dr["High"].ToString();
                    SME2PercOver.Text = dr["PercentageOver"].ToString();
                    SME2Base.Text = dr["BaseTax"].ToString();
                }
                else if (count == 3)
                {
                    SME3Desc.Text = dr["Description"].ToString();
                    SME3Cat.Text = dr["Category"].ToString();
                    SME3Low.Text = dr["Low"].ToString();
                    SME3High.Text = dr["High"].ToString();
                    SME3PercOver.Text = dr["PercentageOver"].ToString();
                    SME3Base.Text = dr["BaseTax"].ToString();
                }
                else if (count == 4)
                {
                    SME4Desc.Text = dr["Description"].ToString();
                    SME4Cat.Text = dr["Category"].ToString();
                    SME4Low.Text = dr["Low"].ToString();
                    SME4High.Text = dr["High"].ToString();
                    SME4PercOver.Text = dr["PercentageOver"].ToString();
                    SME4Base.Text = dr["BaseTax"].ToString();
                }
                else if (count == 5)
                {
                    SME5Desc.Text = dr["Description"].ToString();
                    SME5Cat.Text = dr["Category"].ToString();
                    SME5Low.Text = dr["Low"].ToString();
                    SME5High.Text = dr["High"].ToString();
                    SME5PercOver.Text = dr["PercentageOver"].ToString();
                    SME5Base.Text = dr["BaseTax"].ToString();
                }
                else if (count == 6)
                {
                    SME6Desc.Text = dr["Description"].ToString();
                    SME6Cat.Text = dr["Category"].ToString();
                    SME6Low.Text = dr["Low"].ToString();
                    SME6High.Text = dr["High"].ToString();
                    SME6PercOver.Text = dr["PercentageOver"].ToString();
                    SME6Base.Text = dr["BaseTax"].ToString();
                }
                else if (count == 7)
                {
                    SME7Desc.Text = dr["Description"].ToString();
                    SME7Cat.Text = dr["Category"].ToString();
                    SME7Low.Text = dr["Low"].ToString();
                    SME7High.Text = dr["High"].ToString();
                    SME7PercOver.Text = dr["PercentageOver"].ToString();
                    SME7Base.Text = dr["BaseTax"].ToString();
                }
                else if (count == 8) {
                    SME8Desc.Text = dr["Description"].ToString();
                    SME8Cat.Text = dr["Category"].ToString();
                    SME8Low.Text = dr["Low"].ToString();
                    SME8High.Text = dr["High"].ToString();
                    SME8PercOver.Text = dr["PercentageOver"].ToString();
                    SME8Base.Text = dr["BaseTax"].ToString();
                }

            }
        }
        mio.Close();
    }
    void getSME1() {
        mio.Open();
        SqlCommand com = new SqlCommand();
        com.Connection = mio;
        com.CommandText = "Select * from WithHoldingTaxTable where Status = 'ME1/S1'";
        SqlDataReader dr = com.ExecuteReader();
        int count = 0;
        if (dr.HasRows) {
            while (dr.Read()) {
                count++;
                if (count == 1)
                {
                    SME11Desc.Text = dr["Description"].ToString();
                    SME11Cat.Text = dr["Category"].ToString();
                    SME11Low.Text = dr["Low"].ToString();
                    SME11High.Text = dr["High"].ToString();
                    SME11PercOver.Text = dr["PercentageOver"].ToString();
                    SME11Base.Text = dr["BaseTax"].ToString();
                }
                else if (count == 2)
                {
                    SME12Desc.Text = dr["Description"].ToString();
                    SME12Cat.Text = dr["Category"].ToString();
                    SME12Low.Text = dr["Low"].ToString();
                    SME12High.Text = dr["High"].ToString();
                    SME12PercOver.Text = dr["PercentageOver"].ToString();
                    SME12Base.Text = dr["BaseTax"].ToString();
                }
                else if (count == 3)
                {
                    SME13Desc.Text = dr["Description"].ToString();
                    SME13Cat.Text = dr["Category"].ToString();
                    SME13Low.Text = dr["Low"].ToString();
                    SME13High.Text = dr["High"].ToString();
                    SME13PercOver.Text = dr["PercentageOver"].ToString();
                    SME13Base.Text = dr["BaseTax"].ToString();
                }
                else if (count == 4)
                {
                    SME14Desc.Text = dr["Description"].ToString();
                    SME14Cat.Text = dr["Category"].ToString();
                    SME14Low.Text = dr["Low"].ToString();
                    SME14High.Text = dr["High"].ToString();
                    SME14PercOver.Text = dr["PercentageOver"].ToString();
                    SME14Base.Text = dr["BaseTax"].ToString();
                }
                else if (count == 5)
                {
                    SME15Desc.Text = dr["Description"].ToString();
                    SME15Cat.Text = dr["Category"].ToString();
                    SME15Low.Text = dr["Low"].ToString();
                    SME15High.Text = dr["High"].ToString();
                    SME15PercOver.Text = dr["PercentageOver"].ToString();
                    SME15Base.Text = dr["BaseTax"].ToString();
                }
                else if (count == 6)
                {
                    SME16Desc.Text = dr["Description"].ToString();
                    SME16Cat.Text = dr["Category"].ToString();
                    SME16Low.Text = dr["Low"].ToString();
                    SME16High.Text = dr["High"].ToString();
                    SME16PercOver.Text = dr["PercentageOver"].ToString();
                    SME16Base.Text = dr["BaseTax"].ToString();
                }
                else if (count == 7)
                {
                    SME17Desc.Text = dr["Description"].ToString();
                    SME17Cat.Text = dr["Category"].ToString();
                    SME17Low.Text = dr["Low"].ToString();
                    SME17High.Text = dr["High"].ToString();
                    SME17PercOver.Text = dr["PercentageOver"].ToString();
                    SME17Base.Text = dr["BaseTax"].ToString();
                }
                else if (count == 8)
                {
                    SME18Desc.Text = dr["Description"].ToString();
                    SME18Cat.Text = dr["Category"].ToString();
                    SME18Low.Text = dr["Low"].ToString();
                    SME18High.Text = dr["High"].ToString();
                    SME18PercOver.Text = dr["PercentageOver"].ToString();
                    SME18Base.Text = dr["BaseTax"].ToString();
                }
            }
        }
        mio.Close();
    }
    void getSME2() {
        mio.Open();
        SqlCommand com = new SqlCommand();
        com.Connection = mio;
        com.CommandText = "Select * from WithHoldingTaxTable where Status = 'ME2/S2'";
        SqlDataReader dr = com.ExecuteReader();
        int count = 0;
        if (dr.HasRows) {
            while (dr.Read()) {
                count++;
                if (count == 1)
                {
                    SME21Desc.Text = dr["Description"].ToString();
                    SME21Cat.Text = dr["Category"].ToString();
                    SME21Low.Text = dr["Low"].ToString();
                    SME21High.Text = dr["High"].ToString();
                    SME21PercOver.Text = dr["PercentageOver"].ToString();
                    SME21Base.Text = dr["BaseTax"].ToString();
                }
                else if (count == 2)
                {
                    SME22Desc.Text = dr["Description"].ToString();
                    SME22Cat.Text = dr["Category"].ToString();
                    SME22Low.Text = dr["Low"].ToString();
                    SME22High.Text = dr["High"].ToString();
                    SME22PercOver.Text = dr["PercentageOver"].ToString();
                    SME22Base.Text = dr["BaseTax"].ToString();
                }
                else if (count == 3)
                {
                    SME23Desc.Text = dr["Description"].ToString();
                    SME23Cat.Text = dr["Category"].ToString();
                    SME23Low.Text = dr["Low"].ToString();
                    SME23High.Text = dr["High"].ToString();
                    SME23PercOver.Text = dr["PercentageOver"].ToString();
                    SME23Base.Text = dr["BaseTax"].ToString();
                }
                else if (count == 4)
                {
                    SME24Desc.Text = dr["Description"].ToString();
                    SME24Cat.Text = dr["Category"].ToString();
                    SME24Low.Text = dr["Low"].ToString();
                    SME24High.Text = dr["High"].ToString();
                    SME24PercOver.Text = dr["PercentageOver"].ToString();
                    SME24Base.Text = dr["BaseTax"].ToString();
                }
                else if (count == 5)
                {
                    SME25Desc.Text = dr["Description"].ToString();
                    SME25Cat.Text = dr["Category"].ToString();
                    SME25Low.Text = dr["Low"].ToString();
                    SME25High.Text = dr["High"].ToString();
                    SME25PercOver.Text = dr["PercentageOver"].ToString();
                    SME25Base.Text = dr["BaseTax"].ToString();
                }
                else if (count == 6)
                {
                    SME26Desc.Text = dr["Description"].ToString();
                    SME26Cat.Text = dr["Category"].ToString();
                    SME26Low.Text = dr["Low"].ToString();
                    SME26High.Text = dr["High"].ToString();
                    SME26PercOver.Text = dr["PercentageOver"].ToString();
                    SME26Base.Text = dr["BaseTax"].ToString();
                }
                else if (count == 7)
                {
                    SME27Desc.Text = dr["Description"].ToString();
                    SME27Cat.Text = dr["Category"].ToString();
                    SME27Low.Text = dr["Low"].ToString();
                    SME27High.Text = dr["High"].ToString();
                    SME27PercOver.Text = dr["PercentageOver"].ToString();
                    SME27Base.Text = dr["BaseTax"].ToString();
                }
                else if (count == 8)
                {
                    SME28Desc.Text = dr["Description"].ToString();
                    SME28Cat.Text = dr["Category"].ToString();
                    SME28Low.Text = dr["Low"].ToString();
                    SME28High.Text = dr["High"].ToString();
                    SME28PercOver.Text = dr["PercentageOver"].ToString();
                    SME28Base.Text = dr["BaseTax"].ToString();
                }
            }
        }
        mio.Close();
    }
    void getSME3() {
        mio.Open();
        SqlCommand com = new SqlCommand();
        com.Connection = mio;
        com.CommandText = "Select * from WithHoldingTaxTable where Status = 'ME3/S3'";
        SqlDataReader dr = com.ExecuteReader();
        int count = 0;
        if (dr.HasRows) {
            while (dr.Read())
            {
                count++;
                if (count == 1)
                {
                    SME31Desc.Text = dr["Description"].ToString();
                    SME31Cat.Text = dr["Category"].ToString();
                    SME31Low.Text = dr["Low"].ToString();
                    SME31High.Text = dr["High"].ToString();
                    SME31PercOver.Text = dr["PercentageOver"].ToString();
                    SME31Base.Text = dr["BaseTax"].ToString();
                }
                else if (count == 2)
                {
                    SME32Desc.Text = dr["Description"].ToString();
                    SME32Cat.Text = dr["Category"].ToString();
                    SME32Low.Text = dr["Low"].ToString();
                    SME32High.Text = dr["High"].ToString();
                    SME32PercOver.Text = dr["PercentageOver"].ToString();
                    SME32Base.Text = dr["BaseTax"].ToString();
                }
                else if (count == 3)
                {
                    SME33Desc.Text = dr["Description"].ToString();
                    SME33Cat.Text = dr["Category"].ToString();
                    SME33Low.Text = dr["Low"].ToString();
                    SME33High.Text = dr["High"].ToString();
                    SME33PercOver.Text = dr["PercentageOver"].ToString();
                    SME33Base.Text = dr["BaseTax"].ToString();
                }
                else if (count == 4)
                {
                    SME34Desc.Text = dr["Description"].ToString();
                    SME34Cat.Text = dr["Category"].ToString();
                    SME34Low.Text = dr["Low"].ToString();
                    SME34High.Text = dr["High"].ToString();
                    SME34PercOver.Text = dr["PercentageOver"].ToString();
                    SME34Base.Text = dr["BaseTax"].ToString();
                }
                else if (count == 5)
                {
                    SME35Desc.Text = dr["Description"].ToString();
                    SME35Cat.Text = dr["Category"].ToString();
                    SME35Low.Text = dr["Low"].ToString();
                    SME35High.Text = dr["High"].ToString();
                    SME35PercOver.Text = dr["PercentageOver"].ToString();
                    SME35Base.Text = dr["BaseTax"].ToString();
                }
                else if (count == 6)
                {
                    SME36Desc.Text = dr["Description"].ToString();
                    SME36Cat.Text = dr["Category"].ToString();
                    SME36Low.Text = dr["Low"].ToString();
                    SME36High.Text = dr["High"].ToString();
                    SME36PercOver.Text = dr["PercentageOver"].ToString();
                    SME36Base.Text = dr["BaseTax"].ToString();
                }
                else if (count == 7)
                {
                    SME37Desc.Text = dr["Description"].ToString();
                    SME37Cat.Text = dr["Category"].ToString();
                    SME37Low.Text = dr["Low"].ToString();
                    SME37High.Text = dr["High"].ToString();
                    SME37PercOver.Text = dr["PercentageOver"].ToString();
                    SME37Base.Text = dr["BaseTax"].ToString();
                }
                else if (count == 8)
                {
                    SME38Desc.Text = dr["Description"].ToString();
                    SME38Cat.Text = dr["Category"].ToString();
                    SME38Low.Text = dr["Low"].ToString();
                    SME38High.Text = dr["High"].ToString();
                    SME38PercOver.Text = dr["PercentageOver"].ToString();
                    SME38Base.Text = dr["BaseTax"].ToString();
                }
            }
        }
        mio.Close();
    }
    void getSME4() {
        mio.Open();
        SqlCommand com = new SqlCommand();
        com.Connection = mio;
        com.CommandText = "Select * from WithHoldingTaxTable where Status = 'ME4/S4'";
        SqlDataReader dr = com.ExecuteReader();
        int count = 0;
        if (dr.HasRows) {
            while (dr.Read()) {
                count++;
                if (count == 1)
                {
                    SME41Desc.Text = dr["Description"].ToString();
                    SME41Cat.Text = dr["Category"].ToString();
                    SME41Low.Text = dr["Low"].ToString();
                    SME41High.Text = dr["High"].ToString();
                    SME41PercOver.Text = dr["PercentageOver"].ToString();
                    SME41Base.Text = dr["BaseTax"].ToString();
                }
                else if (count == 2)
                {
                    SME42Desc.Text = dr["Description"].ToString();
                    SME42Cat.Text = dr["Category"].ToString();
                    SME42Low.Text = dr["Low"].ToString();
                    SME42High.Text = dr["High"].ToString();
                    SME42PercOver.Text = dr["PercentageOver"].ToString();
                    SME42Base.Text = dr["BaseTax"].ToString();
                }
                else if (count == 3)
                {
                    SME43Desc.Text = dr["Description"].ToString();
                    SME43Cat.Text = dr["Category"].ToString();
                    SME43Low.Text = dr["Low"].ToString();
                    SME43High.Text = dr["High"].ToString();
                    SME43PercOver.Text = dr["PercentageOver"].ToString();
                    SME43Base.Text = dr["BaseTax"].ToString();
                }
                else if (count == 4)
                {
                    SME44Desc.Text = dr["Description"].ToString();
                    SME44Cat.Text = dr["Category"].ToString();
                    SME44Low.Text = dr["Low"].ToString();
                    SME44High.Text = dr["High"].ToString();
                    SME44PercOver.Text = dr["PercentageOver"].ToString();
                    SME44Base.Text = dr["BaseTax"].ToString();
                }
                else if (count == 5)
                {
                    SME45Desc.Text = dr["Description"].ToString();
                    SME45Cat.Text = dr["Category"].ToString();
                    SME45Low.Text = dr["Low"].ToString();
                    SME45High.Text = dr["High"].ToString();
                    SME45PercOver.Text = dr["PercentageOver"].ToString();
                    SME45Base.Text = dr["BaseTax"].ToString();
                }
                else if (count == 6)
                {
                    SME46Desc.Text = dr["Description"].ToString();
                    SME46Cat.Text = dr["Category"].ToString();
                    SME46Low.Text = dr["Low"].ToString();
                    SME46High.Text = dr["High"].ToString();
                    SME46PercOver.Text = dr["PercentageOver"].ToString();
                    SME46Base.Text = dr["BaseTax"].ToString();
                }
                else if (count == 7)
                {
                    SME47Desc.Text = dr["Description"].ToString();
                    SME47Cat.Text = dr["Category"].ToString();
                    SME47Low.Text = dr["Low"].ToString();
                    SME47High.Text = dr["High"].ToString();
                    SME47PercOver.Text = dr["PercentageOver"].ToString();
                    SME47Base.Text = dr["BaseTax"].ToString();
                }
                else if (count == 8)
                {
                    SME48Desc.Text = dr["Description"].ToString();
                    SME48Cat.Text = dr["Category"].ToString();
                    SME48Low.Text = dr["Low"].ToString();
                    SME48High.Text = dr["High"].ToString();
                    SME48PercOver.Text = dr["PercentageOver"].ToString();
                    SME48Base.Text = dr["BaseTax"].ToString();
                }
            }
        }
        mio.Close();
    }
    void updateTaxTableZE() {

        mio.Open();
        SqlCommand com = new SqlCommand();
        com.Connection = mio;
        com.CommandText = "UPDATE WithHoldingTaxTable SET Low=@Low, High=@High, PercentageOver=@PercOver, BaseTax=@Base where Status = 'Z' AND Category = 1";
        com.Parameters.AddWithValue("@Low", Z1Low.Text);
        com.Parameters.AddWithValue("@High", Z1High.Text);
        com.Parameters.AddWithValue("@PercOver", Z1PercOver.Text);
        com.Parameters.AddWithValue("@Base", Z1Base.Text);
        com.ExecuteNonQuery();

        com.Parameters.Clear();
        com.CommandText = "UPDATE WithHoldingTaxTable SET Low=@Low, High=@High, PercentageOver=@PercOver, BaseTax=@Base where Status = 'Z' AND Category = 2";
        com.Parameters.AddWithValue("@Low", Z2Low.Text);
        com.Parameters.AddWithValue("@High", Z2High.Text);
        com.Parameters.AddWithValue("@PercOver", Z2PercOver.Text);
        com.Parameters.AddWithValue("@Base", Z2Base.Text);
        com.ExecuteNonQuery();

        com.Parameters.Clear();
        com.CommandText = "UPDATE WithHoldingTaxTable SET Low=@Low, High=@High, PercentageOver=@PercOver, BaseTax=@Base where Status = 'Z' AND Category = 3";
        com.Parameters.AddWithValue("@Low", Z3Low.Text);
        com.Parameters.AddWithValue("@High", Z3High.Text);
        com.Parameters.AddWithValue("@PercOver", Z3PercOver.Text);
        com.Parameters.AddWithValue("@Base", Z3Base.Text);
        com.ExecuteNonQuery();

        com.Parameters.Clear();
        com.CommandText = "UPDATE WithHoldingTaxTable SET Low=@Low, High=@High, PercentageOver=@PercOver, BaseTax=@Base where Status = 'Z' AND Category = 4";
        com.Parameters.AddWithValue("@Low", Z4Low.Text);
        com.Parameters.AddWithValue("@High", Z4High.Text);
        com.Parameters.AddWithValue("@PercOver", Z4PercOver.Text);
        com.Parameters.AddWithValue("@Base", Z4Base.Text);
        com.ExecuteNonQuery();

        com.Parameters.Clear();
        com.CommandText = "UPDATE WithHoldingTaxTable SET Low=@Low, High=@High, PercentageOver=@PercOver, BaseTax=@Base where Status = 'Z' AND Category = 5";
        com.Parameters.AddWithValue("@Low", Z5Low.Text);
        com.Parameters.AddWithValue("@High", Z5High.Text);
        com.Parameters.AddWithValue("@PercOver", Z5PercOver.Text);
        com.Parameters.AddWithValue("@Base", Z5Base.Text);
        com.ExecuteNonQuery();

        com.Parameters.Clear();
        com.CommandText = "UPDATE WithHoldingTaxTable SET Low=@Low, High=@High, PercentageOver=@PercOver, BaseTax=@Base where Status = 'Z' AND Category = 6";
        com.Parameters.AddWithValue("@Low", Z6Low.Text);
        com.Parameters.AddWithValue("@High", Z6High.Text);
        com.Parameters.AddWithValue("@PercOver", Z6PercOver.Text);
        com.Parameters.AddWithValue("@Base", Z6Base.Text);
        com.ExecuteNonQuery();

        com.Parameters.Clear();
        com.CommandText = "UPDATE WithHoldingTaxTable SET Low=@Low, High=@High, PercentageOver=@PercOver, BaseTax=@Base where Status = 'Z' AND Category = 7";
        com.Parameters.AddWithValue("@Low", Z7Low.Text);
        com.Parameters.AddWithValue("@High", Z7High.Text);
        com.Parameters.AddWithValue("@PercOver", Z7PercOver.Text);
        com.Parameters.AddWithValue("@Base", Z7Base.Text);
        com.ExecuteNonQuery();

        com.Parameters.Clear();
        com.CommandText = "UPDATE WithHoldingTaxTable SET Low=@Low, High=@High, PercentageOver=@PercOver, BaseTax=@Base where Status = 'Z' AND Category = 8";
        com.Parameters.AddWithValue("@Low", Z8Low.Text);
        com.Parameters.AddWithValue("@High", Z8High.Text);
        com.Parameters.AddWithValue("@PercOver", Z8PercOver.Text);
        com.Parameters.AddWithValue("@Base", Z8Base.Text);
        com.ExecuteNonQuery();

        mio.Close();
    }
    void updateTaxTableSME()
    {
        mio.Open();
        SqlCommand com = new SqlCommand();
        com.Connection = mio;
        com.CommandText = "UPDATE WithHoldingTaxTable SET Low=@Low, High=@High, PercentageOver=@PercOver, BaseTax=@Base where Status = 'S/ME' AND Category = 1";
        com.Parameters.AddWithValue("@Low", SME1Low.Text);
        com.Parameters.AddWithValue("@High", SME1High.Text);
        com.Parameters.AddWithValue("@PercOver", SME1PercOver.Text);
        com.Parameters.AddWithValue("@Base", SME1Base.Text);
        com.ExecuteNonQuery();

        com.Parameters.Clear();
        com.CommandText = "UPDATE WithHoldingTaxTable SET Low=@Low, High=@High, PercentageOver=@PercOver, BaseTax=@Base where Status = 'S/ME' AND Category = 2";
        com.Parameters.AddWithValue("@Low", SME2Low.Text);
        com.Parameters.AddWithValue("@High", SME2High.Text);
        com.Parameters.AddWithValue("@PercOver", SME2PercOver.Text);
        com.Parameters.AddWithValue("@Base", SME2Base.Text);
        com.ExecuteNonQuery();

        com.Parameters.Clear();
        com.CommandText = "UPDATE WithHoldingTaxTable SET Low=@Low, High=@High, PercentageOver=@PercOver, BaseTax=@Base where Status = 'S/ME' AND Category = 3";
        com.Parameters.AddWithValue("@Low", SME3Low.Text);
        com.Parameters.AddWithValue("@High", SME3High.Text);
        com.Parameters.AddWithValue("@PercOver", SME3PercOver.Text);
        com.Parameters.AddWithValue("@Base", SME3Base.Text);
        com.ExecuteNonQuery();

        com.Parameters.Clear();
        com.CommandText = "UPDATE WithHoldingTaxTable SET Low=@Low, High=@High, PercentageOver=@PercOver, BaseTax=@Base where Status = 'S/ME' AND Category = 4";
        com.Parameters.AddWithValue("@Low", SME4Low.Text);
        com.Parameters.AddWithValue("@High", SME4High.Text);
        com.Parameters.AddWithValue("@PercOver", SME4PercOver.Text);
        com.Parameters.AddWithValue("@Base", SME4Base.Text);
        com.ExecuteNonQuery();

        com.Parameters.Clear();
        com.CommandText = "UPDATE WithHoldingTaxTable SET Low=@Low, High=@High, PercentageOver=@PercOver, BaseTax=@Base where Status = 'S/ME' AND Category = 5";
        com.Parameters.AddWithValue("@Low", SME5Low.Text);
        com.Parameters.AddWithValue("@High", SME5High.Text);
        com.Parameters.AddWithValue("@PercOver", SME5PercOver.Text);
        com.Parameters.AddWithValue("@Base", SME5Base.Text);
        com.ExecuteNonQuery();

        com.Parameters.Clear();
        com.CommandText = "UPDATE WithHoldingTaxTable SET Low=@Low, High=@High, PercentageOver=@PercOver, BaseTax=@Base where Status = 'S/ME' AND Category = 6";
        com.Parameters.AddWithValue("@Low", SME6Low.Text);
        com.Parameters.AddWithValue("@High", SME6High.Text);
        com.Parameters.AddWithValue("@PercOver", SME6PercOver.Text);
        com.Parameters.AddWithValue("@Base", SME6Base.Text);
        com.ExecuteNonQuery();

        com.Parameters.Clear();
        com.CommandText = "UPDATE WithHoldingTaxTable SET Low=@Low, High=@High, PercentageOver=@PercOver, BaseTax=@Base where Status = 'S/ME' AND Category = 7";
        com.Parameters.AddWithValue("@Low", SME7Low.Text);
        com.Parameters.AddWithValue("@High", SME7High.Text);
        com.Parameters.AddWithValue("@PercOver", SME7PercOver.Text);
        com.Parameters.AddWithValue("@Base", SME7Base.Text);
        com.ExecuteNonQuery();

        com.Parameters.Clear();
        com.CommandText = "UPDATE WithHoldingTaxTable SET Low=@Low, High=@High, PercentageOver=@PercOver, BaseTax=@Base where Status = 'S/ME' AND Category = 8";
        com.Parameters.AddWithValue("@Low", SME8Low.Text);
        com.Parameters.AddWithValue("@High", SME8High.Text);
        com.Parameters.AddWithValue("@PercOver", SME8PercOver.Text);
        com.Parameters.AddWithValue("@Base", SME8Base.Text);
        com.ExecuteNonQuery();

        mio.Close();
    }
    void updateTaxTableSME1()
    {
        mio.Open();
        SqlCommand com = new SqlCommand();
        com.Connection = mio;
        com.CommandText = "UPDATE WithHoldingTaxTable SET Low=@Low, High=@High, PercentageOver=@PercOver, BaseTax=@Base where Status = 'ME1/S1' AND Category = 1";
        com.Parameters.AddWithValue("@Low", SME11Low.Text);
        com.Parameters.AddWithValue("@High", SME11High.Text);
        com.Parameters.AddWithValue("@PercOver", SME11PercOver.Text);
        com.Parameters.AddWithValue("@Base", SME11Base.Text);
        com.ExecuteNonQuery();

        com.Parameters.Clear();
        com.CommandText = "UPDATE WithHoldingTaxTable SET Low=@Low, High=@High, PercentageOver=@PercOver, BaseTax=@Base where Status = 'ME1/S1' AND Category = 2";
        com.Parameters.AddWithValue("@Low", SME12Low.Text);
        com.Parameters.AddWithValue("@High", SME12High.Text);
        com.Parameters.AddWithValue("@PercOver", SME12PercOver.Text);
        com.Parameters.AddWithValue("@Base", SME12Base.Text);
        com.ExecuteNonQuery();

        com.Parameters.Clear();
        com.CommandText = "UPDATE WithHoldingTaxTable SET Low=@Low, High=@High, PercentageOver=@PercOver, BaseTax=@Base where Status = 'ME1/S1' AND Category = 3";
        com.Parameters.AddWithValue("@Low", SME13Low.Text);
        com.Parameters.AddWithValue("@High", SME13High.Text);
        com.Parameters.AddWithValue("@PercOver", SME13PercOver.Text);
        com.Parameters.AddWithValue("@Base", SME13Base.Text);
        com.ExecuteNonQuery();

        com.Parameters.Clear();
        com.CommandText = "UPDATE WithHoldingTaxTable SET Low=@Low, High=@High, PercentageOver=@PercOver, BaseTax=@Base where Status = 'ME1/S1' AND Category = 4";
        com.Parameters.AddWithValue("@Low", SME14Low.Text);
        com.Parameters.AddWithValue("@High", SME14High.Text);
        com.Parameters.AddWithValue("@PercOver", SME14PercOver.Text);
        com.Parameters.AddWithValue("@Base", SME14Base.Text);
        com.ExecuteNonQuery();

        com.Parameters.Clear();
        com.CommandText = "UPDATE WithHoldingTaxTable SET Low=@Low, High=@High, PercentageOver=@PercOver, BaseTax=@Base where Status = 'ME1/S1' AND Category = 5";
        com.Parameters.AddWithValue("@Low", SME15Low.Text);
        com.Parameters.AddWithValue("@High", SME15High.Text);
        com.Parameters.AddWithValue("@PercOver", SME15PercOver.Text);
        com.Parameters.AddWithValue("@Base", SME15Base.Text);
        com.ExecuteNonQuery();

        com.Parameters.Clear();
        com.CommandText = "UPDATE WithHoldingTaxTable SET Low=@Low, High=@High, PercentageOver=@PercOver, BaseTax=@Base where Status = 'ME1/S1' AND Category = 6";
        com.Parameters.AddWithValue("@Low", SME16Low.Text);
        com.Parameters.AddWithValue("@High", SME16High.Text);
        com.Parameters.AddWithValue("@PercOver", SME16PercOver.Text);
        com.Parameters.AddWithValue("@Base", SME16Base.Text);
        com.ExecuteNonQuery();

        com.Parameters.Clear();
        com.CommandText = "UPDATE WithHoldingTaxTable SET Low=@Low, High=@High, PercentageOver=@PercOver, BaseTax=@Base where Status = 'ME1/S1' AND Category = 7";
        com.Parameters.AddWithValue("@Low", SME17Low.Text);
        com.Parameters.AddWithValue("@High", SME17High.Text);
        com.Parameters.AddWithValue("@PercOver", SME17PercOver.Text);
        com.Parameters.AddWithValue("@Base", SME17Base.Text);
        com.ExecuteNonQuery();

        com.Parameters.Clear();
        com.CommandText = "UPDATE WithHoldingTaxTable SET Low=@Low, High=@High, PercentageOver=@PercOver, BaseTax=@Base where Status = 'ME1/S1' AND Category = 8";
        com.Parameters.AddWithValue("@Low", SME18Low.Text);
        com.Parameters.AddWithValue("@High", SME18High.Text);
        com.Parameters.AddWithValue("@PercOver", SME18PercOver.Text);
        com.Parameters.AddWithValue("@Base", SME18Base.Text);
        com.ExecuteNonQuery();

        mio.Close();
    }
    void updateTaxTableSME2()
    {
        mio.Open();
        SqlCommand com = new SqlCommand();
        com.Connection = mio;
        com.CommandText = "UPDATE WithHoldingTaxTable SET Low=@Low, High=@High, PercentageOver=@PercOver, BaseTax=@Base where Status = 'ME2/S2' AND Category = 1";
        com.Parameters.AddWithValue("@Low", SME21Low.Text);
        com.Parameters.AddWithValue("@High", SME21High.Text);
        com.Parameters.AddWithValue("@PercOver", SME21PercOver.Text);
        com.Parameters.AddWithValue("@Base", SME21Base.Text);
        com.ExecuteNonQuery();

        com.Parameters.Clear();
        com.CommandText = "UPDATE WithHoldingTaxTable SET Low=@Low, High=@High, PercentageOver=@PercOver, BaseTax=@Base where Status = 'ME2/S2' AND Category = 2";
        com.Parameters.AddWithValue("@Low", SME22Low.Text);
        com.Parameters.AddWithValue("@High", SME22High.Text);
        com.Parameters.AddWithValue("@PercOver", SME22PercOver.Text);
        com.Parameters.AddWithValue("@Base", SME22Base.Text);
        com.ExecuteNonQuery();

        com.Parameters.Clear();
        com.CommandText = "UPDATE WithHoldingTaxTable SET Low=@Low, High=@High, PercentageOver=@PercOver, BaseTax=@Base where Status = 'ME2/S2' AND Category = 3";
        com.Parameters.AddWithValue("@Low", SME23Low.Text);
        com.Parameters.AddWithValue("@High", SME23High.Text);
        com.Parameters.AddWithValue("@PercOver", SME23PercOver.Text);
        com.Parameters.AddWithValue("@Base", SME23Base.Text);
        com.ExecuteNonQuery();

        com.Parameters.Clear();
        com.CommandText = "UPDATE WithHoldingTaxTable SET Low=@Low, High=@High, PercentageOver=@PercOver, BaseTax=@Base where Status = 'ME2/S2' AND Category = 4";
        com.Parameters.AddWithValue("@Low", SME24Low.Text);
        com.Parameters.AddWithValue("@High", SME24High.Text);
        com.Parameters.AddWithValue("@PercOver", SME24PercOver.Text);
        com.Parameters.AddWithValue("@Base", SME24Base.Text);
        com.ExecuteNonQuery();

        com.Parameters.Clear();
        com.CommandText = "UPDATE WithHoldingTaxTable SET Low=@Low, High=@High, PercentageOver=@PercOver, BaseTax=@Base where Status = 'ME2/S2' AND Category = 5";
        com.Parameters.AddWithValue("@Low", SME25Low.Text);
        com.Parameters.AddWithValue("@High", SME25High.Text);
        com.Parameters.AddWithValue("@PercOver", SME25PercOver.Text);
        com.Parameters.AddWithValue("@Base", SME25Base.Text);
        com.ExecuteNonQuery();

        com.Parameters.Clear();
        com.CommandText = "UPDATE WithHoldingTaxTable SET Low=@Low, High=@High, PercentageOver=@PercOver, BaseTax=@Base where Status = 'ME2/S2' AND Category = 6";
        com.Parameters.AddWithValue("@Low", SME26Low.Text);
        com.Parameters.AddWithValue("@High", SME26High.Text);
        com.Parameters.AddWithValue("@PercOver", SME26PercOver.Text);
        com.Parameters.AddWithValue("@Base", SME26Base.Text);
        com.ExecuteNonQuery();

        com.Parameters.Clear();
        com.CommandText = "UPDATE WithHoldingTaxTable SET Low=@Low, High=@High, PercentageOver=@PercOver, BaseTax=@Base where Status = 'ME2/S2' AND Category = 7";
        com.Parameters.AddWithValue("@Low", SME27Low.Text);
        com.Parameters.AddWithValue("@High", SME27High.Text);
        com.Parameters.AddWithValue("@PercOver", SME27PercOver.Text);
        com.Parameters.AddWithValue("@Base", SME27Base.Text);
        com.ExecuteNonQuery();

        com.Parameters.Clear();
        com.CommandText = "UPDATE WithHoldingTaxTable SET Low=@Low, High=@High, PercentageOver=@PercOver, BaseTax=@Base where Status = 'ME2/S2' AND Category = 8";
        com.Parameters.AddWithValue("@Low", SME28Low.Text);
        com.Parameters.AddWithValue("@High", SME28High.Text);
        com.Parameters.AddWithValue("@PercOver", SME28PercOver.Text);
        com.Parameters.AddWithValue("@Base", SME28Base.Text);
        com.ExecuteNonQuery();

        mio.Close();
    }
    void updateTaxTableSME3()
    {
        mio.Open();
        SqlCommand com = new SqlCommand();
        com.Connection = mio;
        com.CommandText = "UPDATE WithHoldingTaxTable SET Low=@Low, High=@High, PercentageOver=@PercOver, BaseTax=@Base where Status = 'ME3/S3' AND Category = 1";
        com.Parameters.AddWithValue("@Low", SME31Low.Text);
        com.Parameters.AddWithValue("@High", SME31High.Text);
        com.Parameters.AddWithValue("@PercOver", SME31PercOver.Text);
        com.Parameters.AddWithValue("@Base", SME31Base.Text);
        com.ExecuteNonQuery();

        com.Parameters.Clear();
        com.CommandText = "UPDATE WithHoldingTaxTable SET Low=@Low, High=@High, PercentageOver=@PercOver, BaseTax=@Base where Status = 'ME3/S3' AND Category = 2";
        com.Parameters.AddWithValue("@Low", SME32Low.Text);
        com.Parameters.AddWithValue("@High", SME32High.Text);
        com.Parameters.AddWithValue("@PercOver", SME32PercOver.Text);
        com.Parameters.AddWithValue("@Base", SME32Base.Text);
        com.ExecuteNonQuery();

        com.Parameters.Clear();
        com.CommandText = "UPDATE WithHoldingTaxTable SET Low=@Low, High=@High, PercentageOver=@PercOver, BaseTax=@Base where Status = 'ME3/S3' AND Category = 3";
        com.Parameters.AddWithValue("@Low", SME33Low.Text);
        com.Parameters.AddWithValue("@High", SME33High.Text);
        com.Parameters.AddWithValue("@PercOver", SME33PercOver.Text);
        com.Parameters.AddWithValue("@Base", SME33Base.Text);
        com.ExecuteNonQuery();

        com.Parameters.Clear();
        com.CommandText = "UPDATE WithHoldingTaxTable SET Low=@Low, High=@High, PercentageOver=@PercOver, BaseTax=@Base where Status = 'ME3/S3' AND Category = 4";
        com.Parameters.AddWithValue("@Low", SME34Low.Text);
        com.Parameters.AddWithValue("@High", SME34High.Text);
        com.Parameters.AddWithValue("@PercOver", SME34PercOver.Text);
        com.Parameters.AddWithValue("@Base", SME34Base.Text);
        com.ExecuteNonQuery();

        com.Parameters.Clear();
        com.CommandText = "UPDATE WithHoldingTaxTable SET Low=@Low, High=@High, PercentageOver=@PercOver, BaseTax=@Base where Status = 'ME3/S3' AND Category = 5";
        com.Parameters.AddWithValue("@Low", SME35Low.Text);
        com.Parameters.AddWithValue("@High", SME35High.Text);
        com.Parameters.AddWithValue("@PercOver", SME35PercOver.Text);
        com.Parameters.AddWithValue("@Base", SME35Base.Text);
        com.ExecuteNonQuery();

        com.Parameters.Clear();
        com.CommandText = "UPDATE WithHoldingTaxTable SET Low=@Low, High=@High, PercentageOver=@PercOver, BaseTax=@Base where Status = 'ME3/S3' AND Category = 6";
        com.Parameters.AddWithValue("@Low", SME36Low.Text);
        com.Parameters.AddWithValue("@High", SME36High.Text);
        com.Parameters.AddWithValue("@PercOver", SME36PercOver.Text);
        com.Parameters.AddWithValue("@Base", SME36Base.Text);
        com.ExecuteNonQuery();

        com.Parameters.Clear();
        com.CommandText = "UPDATE WithHoldingTaxTable SET Low=@Low, High=@High, PercentageOver=@PercOver, BaseTax=@Base where Status = 'ME3/S3' AND Category = 7";
        com.Parameters.AddWithValue("@Low", SME37Low.Text);
        com.Parameters.AddWithValue("@High", SME37High.Text);
        com.Parameters.AddWithValue("@PercOver", SME37PercOver.Text);
        com.Parameters.AddWithValue("@Base", SME37Base.Text);
        com.ExecuteNonQuery();

        com.Parameters.Clear();
        com.CommandText = "UPDATE WithHoldingTaxTable SET Low=@Low, High=@High, PercentageOver=@PercOver, BaseTax=@Base where Status = 'ME3/S3' AND Category = 8";
        com.Parameters.AddWithValue("@Low", SME38Low.Text);
        com.Parameters.AddWithValue("@High", SME38High.Text);
        com.Parameters.AddWithValue("@PercOver", SME38PercOver.Text);
        com.Parameters.AddWithValue("@Base", SME38Base.Text);
        com.ExecuteNonQuery();

        mio.Close();
    }
    void updateTaxTableSME4()
    {
        mio.Open();
        SqlCommand com = new SqlCommand();
        com.Connection = mio;
        com.CommandText = "UPDATE WithHoldingTaxTable SET Low=@Low, High=@High, PercentageOver=@PercOver, BaseTax=@Base where Status = 'ME4/S4' AND Category = 1";
        com.Parameters.AddWithValue("@Low", SME41Low.Text);
        com.Parameters.AddWithValue("@High", SME41High.Text);
        com.Parameters.AddWithValue("@PercOver", SME41PercOver.Text);
        com.Parameters.AddWithValue("@Base", SME41Base.Text);
        com.ExecuteNonQuery();

        com.Parameters.Clear();
        com.CommandText = "UPDATE WithHoldingTaxTable SET Low=@Low, High=@High, PercentageOver=@PercOver, BaseTax=@Base where Status = 'ME4/S4' AND Category = 2";
        com.Parameters.AddWithValue("@Low", SME42Low.Text);
        com.Parameters.AddWithValue("@High", SME42High.Text);
        com.Parameters.AddWithValue("@PercOver", SME42PercOver.Text);
        com.Parameters.AddWithValue("@Base", SME42Base.Text);
        com.ExecuteNonQuery();

        com.Parameters.Clear();
        com.CommandText = "UPDATE WithHoldingTaxTable SET Low=@Low, High=@High, PercentageOver=@PercOver, BaseTax=@Base where Status = 'ME4/S4' AND Category = 3";
        com.Parameters.AddWithValue("@Low", SME43Low.Text);
        com.Parameters.AddWithValue("@High", SME43High.Text);
        com.Parameters.AddWithValue("@PercOver", SME43PercOver.Text);
        com.Parameters.AddWithValue("@Base", SME43Base.Text);
        com.ExecuteNonQuery();

        com.Parameters.Clear();
        com.CommandText = "UPDATE WithHoldingTaxTable SET Low=@Low, High=@High, PercentageOver=@PercOver, BaseTax=@Base where Status = 'ME4/S4' AND Category = 4";
        com.Parameters.AddWithValue("@Low", SME44Low.Text);
        com.Parameters.AddWithValue("@High", SME44High.Text);
        com.Parameters.AddWithValue("@PercOver", SME44PercOver.Text);
        com.Parameters.AddWithValue("@Base", SME44Base.Text);
        com.ExecuteNonQuery();

        com.Parameters.Clear();
        com.CommandText = "UPDATE WithHoldingTaxTable SET Low=@Low, High=@High, PercentageOver=@PercOver, BaseTax=@Base where Status = 'ME4/S4' AND Category = 5";
        com.Parameters.AddWithValue("@Low", SME45Low.Text);
        com.Parameters.AddWithValue("@High", SME45High.Text);
        com.Parameters.AddWithValue("@PercOver", SME45PercOver.Text);
        com.Parameters.AddWithValue("@Base", SME45Base.Text);
        com.ExecuteNonQuery();

        com.Parameters.Clear();
        com.CommandText = "UPDATE WithHoldingTaxTable SET Low=@Low, High=@High, PercentageOver=@PercOver, BaseTax=@Base where Status = 'ME4/S4' AND Category = 6";
        com.Parameters.AddWithValue("@Low", SME46Low.Text);
        com.Parameters.AddWithValue("@High", SME46High.Text);
        com.Parameters.AddWithValue("@PercOver", SME46PercOver.Text);
        com.Parameters.AddWithValue("@Base", SME46Base.Text);
        com.ExecuteNonQuery();

        com.Parameters.Clear();
        com.CommandText = "UPDATE WithHoldingTaxTable SET Low=@Low, High=@High, PercentageOver=@PercOver, BaseTax=@Base where Status = 'ME4/S4' AND Category = 7";
        com.Parameters.AddWithValue("@Low", SME47Low.Text);
        com.Parameters.AddWithValue("@High", SME47High.Text);
        com.Parameters.AddWithValue("@PercOver", SME47PercOver.Text);
        com.Parameters.AddWithValue("@Base", SME47Base.Text);
        com.ExecuteNonQuery();

        com.Parameters.Clear();
        com.CommandText = "UPDATE WithHoldingTaxTable SET Low=@Low, High=@High, PercentageOver=@PercOver, BaseTax=@Base where Status = 'ME4/S4' AND Category = 8";
        com.Parameters.AddWithValue("@Low", SME48Low.Text);
        com.Parameters.AddWithValue("@High", SME48High.Text);
        com.Parameters.AddWithValue("@PercOver", SME48PercOver.Text);
        com.Parameters.AddWithValue("@Base", SME48Base.Text);
        com.ExecuteNonQuery();

        mio.Close();
    }

    protected void btnTaxZEup_Click(object sender, EventArgs e)
    {
        updateTaxTableZE();
    }
    protected void btnTaxSMEup_Click(object sender, EventArgs e)
    {
        updateTaxTableSME();
    }
    protected void btnTaxSME1up_Click(object sender, EventArgs e)
    {
        updateTaxTableSME1();
    }
    protected void btnTaxSME2up_Click(object sender, EventArgs e)
    {
        updateTaxTableSME2();
    }
    protected void btnTaxSME3up_Click(object sender, EventArgs e)
    {
        updateTaxTableSME3();
    }
    protected void btnTaxSME4up_Click(object sender, EventArgs e)
    {
        updateTaxTableSME4();
    }
}
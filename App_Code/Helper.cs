using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Data;
using System.Data.SqlClient;


/// <summary>
/// Summary description for Helper
/// </summary>
public class Helper
{
    public Helper()
    {

    }

    public static string GetCon()
    {
        return ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;

    }

    public void AuditLog(string Event, int EmployeeID, string Desc)
    {
        SqlConnection con = new SqlConnection(GetCon());
        con.Open();
        SqlCommand com = new SqlCommand();
        com.Connection = con;
        com.CommandText = "INSERT INTO AuditLogs VALUES (@EmployeeID, @TimeStamp, @Event, @Description)";
        com.Parameters.AddWithValue("@EmployeeID", EmployeeID);
        com.Parameters.AddWithValue("@TimeStamp", DateTime.Now);
        com.Parameters.AddWithValue("@Event", Event);
        com.Parameters.AddWithValue("@Description", Desc);
        com.ExecuteNonQuery();
        con.Close();
    }

    public static string CreateSHAHash(string Phrase)
    {
        SHA512Managed HashTool = new SHA512Managed();
        Byte[] PhraseAsByte = System.Text.Encoding.UTF8.GetBytes(string.Concat(Phrase));
        Byte[] EncryptedBytes = HashTool.ComputeHash(PhraseAsByte);
        HashTool.Clear();
        return Convert.ToBase64String(EncryptedBytes);
    }
    
}
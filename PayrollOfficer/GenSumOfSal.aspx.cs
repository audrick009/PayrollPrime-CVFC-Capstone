using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

public partial class PayrollOfficer_GenSumOfSal : System.Web.UI.Page
{
    Helper aud = new Helper();
    SqlConnection mio = new SqlConnection(Helper.GetCon());
    protected void Page_Load(object sender, EventArgs e)
    {
        getPayTerm();
    }
    void getPayTerm()
    {
        mio.Open();
        SqlCommand mirai = new SqlCommand();
        mirai.Connection = mio;
        mirai.CommandText = "  Select PayTermID, CAST(StartingDate as nvarchar(max)) + ' - ' + CAST(EndingDate as nvarchar(max)) as PeriodCovered From PayTerm Where PayTermID IN(Select PayTermID From PayrollRecords)";
        SqlDataReader dr = mirai.ExecuteReader();
        ddlPayTerm.DataSource = dr;
        ddlPayTerm.DataTextField = "PeriodCovered";
        ddlPayTerm.DataValueField = "PayTermID";
        ddlPayTerm.DataBind();
        mio.Close();
    }
    void getReport()
    {
        ReportDocument rpt = new ReportDocument();
        rpt.Load(Server.MapPath("~/Reports/SumOfSalary.rpt"));
        rpt.SetDatabaseLogon("sa", "dbpass", "DESKTOP-JQC0U4J", "CVFCPayroll");
        rpt.SetParameterValue("PaytermID", ddlPayTerm.SelectedValue);
        rpt.ExportToHttpResponse(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, Response, true, "Summary of Salary for the Period: " + ddlPayTerm.SelectedItem.Text);

    }

    protected void btnGenRep_Click(object sender, EventArgs e)
    {
        aud.AuditLog(EncryptHelper.Encrypt("Summart of Salary", Helper.GetSalt()), int.Parse(Session["empid"].ToString()), EncryptHelper.Encrypt("Generated summary of salary", Helper.GetSalt()));
        getReport();
    }
}
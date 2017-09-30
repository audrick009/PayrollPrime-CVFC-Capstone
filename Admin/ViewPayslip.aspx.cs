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


public partial class Employee_ViewPayslip : System.Web.UI.Page
{
    Helper aud = new Helper();
    SqlConnection mio = new SqlConnection(Helper.GetCon());
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["position"] != null)
        {
                if (!IsPostBack)
                {
                getPayTerm();

                mio.Open();
                SqlCommand mirai = new SqlCommand();
                mirai.Connection = mio;
                mirai.CommandText = "  Select e.BaseSalary, pt.StartingDate, pt.EndingDate, p.WithholdingTax, p.SSSContribution + p.PHICcontribution + p.HMDFContribution as TotalCont, p.SSSLoan + p.HDMFLoan + p.PersonalLoan as TotalLoan, p.LeavesWoPay, p.OvertimePay, p.NetPay, p.Allowance from PayrollRecords p INNER JOIN Employee e ON p.EmployeeID = e.EmployeeID INNER JOIN PayTerm pt on p.PayTermID = pt.PayTermID where e.EmployeeID=@EmployeeID";
                mirai.Parameters.AddWithValue("@EmployeeID", Session["empid"].ToString());
                SqlDataAdapter da = new SqlDataAdapter(mirai);
                DataSet ds = new DataSet();
                da.Fill(ds, "Payslip");
                lvPayslip.DataSource = ds;
                lvPayslip.DataBind();
                mio.Close();
            }
                
        }
        else
        {
            Response.Redirect("../Login.aspx");
        }
    }
    void getReport()
    {
        ReportDocument rpt = new ReportDocument();
        rpt.Load(Server.MapPath("~/Reports/payslipReport.rpt"));
        rpt.SetDatabaseLogon("sa", "dbpass", "DESKTOP-JQC0U4J", "CVFCPayroll");
        rpt.SetParameterValue("EmployeeID", Session["empid"].ToString());
        rpt.SetParameterValue("PaytermID", ddlPayTerm.SelectedValue);
        rpt.ExportToHttpResponse(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, Response, true, "Payslip Report");

        String name = Session["firstname"].ToString() + " " + Session["lastname"].ToString();
        aud.AuditLog("Generate Payslip", int.Parse(Session["empid"].ToString()), name + "Generated his/her own Payslip");

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

    protected void btnGenRep_Click(object sender, EventArgs e)
    {
        getReport();
    }
}
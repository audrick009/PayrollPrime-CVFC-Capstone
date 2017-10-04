<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/HumanResource.master" AutoEventWireup="true" CodeFile="ViewPayslip.aspx.cs" Inherits="Employee_ViewPayslip" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
    View Payslip
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" Runat="Server">
    <form runat="server" class="form-horizontal">
        <div class="col-lg-12">
            <table class="table table-hover">
                <thead>
                    <th>Base Salary</th>
                    <th>Starting Date</th>
                    <th>Ending Date</th>
                    <th>WithHolding Tax</th>
                    <th>Total Cont</th>
                    <th>Total Loan</th>
                    <th>LeavesWoPay</th>
                    <th>OvertimePay</th>
                    <th>NetPay</th>
                    <th>Allowance</th>
                </thead>
                <tbody>
                    <asp:ListView ID="lvPayslip" runat="server">
                        <ItemTemplate>
                            <tr>
                                <td><%# Eval("BaseSalary") %></td>
                                <td><%# Eval("StartingDate","{0: MMM/dd/yyyy }") %></td>
                                <td><%# Eval("EndingDate","{0: MMM/dd/yyyy }") %></td>
                                <td><%# Eval("WithholdingTax") %></td>
                                <td><%# Eval("TotalCont") %></td>
                                <td><%# Eval("TotalLoan") %></td>
                                <td><%# Eval("LeavesWoPay") %></td>
                                <td><%# Eval("OvertimePay") %></td>
                                <td><%# Eval("NetPay") %></td>
                                <td><%# Eval("Allowance") %></td>
                            </tr>
                        </ItemTemplate>
                        <EmptyDataTemplate>
                            <tr>
                                <td colspan="10"><h2 class="text-center">No logs Found.</h2></td>
                            </tr>
                        </EmptyDataTemplate>
                    </asp:ListView>
                </tbody>
            </table>
            <div class="col-lg-4">
                <div class="form-group">
                    <label class="control-label col-lg-4">Start Date</label>
                        <div class="col-lg-8">
                            <asp:DropDownList ID="ddlPayTerm" runat="server" class="form-control" />
                        </div>
                </div>
            </div>
            <div class="col-lg-4">
                <div class="form-group">
                    <asp:Button ID="btnGenRep" runat="server" class="btn btn-success pull-right" Text="Generate Report" OnClick="btnGenRep_Click" />
                </div>
            </div>
            
        </div>
    </form>
</asp:Content>


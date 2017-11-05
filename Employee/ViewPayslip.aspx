<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Employee.master" AutoEventWireup="true" CodeFile="ViewPayslip.aspx.cs" Inherits="Employee_ViewPayslip" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
    View Payslip
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" Runat="Server">
    <form runat="server">
        <div class="container-fluid">
            <div class="row">
                <div class="box">
                    <div class="box-header">
                        <h3 class="box-title">Payslip&nbsp<i class="fa fa-dollar"></i></h3>
                    </div>
                    <div class="box-body">
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
                                            <td><%# Eval("StartingDate","{0: MMMM dd, yyyy}") %></td>
                                            <td><%# Eval("EndingDate","{0: MMMM dd, yyyy}") %></td>
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
                                            <td colspan="10">
                                                <h2 class="text-center">No logs Found.</h2>
                                            </td>
                                        </tr>
                                    </EmptyDataTemplate>
                                </asp:ListView>
                            </tbody>
                        </table>
                    </div>
                    <div class="box-footer">
                        <button type="button" class="btn btn-info pull-right" data-toggle="modal" data-target="#pay-rep">Generate Report</button>
                    </div>
                </div>
            </div>
        </div>
        <div class="modal fade" id="pay-rep" style="display: none;">
            <div class="modal-dialog">
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                            <span aria-hidden="true">×</span></button>
                        <h4 class="modal-title">Generate Payslip</h4>
                    </div>
                    <div class="modal-body">
                        <div class="row">
                            <div class="col-lg-6 col-lg-offset-3">
                                <div class="form-group">
                                    <label>Start Date:</label>
                                    <asp:DropDownList ID="ddlPayTerm" runat="server" class="form-control" />
                                </div>
                            </div>
                        </div>

                    </div>
                    <div class="modal-footer">
                        <asp:Button ID="btnGenRep" runat="server" class="btn btn-success pull-right" Text="Generate Report" OnClick="btnGenRep_Click" />
                    </div>
                </div>
                <!-- /.modal-content -->
            </div>
            <!-- /.modal-dialog -->
        </div>
    </form>
</asp:Content>


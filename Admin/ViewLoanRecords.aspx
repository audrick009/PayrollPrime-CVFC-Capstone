<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Admin.master" AutoEventWireup="true" CodeFile="ViewLoanRecords.aspx.cs" Inherits="HumanResource_EmpLoanRecords" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
    View Loan Records
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" Runat="Server">
    <form runat="server" class="form-horizontal">
        <div class="col-lg-12">
            <div class="form-group">
                <table class="table table-hover">
                    <thead>
                        <th>Loan Type</th>
                        <th>Loan Rate</th>
                        <th>No of Times paid</th>
                        <th>Total Loan</th>
                        <th>Amount Paid</th>
                    </thead>
                    <tbody>
                        <asp:ListView ID="lvLRec" runat="server">
                            <ItemTemplate>
                                <tr>
                                    <td> <%# Eval("LoanType") %></td>
                                    <td> <%# Eval("LoanRate") %></td>
                                    <td> <%# Eval("NoOfTimesPayed") %></td>
                                    <td> <%# Eval("TotalLoan") %> </td>
                                    <td> <%# Eval("AmountPayed") %></td>
                                </tr>
                            </ItemTemplate>
                            <EmptyDataTemplate>
                                No Records found.
                            </EmptyDataTemplate>
                        </asp:ListView>
                    </tbody>
                </table>
            </div>
        </div>
    </form>
</asp:Content>


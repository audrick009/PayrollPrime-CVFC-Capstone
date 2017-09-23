<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/PayOfficer.master" AutoEventWireup="true" CodeFile="GenerateEmpPay.aspx.cs" Inherits="PayrollOfficer_GenerateEmpPay" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="Server">
    Generate Payroll
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="Server">
    <form runat="server" class="form form-horizontal">
        <div class="col-lg-12">
            <table class="table table-hover">
                <thead>
                    <th>#</th>
                    <th>Full Name</th>
                    <th>Position</th>
                    <th>Last Pay</th>
                </thead>
                <tbody>
                    <asp:ListView ID="lvEmployeeList" runat="server" OnLoad="Page_Load">
                        <ItemTemplate>
                            <tr>
                                <td><%# Eval("EmployeeID") %></td>
                                <td><%# Eval("LastName") %>, <%# Eval("FirstName") %> <%# Eval("MiddleName") %></td>
                                <td><%# Eval("Position") %></td>
                                <td>
                                    <a href='GenLastPay.aspx?ID<%# Eval("EmployeeID") %>'><i class="fa fa-money">Last Pay</i></a>
                                </td>
                            </tr>
                        </ItemTemplate>
                    </asp:ListView>
                </tbody>
            </table>
            <div class="form-group col-lg-4">
                <label class="control-label col-lg-4">Allowance:Php</label>
                <div class="col-lg-8">
                    <asp:TextBox ID="txtAllowance" runat="server" TextMode="Number" min="0.0" Text="0.0" class="form-control" />
                </div>
            </div>
            <asp:Button ID="btnGenPay" runat="server" class="btn btn-success pull-right" Text="Generate Payroll" OnClick="btnGenPay_Click" />
        </div>
    </form>
</asp:Content>


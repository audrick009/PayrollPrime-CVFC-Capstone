<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Admin.master" AutoEventWireup="true" CodeFile="ViewAuditLog.aspx.cs" Inherits="Admin_ViewAuditLog" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
    Audit Logs
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" Runat="Server">
    <form runat="server" class="form-horizontal">
        <div class="col-lg-12">
            <div class="col-lg-4">
                <div class="form-group">
                    <label class="control-label col-lg-4">Start Date</label>
                        <div class="col-lg-8">
                            <asp:TextBox ID="txtStart" runat="server" class="form-control" TextMode="Date" />
                        </div>
                </div>
            </div>
            <div class="col-lg-4">
                <div class="form-group">
                    <label class="control-label col-lg-4">End Date</label>
                        <div class="col-lg-8">
                            <asp:TextBox ID="txtEnd" runat="server" class="form-control" TextMode="Date" />
                        </div>
                </div>
            </div>
            <div class="col-lg-4">
                <div class="form-group">
                    <asp:Button ID="btnGenRep" runat="server" class="btn btn-success" Text="Generate Report" OnClick="btnGenRep_Click" />
                </div>
            </div>
            <div class="col-lg-4">
                <div class="form-group">
                <label class="control-label col-lg-4">Employees</label>
                    <div class="col-lg-8">
                        <asp:DropDownList ID="ddlEmployees" runat="server" class="form-control"  />
                    </div>
                </div>
            </div>
            <div class="col-lg-4">
                <div class="form-group">
                    <asp:Button ID="btnGenRepEmp" runat="server" CssClass="btn btn-success" Text="Generate Report" OnClick="btnGenRepEmp_Click" />
                </div>
            </div>
            <table class="table table-hover">
                <thead>
                    <th>#</th>
                    <th>Employee ID</th>
                    <th>Employee Name</th>
                    <th>Date&Time</th>
                    <th>Event</th>
                    <th>Description</th>
                </thead>
                <tbody>
                    <asp:ListView ID="lvAudit" runat="server">
                        <ItemTemplate>
                            <tr>
                                <td><%# Eval("AuditRID") %></td>
                                <td><%# Eval("EmployeeID") %></td>
                                <td><%# Eval("LastName") %>, <%# Eval("FirstName") %></td>
                                <td><%# Eval("TimeStamp") %></td>
                                <td><%# Eval("Event") %></td>
                                <td><%# Eval("Description") %></td>
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
        </div>
    </form>
</asp:Content>


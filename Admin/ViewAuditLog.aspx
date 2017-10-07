<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Admin.master" AutoEventWireup="true" CodeFile="ViewAuditLog.aspx.cs" Inherits="Admin_ViewAuditLog" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="Server">
    Audit Logs
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="Server">
    <%--<div class="row">
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
                                <td colspan="10">
                                    <h2 class="text-center">No logs Found.</h2>
                                </td>
                            </tr>
                        </EmptyDataTemplate>
                    </asp:ListView>
                </tbody>
            </table>
        </div>--%>
    <div class="row">
        <div class="box">
            <div class="box-header">
                <h3 class="box-title">Logs</h3>
            </div>
            <div class="box-body">
                <table id="table" class="table table-hover table-bordered">
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
                        </asp:ListView>
                    </tbody>
                </table>
            </div>
        </div>
    </div>
    <div class="row">
        <button type="button" class="btn btn-info pull-right" data-toggle="modal" data-target="#modal-default">
            Generate Reports
        </button>
    </div>

    <div class="modal fade" id="modal-default">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span></button>
                    <h4 class="modal-title">Generate Log Reports</h4>
                </div>
                <div class="modal-body">
                    <form runat="server" class="form-horizontal">
                        <div class="row container">
                            <div class="col-lg-6">
                                <div class="form-group">
                                    <label>Start Date:</label>
                                    <asp:TextBox ID="txtStart" runat="server" class="form-control" TextMode="Date" />
                                </div>
                                <div class="form-group">
                                    <label>End Date:</label>
                                    <asp:TextBox ID="txtEnd" runat="server" class="form-control" TextMode="Date" />
                                </div>
                                <div class="form-group">
                                    <asp:Button ID="btnGenRep" runat="server" class="btn btn-success pull-right" Text="Generate Report" OnClick="btnGenRep_Click" />
                                </div>
                            </div>
                        </div>
                        <hr />
                        <div class="row container">
                            <div class="col-lg-6">
                                <div class="form-group">
                                    <label>Employees:</label>
                                    <asp:DropDownList ID="ddlEmployees" runat="server" class="form-control" />
                                </div>
                                <div class="form-group">
                                    <asp:Button ID="btnGenRepEmp" runat="server" CssClass="btn btn-success pull-right" Text="Generate Report" OnClick="btnGenRepEmp_Click" />
                                </div>
                            </div>
                        </div>
                    </form>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-default pull-left" data-dismiss="modal">Close</button>
                </div>
            </div>
            <!-- /.modal-content -->
        </div>
        <!-- /.modal-dialog -->
    </div>
    <!-- /.modal -->
</asp:Content>


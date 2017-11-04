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
    <div class="container-fluid">
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
                            <asp:listview id="lvAudit" runat="server" onitemdatabound="lvAudit_ItemDataBound">
                                <ItemTemplate>
                                    <tr>
                                        <td><%# Eval("AuditRID") %></td>
                                        <td> <%# Eval("EmployeeID") %></td>
                                        <td><%# Eval("LastName") %>, <%# Eval("FirstName") %></td>
                                        <td><%# Eval("TimeStamp","{0: MMMM/dd/yyyy h:mm tt}") %></td>
                                        <td> <asp:Label id="Event" runat="server" Text='<%# Eval("Event") %>' /></td>
                                        <td>
                                            <asp:Label id="Description" runat="server" Text='<%# Eval("Description") %>' />
                                        </td>
                                    </tr>
                                </ItemTemplate>
                            </asp:listview>
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
                        <div class="col-lg-12">
                            <div class="row col-lg-8">
                                <div class="form-group">
                                    <label class="control-label col-lg-4">Start Date:</label>
                                    <div class="col-lg-8">
                                        <asp:textbox id="txtStart" runat="server" class="form-control" textmode="Date" required />
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label  col-lg-4">End Date:</label>
                                    <div class="col-lg-8">
                                        <asp:textbox id="txtEnd" runat="server" class="form-control col-lg-4" textmode="Date" required />
                                    </div>
                                </div>
                                <div class="form-group">
                                    <div class="col-lg-6 pull-right">
                                        <asp:button id="btnGenRep" runat="server" class="btn btn-success pull-right" text="Generate Report" onclick="btnGenRep_Click" />
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="col-lg-12">
                            <hr />
                            <div class="row col-lg-8">
                                <div class="form-group">
                                    <label class="col-lg-4 control-label">Employees:</label>
                                    <div class="col-lg-8">
                                        <asp:dropdownlist id="ddlEmployees" runat="server" class="form-control" required />
                                    </div>
                                </div>
                                <div class="form-group">
                                    <div class="col-lg-6 pull-right">
                                        <asp:button id="btnGenRepEmp" runat="server" cssclass="btn btn-success pull-right" text="Generate Report" onclick="btnGenRepEmp_Click" />
                                    </div>
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


<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Admin.master" AutoEventWireup="true" CodeFile="ViewAttendance.aspx.cs" Inherits="Admin_ViewAttendance" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="Server">
    View Attendance Record
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="Server">
    <%--<div class="row">
    
    <div class ="col-lg-12">
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
        <asp:Literal runat="server" ID="ltAlert" visible="false" >Successfully Allowed Manual Attendance for the day!</asp:Literal>
         <asp:Literal runat="server" ID="ltGG" visible="false" ></asp:Literal>--%>
            <%--<table class="table table-hover">
                <thead>
                    <th>Full Name</th>
                    <th>Position</th>
                    <th>Date Time-In</th>
                    <th>Time-In</th>
                    <th>Date Time-Out</th>
                    <th>Time-Out</th>
                    <th>Type</th>
                    <th>Status/th>
                </thead>
                <tbody>
                    <asp:ListView ID="lvAttendance" runat="server">
                        <ItemTemplate>
                            <tr>
                                <td> <%# Eval("FirstName") %>, <%# Eval("LastName") %></td>
                                <td> <%# Eval("Position") %></td>
                                <td> <%# Eval("DateTimeIn",  "{0: MMMM dd, yyyy}") %> </td>
                                <td> <%# Eval("TimeIn",  "{0:hh.mm tt}" ) %> </td>
                                <td> <%# Eval("DateTimeOut",  "{0: MMMM dd, yyyy}") %> </td>
                                <td> <%# Eval("TimeOut", "{0: HH:ii:ss }") %> </td>
                                <td> <%# Eval("Type") %> </td>
                                <td> <%# Eval("Status") %> </td>
                            </tr>
                        </ItemTemplate>
                        <EmptyDataTemplate>
                            <tr>
                                <td><h2 class="text-center"></h2>No Records Found</td>
                            </tr>
                        </EmptyDataTemplate>
                    </asp:ListView>
                </tbody>
            </table>--%>
            
       <%-- </div>
        
        </div>--%>
    <form runat="server" class="form-horizontal">
    <div class="container-fluid">
         <asp:Literal runat="server" ID="ltAlert" visible="false" >Successfully Allowed Manual Attendance for the day!</asp:Literal>
         <asp:Literal runat="server" ID="ltGG" visible="false" ></asp:Literal>
        <div class="row">
            <div class="box">
                <div class="box-header">
                    <h3 class="box-title">Attendance</h3>
                </div>
                <div class="box-body">
                    <table id="table" class="table table-hover table-bordered">
                        <thead>
                            <th>Full Name</th>
                            <th>Position</th>
                            <th>Date Time-In</th>
                            <th>Time-In</th>
                            <th>Date Time-Out</th>
                            <th>Time-Out</th>
                            <th>Type</th>
                            <th>Status</th>
                        </thead>
                        <tbody>
                            <asp:ListView ID="lvAttendance" runat="server">
                                <ItemTemplate>
                                    <tr>
                                        <td><%# Eval("FirstName") %>, <%# Eval("LastName") %></td>
                                        <td><%# Eval("Position") %></td>
                                        <td><%# Eval("DateTimeIn",  "{0: MMMM dd, yyyy}") %></td>
                                        <td><%# DateTime.Parse(Eval("TimeIn").ToString()).ToString("h:mm tt") %> </td>
                                        <td><%# Eval("DateTimeOut",  "{0: MMMM dd, yyyy}") %> </td>
                                        <td><%# DateTime.Parse(Eval("TimeOut").ToString()).ToString("h:mm tt")%> </td>
                                        <td><%# Eval("Type") %> </td>
                                        <td><%# Eval("Status") %> </td>
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
            <div class="pull-left">
                <asp:Button ID="btnAttOverride" runat="server" class="btn btn-warning pull-right" Text="Allow Attendance Override" OnClick="btnAttOverride_Click"/>
            </div>
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
                    
                        <div class="col-lg-12">
                            <div class="row col-lg-8">
                                <div class="form-group">
                                    <label class="control-label col-lg-4">Start Date:</label>
                                    <div class="col-lg-8">
                                        <asp:textbox id="txtStart" runat="server" class="form-control" textmode="Date" />
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label  col-lg-4">End Date:</label>
                                    <div class="col-lg-8">
                                        <asp:textbox id="txtEnd" runat="server" class="form-control col-lg-4" textmode="Date" />
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
                                        <asp:dropdownlist id="ddlEmployees" runat="server" class="form-control" />
                                    </div>
                                </div>
                                <div class="form-group">
                                    <div class="col-lg-6 pull-right">
                                        <asp:button id="btnGenRepEmp" runat="server" cssclass="btn btn-success pull-right" text="Generate Report" onclick="btnGenRepEmp_Click" />
                                    </div>
                                </div>
                            </div>
                        </div>
                    
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
    </form>
</asp:Content>


<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Admin.master" AutoEventWireup="true" CodeFile="ViewAttendance.aspx.cs" Inherits="Admin_ViewAttendance" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
    View Attendance Record
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" Runat="Server">
    <div class="row">
    <form runat="server" class="form-horizontal">
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
         <asp:Literal runat="server" ID="ltGG" visible="false" ></asp:Literal>
            <table class="table table-hover">
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
            </table>
            <asp:Button ID="btnAttOverride" runat="server" class="btn btn-info pull-right" Text="Allow Attendance Override" OnClick="btnAttOverride_Click"/>
        </div>
        </form>
        </div>
</asp:Content>


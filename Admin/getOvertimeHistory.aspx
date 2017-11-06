<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Admin.master" AutoEventWireup="true" CodeFile="getOvertimeHistory.aspx.cs" Inherits="Employee_getOvertimeHistory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="Server">
    <i class="fa fa-user"></i>View Overtime History
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="Server">
    <div class="container-fluid">
        <div class="row">
            <div class="box">
                <div class="box-header">
                    <h3 class="box-title">Overtime History</h3>
                </div>
                <div class="box-body">
                    <table id="table" class="table table-hover table-bordered">
                        <thead>
                            <th>Overtime ID</th>
                            <th>Employee ID</th>
                            <th>Date</th>
                            <th>Hours</th>
                            <th>Start Time</th>
                            <th>End Time</th>
                            <th>Reason</th>
                            <th>Status</th>
                        </thead>
                        <tbody>
                            <asp:ListView ID="lvOvertimeHistory" runat="server">
                                <ItemTemplate>
                                    <tr>
                                        <td><%# Eval("OTRID") %></td>
                                        <td><%# Eval("EmployeeID") %></td>
                                        <td><%# DateTime.Parse(Eval("Date").ToString()).ToString("MMMM dd, yyyy") %></td>
                                        <td><%# Eval("Hours") %></td>
                                        <td><%# Eval("StartTime","{0:h:mm tt}") %></td>
                                        <td><%# Eval("EndTime","{0:h:mm tt}") %></td>
                                        <td><%# Eval("Reason") %></td>
                                        <td><%# Eval("Status") %></td>
                                    </tr>
                                </ItemTemplate>
                            </asp:ListView>
                        </tbody>
                    </table>
                </div>
            </div>
        </div>
    </div>
</asp:Content>




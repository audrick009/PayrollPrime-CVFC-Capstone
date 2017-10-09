<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/HumanResource.master" AutoEventWireup="true" CodeFile="getOvertimeHistory.aspx.cs" Inherits="Employee_getOvertimeHistory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
    <i class="fa fa-user"></i> View Overtime History
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" Runat="Server">
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
                                <td> <%# Eval("OTRID") %></td>
                                <td> <%# Eval("EmployeeID") %></td>
                                <td> <%# Eval("Date") %></td>
                                <td> <%# Eval("Hours") %></td>
                                <td> <%# Eval("StartTime") %></td>
                                <td> <%# Eval("EndTime") %></td>
                                <td> <%# Eval("Reason") %></td>
                                <td> <%# Eval("Status") %></td>     
                            </tr>
                        </ItemTemplate>
                    </asp:ListView>
                </tbody>
            </table>
                </div>
            </div>
            </div>
</asp:Content>




<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Employee.master" AutoEventWireup="true" CodeFile="getLeaveApplicationHistory.aspx.cs" Inherits="Employee_getLeaveApplicationHistory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="Server">
    <i class="fa fa-user"></i>View Leave Application History
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="Server">
    <div class="container-fluid">
        <div class="row">
            <div class="box">
                <div class="box-header">
                    <h3 class="box-title">Leave Application History</h3>
                </div>
                <div class="box-body">
                    <table id="table" class="table table-hover table-bordered">
                        <thead>
                            <th>LeaveRID</th>
                            <th>Status</th>
                            <th>Leave Type</th>
                            <th>Days</th>
                            <th>Staring Date</th>
                            <th>Ending Date</th>
                        </thead>
                        <tbody>
                            <asp:ListView ID="lvLeaveApp" runat="server">
                                <ItemTemplate>
                                    <tr>
                                        <td><%# Eval("LeaveRID") %></td>
                                        <td><%# Eval("Status") %></td>
                                        <td><%# Eval("LeaveType") %></td>
                                        <td><%# Eval("Days") %></td>
                                        <td><%# Eval("StartingDate", "{0: MMMM dd, yyyy }") %></td>
                                        <td><%# Eval("EndingDate",  "{0: MMMM dd, yyyy}") %></td>

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




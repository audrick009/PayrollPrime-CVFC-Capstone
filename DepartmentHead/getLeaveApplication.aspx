<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/DepartmentHead.master" AutoEventWireup="true" CodeFile="getLeaveApplication.aspx.cs" Inherits="getLeaveApplication" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" Runat="Server">
            <div class="row container-fluid">
            <div class="box">
                <div class="box-header">
                    <i class="fa fa-inbox"></i> <h3 class="box-title">Leave Pending Applications</h3>
                </div>
                <div class="box-body">
                <table id="table" class="table table-hover table-bordered">
                <thead>
                    <th>LeaveRID</th>
                    <th>EmployeeID</th>
                    <th>Name</th>
                    <th>Status</th>
                    <th>Leave Type</th>
                    <th>Days</th>
                    <th>Staring Date</th>
                    <th>Ending Date</th>
                    <th></th>
                    <th></th>
                </thead>
                <tbody>
                    <asp:ListView ID="lvLeaveApp" runat="server">
                        <ItemTemplate>
                            <tr>
                                <td> <%# Eval("LeaveRID") %></td>
                                <td> <%# Eval("EmployeeID") %></td>
                                <td> <%# Eval("FirstName") %>   <%# Eval("MiddleName") %> <%# Eval("LastName") %></td>
                                <td> <%# Eval("Status") %></td>
                                <td> <%# Eval("LeaveType") %></td>
                                <td> <%# Eval("Days") %></td>
                                <td> <%# Eval("StartingDate", "{0: MMMM dd, yyyy}") %></td>
                                <td> <%# Eval("EndingDate",  "{0: MMMM dd, yyyy}") %></td> 
                                <td>
                                <a href='ApproveLeave.aspx?LeaveRID=<%# Eval("LeaveRID") %>' onclick='return confirm("Are you sure do you want to APPROVE?")';
                                    <button type="button" class="btn btn-success" title="Accept">
                                        <i class="fa fa-check"></i>
                                    </button>
                            </td>
                             <td>
                             <a href='RejectLeave.aspx?LeaveRID=<%# Eval("LeaveRID") %>' onclick='return confirm("Are you sure? do you want to REJECT?")';
                                    <button type="button" class="btn btn-danger" title="Reject">
                                        <i class="fa fa-times" />
                                    </button>
                            </td>    
                            </tr>
                        </ItemTemplate>
                    </asp:ListView>
                </tbody>
            </table>
                </div>
            </div>
            </div>
</asp:Content>


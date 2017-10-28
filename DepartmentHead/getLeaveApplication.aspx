<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/DepartmentHead.master" AutoEventWireup="true" CodeFile="getLeaveApplication.aspx.cs" Inherits="getLeaveApplication" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
</asp:Content>
<%--<asp:Content ID="Content2" ContentPlaceHolderID="content" Runat="Server">
    <form id="Form1" runat="server" class="form-horizontal">
        <div class="col-lg-9">
            <table class="table table-hover">
                <thead>
                    <th>LeaveRID</th>
                    <th>EmployeeID</th>
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
                                <td>
                                    <asp:Label ID="lbLeaveRID" runat="server"
                                        Text= '<%# Eval("LeaveRID") %>' />
                                </td>
                                <td>
                                    <asp:Label ID="lbEmployeeID" runat="server"
                                        Text= '<%# Eval("EmployeeID") %>' />
                                </td>
                                <td>
                                    <asp:Label ID="lbStatus" runat="server"
                                        Text= '<%# Eval("Status") %>' />
                                </td>
                                <td>
                                    <asp:Label ID="lbLeaveType" runat="server"
                                        Text= '<%# Eval("LeaveType") %>' />
                                </td>
                                 <td>
                                    <asp:Label ID="lbDays" runat="server"
                                        Text= '<%# Eval("Days") %>' />
                                </td>
                                <td>
                                    <asp:Label ID="lbStart" runat="server"
                                        Text= '<%# Eval("StartingDate") %>' />
                                </td>
                                <td>
                                    <asp:Label ID="lbEnd" runat="server"
                                        Text= '<%# Eval("EndingDate") %>' />
                                </td>

                                <td>
                                    <a href='updateLeaveForm.aspx?LeaveRID=<%# Eval("LeaveRID") %>' onclick='return confirm("Are you sure?")';
                                        <button type="button" class="btn btn-success" title="Approval">
                                            <i class="fa fa-pencil" />
                                        </button>
                                </td>
                               
                               
                                    <%--<asp:DataPager ID="datapager1" runat="server">
                                        <Fields>
                                            <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="true" ShowLastPageButton="true" />
                                        </Fields>
                                    </asp:DataPager>
                                </td>
                               
                            </tr>
                        </ItemTemplate>

                    </asp:ListView>
                </tbody>
            </table>
        </div>
    </form>
</asp:Content>--%>
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
                                <td> <%# Eval("Status") %></td>
                                <td> <%# Eval("LeaveType") %></td>
                                <td> <%# Eval("Days") %></td>
                                <td> <%# Eval("StartingDate") %></td>
                                <td> <%# Eval("EndingDate") %></td> 
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


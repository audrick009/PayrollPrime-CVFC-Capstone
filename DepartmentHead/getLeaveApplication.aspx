<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/DepartmentHead.master" AutoEventWireup="true" CodeFile="getLeaveApplication.aspx.cs" Inherits="getLeaveApplication" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
    <i class="fa fa-inbox"></i> View Pending Leave Application Forms
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" Runat="Server">
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
                                </td>--%>
                               
                            </tr>
                        </ItemTemplate>

                    </asp:ListView>
                </tbody>
            </table>
        </div>
    </form>
</asp:Content>


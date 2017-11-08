<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/DepartmentHead.master" AutoEventWireup="true" CodeFile="getOvertimeApplication.aspx.cs" Inherits="DepartmentHead_getOvertimeApplication" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" Runat="Server">
            <div class="row container-fluid">
            <div class="box">
                <div class="box-header">
                     <i class="fa fa-inbox"></i><h3 class="box-title">Overtime Pending Applications</h3>
                </div>
                <div class="box-body">
                <table id="table" class="table table-hover table-bordered">
                <thead>
                    <th>Overtime ID</th>
                    <th>Employee ID</th>
                    <th>Name</th>
                    <th>Date</th>
                    <th>Hours</th>
                    <th>Start Time</th>
                    <th>End Time</th>
                    <th>Reason</th>
                    <th>Status</th>
                    <th></th>
                    <th></th>
                </thead>
                <tbody>
                    <asp:ListView ID="lvOvertimeApp" runat="server">
                        <ItemTemplate>
                            <tr>
                                <td> <%# Eval("OTRID") %></td>
                                <td> <%# Eval("EmployeeID") %></td>
                                <td> <%# Eval("FirstName") %>   <%# Eval("MiddleName") %> <%# Eval("LastName") %></td>
                                <td> <%# DateTime.Parse(Eval("Date").ToString()).ToString("MMMM dd, yyyy") %></td>
                                <td> <%# Eval("Hours") %></td>
                                <td> <%# DateTime.Parse(Eval("StartTime").ToString()).ToString("hh:mm tt") %></td>
                                <td> <%# DateTime.Parse(Eval("EndTime").ToString()).ToString("hh:mm tt") %></td>
                                <td> <%# Eval("Reason") %></td>
                                <td> <%# Eval("Status") %></td> 
                                <td>
                                <a href='ApproveOT.aspx?OTRID=<%# Eval("OTRID") %>' onclick='return confirm("Are you sure?")';
                                    <button type="button" class="btn btn-success" title="Accept">
                                        <i class="fa fa-check"></i>
                                    </button>
                            </td>
                             <td>
                             <a href='RejectOT.aspx?OTRID=<%# Eval("OTRID") %>' onclick='return confirm("Are you sure?")';
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

<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/HumanResource.master" AutoEventWireup="true" CodeFile="EmployeeInfo.aspx.cs" Inherits="HumanResource_EmployeeInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
    Employee Information
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" Runat="Server">
            <div class="row">
            <div class="box">
                <div class="box-header">
                    <h3 class="box-title">Employee Information</h3>
                </div>
                <div class="box-body">
                <table id="table" class="table table-hover table-bordered">
                <thead>
                    <th>ID no.</th>
                    <th>Full Name</th>
                    <th>Date Started</th>
                    <th>Position</th>
                    <th></th>
                    <th></th>
                    <th></th>
                    <th></th>
                    <th></th>
                    <th></th>
                </thead>
                <tbody>
                    <asp:ListView ID="lvEmployees" runat="server">
                        <ItemTemplate>
                            <tr>
                                <td> <%# Eval("EmployeeID") %></td>
                                <td> <%# Eval("LastName") %>, <%# Eval("FirstName") %> <%# Eval("MiddleName") %></td>
                                <td> <%# Eval("DateEmployed", "{0: MMMM/dd/yyyy }") %></td>
                                <td> <%# Eval("Position") %></td>
                                <td>
                                    <a href='EmpDetails.aspx?ID=<%# Eval("EmployeeID") %>'><i class="fa fa-info"></i>View</a>
                                </td>
                                <td>
                                    <a href='EmpHRUpdate.aspx?ID=<%# Eval("EmployeeID") %>'><i class="fa fa-pencil"></i>Update</a>
                                </td>
                                <td>
                                    <a href='EmpArchive.aspx?ID=<%# Eval("EmployeeID") %>' onclick='return confirm("Are you sure? This Cannot be Undone.")'><i class="fa fa-archive"></i>Archive</a>
                                </td>
                                <td>
                                    <a href='EmpDependents.aspx?ID=<%# Eval("EmployeeID") %>'><i class="fa fa-plus"></i>Dependents</a>
                                </td>
                                <td>
                                    <a href='EmpLoanRecords.aspx?ID=<%# Eval("EmployeeID") %>'><i class="fa fa-plus"></i>Loan</a>
                                </td>
                                <td>
                                    <a href='EmpOffense.aspx?ID=<%# Eval("EmployeeID") %>'><i class="fa fa-exclamation"></i>Offense</a>
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


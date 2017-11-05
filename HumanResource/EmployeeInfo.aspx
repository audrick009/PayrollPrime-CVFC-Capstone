<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/HumanResource.master" AutoEventWireup="true" CodeFile="EmployeeInfo.aspx.cs" Inherits="HumanResource_EmployeeInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="Server">
    Employee Information
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="Server">
    <div class="row">
        <div class="col-lg-10 col-lg-offset-1">
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
                                        <td><%# Eval("EmployeeID") %></td>
                                        <td><%# Eval("LastName") %>, <%# Eval("FirstName") %> <%# Eval("MiddleName") %></td>
                                        <td><%# Eval("DateEmployed", "{0: MMMM dd, yyyy}") %></td>
                                        <td><%# Eval("Position") %></td>
                                        <td>
                                            <a href='EmpDetails.aspx?ID=<%# Eval("EmployeeID") %>' title="View Employee Details"><button class="btn btn-facebook"><i class="fa fa-info"></i></button></a>
                                        </td>
                                        <td>
                                            <a href='EmpHRUpdate.aspx?ID=<%# Eval("EmployeeID") %>' title="Update Employee Details"><button class="btn btn-twitter"><i class="fa fa-pencil"></i></button></a>
                                        </td>
                                        <td>
                                            <a href='EmpArchive.aspx?ID=<%# Eval("EmployeeID") %>' onclick='return confirm("Are you sure? This Cannot be Undone.")' title="Archive Employee"><button class="btn btn-reddit"><i class="fa fa-archive"></i></button></a>
                                        </td>
                                        <td>
                                            <a href='EmpDependents.aspx?ID=<%# Eval("EmployeeID") %>' title="Add Employee Dependents"><button class="btn btn-primary"><i class="fa fa-plus"></i></button></a>
                                        </td>
                                        <td>
                                            <a href='EmpLoanRecords.aspx?ID=<%# Eval("EmployeeID") %>' title="Add Employee Loan"><button class="btn btn-primary"><i class="fa fa-plus"></i></button></a>
                                        </td>
                                        <td>
                                           <a href='EmpOffense.aspx?ID=<%# Eval("EmployeeID") %>' title="Add Employee Offense"><button class="btn btn-danger"><i class="fa fa-exclamation"></i></button></a>
                                        </td>
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


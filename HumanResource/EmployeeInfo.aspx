<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/HumanResource.master" AutoEventWireup="true" CodeFile="EmployeeInfo.aspx.cs" Inherits="HumanResource_EmployeeInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
    Employee Information
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" Runat="Server">
    <form runat="server" class="form-horizontal">
        <div class ="col-lg-12">
            <div class="form-group">
                <div class="col-lg-2">
                    <asp:DropDownList ID="ddlCat" runat="server" class="form-control" >
                                <asp:ListItem Text="FirstName" ></asp:ListItem>
                                <asp:ListItem Text="LastName" ></asp:ListItem>
                                <asp:ListItem Text="Sex" ></asp:ListItem>
                                <asp:ListItem Text="Position" ></asp:ListItem>
                                <asp:ListItem Text="DateEmployed" ></asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="col-lg-2">
                    <asp:RadioButton runat="server" ID="rbAsc" GroupName="rdSearch" text="ASC" OnCheckedChanged="rbAsc_CheckedChanged" AutoPostBack="true" />
                    <asp:RadioButton runat="server" ID="rbDsc" GroupName="rdSearch" text="DSC" OnCheckedChanged="rbDsc_CheckedChanged" AutoPostBack="true" />
                </div>
                <div class="col-lg-6">
                    <asp:TextBox ID="txtSearch" runat="server" class="form-control" />
                    <div id="validatealert" runat="server" class="alert alert-danger col-lg-12" visible="false">
                        Insert a Valid Input!!
                    </div>
                </div>
                <div class="col-lg-2">
                    <asp:Button ID="btnSearch" runat="server" class="btn btn-info" Text="Search" OnClick="btnSearch_Click" />
                </div>
            </div>
            <table class="table table-hover">
                <thead>
                    <th>#</th>
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
                                <td> <%# Eval("DateEmployed", "{0: MM/dd/yyyy }") %></td>
                                <td> <%# Eval("Position") %></td>
                                <td>
                                    <a href='EmpDetails.aspx?ID=<%# Eval("EmployeeID") %>'><i class="fa fa-info">View</i></a>
                                </td>
                                <td>
                                    <a href='EmpUpdate.aspx?ID=<%# Eval("EmployeeID") %>'><i class="fa fa-pencil">Update</i></a>
                                </td>
                                <td>
                                    <a href='EmpArchive.aspx?ID=<%# Eval("EmployeeID") %>' onclick='return confirm("Are you sure? This Cannot be Undone.")'><i class="fa fa-archive">Archive</i></a>
                                </td>
                                <td>
                                    <a href='EmpDependents.aspx?ID=<%# Eval("EmployeeID") %>'><i class="fa fa-plus">Dependents</i></a>
                                </td>
                                <td>
                                    <a href='EmpLoanRecords.aspx?ID=<%# Eval("EmployeeID") %>'><i class="fa fa-plus">Loan</i></a>
                                </td>
                                <td>
                                    <a href='EmpOffense.aspx?ID=<%# Eval("EmployeeID") %>'><i class="fa fa-exclamation">Offense</i></a>
                                </td>
                            </tr>
                        </ItemTemplate>
                    </asp:ListView>
                </tbody>
            </table>
        </div>
    </form>
</asp:Content>


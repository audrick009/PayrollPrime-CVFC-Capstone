<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Admin.master" AutoEventWireup="true" CodeFile="ViewUserAccount.aspx.cs" Inherits="ViewUserAccount" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
    <i class="fa fa-users"></i> View User Accounts
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" Runat="Server">
    <form runat="server" class="form-horizontal">
        <div class="col-lg-12">
            <div class="form-group"">
                <div class="col-lg-2">
                     <asp:DropDownList ID="ddlCat" runat="server" class="form-control" >
                                <asp:ListItem Text="UserID" ></asp:ListItem>
                                <asp:ListItem Text="FirstName" ></asp:ListItem>
                                <asp:ListItem Text="MiddleName"></asp:ListItem>
                                <asp:ListItem Text="LastName" ></asp:ListItem>
                                <asp:ListItem Text="Username" ></asp:ListItem>
                                <asp:ListItem Text="Position" ></asp:ListItem>
                                <asp:ListItem Text="Status" ></asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="col-lg-6">
                    <asp:TextBox ID="txtSearch" runat="server" class="form-control" />
                    <div id="validatealert" runat="server" class="alert alert-danger col-lg-12" visible="false">
                        No value found!
                    </div>
                </div>
                <div class="col-lg-2">
                    <asp:Button ID="btnSearch" runat="server"  class="btn btn-info" Text="Search" OnClick="btnSearch_Click" />
                </div>
            </div>
           
            <table class="table table-hover">
                <thead>
                    <th>User ID#</th>
                    <th>Name</th>
                    <th>Usermame</th>
                    <th>Position</th>
                    <th>Status</th>
                    <th>Date Added</th>
                    <th>Date Modified</th>
                    <th>Modified By</th>
                </thead>
                <tbody>
                    <asp:ListView ID="lvAccounts" runat="server">
                        <ItemTemplate>
                            <tr>
                                <td><%# Eval("UserID") %></td>
                                <td><%# Eval("FullName") %></td>
                                <td><%# Eval("Username") %></td>
                                <td><%# Eval("Position") %></td>
                                <td><%# Eval("Status") %></td>
                                <td><%# Eval("DateAdded", "{0: MMMM dd, yyyy}") %></td>
                                <td><%# Eval("DateModified", "{0: MMMM dd, yyyy}") %></td>
                                <td><%# Eval("ModifiedBy") %></td>
                                <td>
                                    <a href='ViewUserAccountDetails.aspx?ID=<%# Eval("UserID") %>'><i class="fa fa-eye" title="View Details"></i></a>&nbsp;
                                    <a href='UpdateAccountDetails.aspx?ID=<%# Eval("UserID") %>'><i class="fa fa-pencil" title="Update"></i></a>&nbsp;
                                    <a href='ArchiveAccount.aspx?ID=<%# Eval("UserID") %> 'onclick='return confirm("Archive record?")'>
                                        <i class="fa fa-trash" title="Archive"></i></a>
                                </td>
                            </tr>
                        </ItemTemplate>
                        <EmptyDataTemplate>
                            <tr>
                                <td colspan="10"><h2 class="text-center">No Records Found.</h2></td>
                            </tr>
                        </EmptyDataTemplate>
                    </asp:ListView>
                </tbody>
            </table>
        </div>
    </form>
</asp:Content>


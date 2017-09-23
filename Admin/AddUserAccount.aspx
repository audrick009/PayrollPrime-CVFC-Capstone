<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Admin.master" AutoEventWireup="true" CodeFile="AddUserAccount.aspx.cs" Inherits="AddUserAccount" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
   <i class="fa fa-plus"></i> Add User Account
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" Runat="Server">
    <form runat="server" class="form-horizontal">
        <div class="col-lg-6">
            <div class="form-group">
                <label class="control-label col-lg-4">Employees</label>
                <div class="col-lg-8">
                   <asp:DropDownList ID="ddlEmployees" runat="server"
                       class="form-control"  />
                </div>
            </div>
            <div class="form-group">
                <label class="control-label col-lg-4">Username</label>
                <div class="col-lg-8">
                    <asp:TextBox ID="txtUname" runat="server"
                        class="form-control" required />
                    <div id="validatealert" runat="server" class="alert alert-danger col-lg-12" visible="false">
                            Only accepts numeric value.
                         </div>
                    <div id="validatealert2" runat="server" class="alert alert-danger col-lg-12" visible="false">
                            This username already exists!
                         </div>
                </div>
            </div>
            <div class="form-group">
                <label class="control-label col-lg-4">Password</label>
                <div class="col-lg-8">
                    <asp:TextBox ID="txtPword" runat="server"
                        class="form-control" type="password" required />
                </div>
            </div>
            <div class="form-group">
                <div class="col-lg-offset-4 col-lg-8">
                    <asp:Button ID="btnAdd" runat="server"
                        class="btn btn-success" Text="Add" OnClick="btnAdd_Click" />
                </div>
            </div>
        </div>
    </form>
</asp:Content>


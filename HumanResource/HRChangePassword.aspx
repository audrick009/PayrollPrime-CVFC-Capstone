<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/HumanResource.master" AutoEventWireup="true" CodeFile="HRChangePassword.aspx.cs" Inherits="HumanResource_HRChangePassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
    Change Password
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" Runat="Server">
    <form class="form-horizontal" runat="server">
        <div class="col-lg-6 centered">
            <div class="form-group">
                <label class="control-label col-lg-4">Current Password: </label>
                <div class="col-lg-8">
                    <asp:TextBox ID="txtCPassword" runat="server" textmode="Password" class="form-control" required />
                    <div id="validatealert" runat="server" class="alert alert-danger col-lg-12" visible="false">
                        Current password does not match!
                    </div>
                </div>
            </div>
            <div class="form-group">
                <label class="control-label col-lg-4">New Password</label>
                <div class="col-lg-8">
                    <asp:TextBox ID="txtNPassword" runat="server" textmode="Password" class="form-control" required />
                </div>
            </div>
             <div class="form-group">
                <label class="control-label col-lg-4">Re-enter new password</label>
                <div class="col-lg-8">
                    <asp:TextBox ID="txtReEnterNP" runat="server" textmode="Password" class="form-control" required />
                    <div id="validatealert2" runat="server" class="alert alert-danger col-lg-12" visible="false">
                        Re-entered password does not match!
                    </div>
                </div>
            </div>
             <div class="form-group">
                <div class="col-lg-offset-4 col-lg-8">
                    <asp:Button ID="btnChangePassword" runat="server"
                        class="btn btn-success" Text="Change Password" OnClick="btnChangePassword_Click" />
                </div>
            </div>
    </form>
</asp:Content>


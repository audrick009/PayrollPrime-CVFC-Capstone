<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/HumanResource.master" AutoEventWireup="true" CodeFile="HRChangePassword.aspx.cs" Inherits="HumanResource_HRChangePassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
    Change Password
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" Runat="Server">
    <div class="container">
        <div class="row">
            <div class="col-lg-4 col-lg-offset-4">
                <div class="box">
                    <div class="box header with-border">
                    </div>
                    <form runat="server">
                        <div class="box-body">
                            <div class="form-group">
                                <label>Current Password:</label>
                                <asp:TextBox ID="txtCPassword" runat="server" TextMode="Password" class="form-control" required />
                                <div id="validatealert" runat="server" class="alert alert-danger col-lg-12" visible="false">
                                    Current password password does not match!
                                </div>
                            </div>
                            <div class="form-group">
                                <label>New Password:</label>                           
                                    <asp:TextBox ID="txtNPassword" runat="server" TextMode="Password" class="form-control" required />                               
                            </div>
                            <div class="form-group">
                                <label>Re-enter new Password:</label>
                                <asp:TextBox ID="txtReEnterNP" runat="server" TextMode="Password" class="form-control" required />
                                <div id="validatealert2" runat="server" class="alert alert-danger col-lg-12" visible="false">
                                    Re-entered password does not match!
                                </div>
                            </div>
                        </div>
                        <div class="box-footer">
                            <asp:Button ID="btnChangePassword" runat="server" class="btn btn-success pull-right" Text="Change Password"
                                OnClick="btnChangePassword_Click" />
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </div>
</asp:Content>


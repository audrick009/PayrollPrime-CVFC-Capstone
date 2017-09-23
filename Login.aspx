<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Login.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
    Login
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" Runat="Server">
    <form runat="server" class="form-horizontal">
        <div class="col-lg-offset-3 col-lg-6">
            <div id="error" runat="server" class="alert alert-danger" visible="false">
                Invalid Email Address or Password!!!
            </div>
            <div class="form-group">
                <label class="control-label col-lg-4">Username</label>
                <div class="col-lg-8">
                    <asp:TextBox ID="txtUsername" runat="server" class="form-control" />
                </div>
            </div>

             <div class="form-group">
                <label class="control-label col-lg-4">Password</label>
                <div class="col-lg-8">
                    <asp:TextBox ID="txtPassword" runat="server" type="password" class="form-control" />
                </div>
            </div>

            <div class="form-group">
                <div class="col-lg-offset-4 col-lg-8">
                    <asp:Button ID="btnLogin" runat="server" class="btn btn-success" Text="Login" 
                        onclick="btnLogin_Click"/>
                </div>
            </div>
        </div>
    </form>
</asp:Content>


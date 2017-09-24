<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Login.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content2" ContentPlaceHolderID="content" Runat="Server">
  <div class="login-box">
  <div class="login-logo">
    <b>Payroll</b>Prime
  </div>
  <!-- /.login-logo -->
  <div class="login-box-body">
    <p class="login-box-msg">Sign in to Payroll Prime</p>

    <form runat="server">
        <div id="error" runat="server" class="alert alert-danger" visible="false">
                Invalid Email Address or Password!!!
        </div>
      <div class="form-group has-feedback">
        <asp:TextBox ID="txtUsername" runat="server" class="form-control" placeholder="Username"/>
        <span class="glyphicon glyphicon-envelope form-control-feedback"></span>
      </div>
      <div class="form-group has-feedback">
        <asp:TextBox ID="txtPassword" runat="server" type="password" class="form-control" placeholder="Password"/>
        <span class="glyphicon glyphicon-lock form-control-feedback"></span>
      </div>
      <div class="row">
        <div class="col-xs-12">
            <asp:Button ID="btnLogin" runat="server" class="btn btn-primary btn-block btn-flat" Text="Login" 
                        onclick="btnLogin_Click"/>
        </div>
      </div>
    </form>
  </div>
</div>

<!-- jQuery 3 -->
<script src="bootstrap/bower_components/jquery/dist/jquery.min.js"></script>
<!-- Bootstrap 3.3.7 -->
<script src="bootstrap/bower_components/bootstrap/dist/js/bootstrap.min.js"></script>
<!-- iCheck -->
<script src="bootstrap/plugins/iCheck/icheck.min.js"></script>

</asp:Content>


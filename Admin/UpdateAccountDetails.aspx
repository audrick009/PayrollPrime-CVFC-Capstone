<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Admin.master" AutoEventWireup="true" CodeFile="UpdateAccountDetails.aspx.cs" Inherits="UpdateAccountDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="Server">
    Update Account Details
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="Server">
    <%--<form runat="server" class="form-horizontal">
        <div class="col-lg-6">
            <div class="form-group">
                <label class="control-label col-lg-4">Account ID</label>
                <div class="col-lg-8">
                    <asp:TextBox ID="txtID" runat="server" class="form-control" MaxLength="50" ReadOnly required />
                </div>
            </div>
            <div class="form-group">
                <label class="control-label col-lg-4">Name</label>
                <div class="col-lg-8">
                    <asp:TextBox ID="txtName" runat="server" class="form-control" MaxLength="50" ReadOnly required />
                </div>
            </div>
             <div class="form-group">
                <label class="control-label col-lg-4">Username</label>
                <div class="col-lg-8">
                    <asp:TextBox ID="txtUname" runat="server" class="form-control" MaxLength="50" ReadOnly required />
                </div>
            </div>
            <div class="form-group">
                <label class="control-label col-lg-4">Password</label>
                <div class="col-lg-8">
                    <asp:TextBox ID="txtPassword" runat="server" class="form-control" TextMode="Password" MaxLength="50" required />
                </div>
            </div>
              <div class="form-group">
                <label class="control-label col-lg-4">Re-enter new password</label>
                <div class="col-lg-8">
                    <asp:TextBox ID="ReEnterNP" runat="server" TextMode="Password" class="form-control" MaxLength="50" required />
                     <div id="validatealert" runat="server" class="alert alert-danger col-lg-12" visible="false">
                         Re-entered password does not match!
                    </div>
                </div>
            </div>
        </div>
         <div class="col-lg-12">
            <span>
                <asp:Button ID="btnCancel" runat="server" class="btn btn-default" Text="Cancel"
                    PostBackUrl="ViewUserAccount.aspx" formnovalidate />
                <asp:Button ID="btnUpdate" runat="server" class="btn btn-success" 
                Text="Update" onclick="btnUpdate_Click" />
            </span>
        </div>
    </form>--%>

    <div class="container">
        <div class="row">
            <div class="col-lg-4 col-lg-offset-4">
                <div class="box">
                    <div class="box header with-border">
                    </div>
                    <form runat="server">
                        <div class="box-body">
                            <div class="form-group">
                                <label>Account ID: </label>
                                <asp:TextBox ID="txtID" runat="server" class="form-control" MaxLength="50" ReadOnly required />

                            </div>
                            <div class="form-group">
                                <label>Name: </label>
                                <asp:TextBox ID="txtName" runat="server" class="form-control" MaxLength="50" ReadOnly required />
                            </div>
                            <div class="form-group">
                                <label>Username:</label>
                                <asp:TextBox ID="txtUname" runat="server" class="form-control" MaxLength="50" ReadOnly required />
                            </div>
                            <div class="form-group">
                                <label>New Password:</label>
                                <asp:TextBox ID="txtPassword" runat="server" class="form-control" TextMode="Password" MaxLength="50" required />
                            </div>
                            <div class="form-group">
                                <label>Re-enter New Password:</label>
                                <asp:TextBox ID="ReEnterNP" runat="server" TextMode="Password" class="form-control" MaxLength="50" required />
                                <div id="validatealert" runat="server" class="alert alert-danger col-lg-12" visible="false">
                                    Re-entered password does not match!
                                </div>
                            </div>
                        </div>
                        <div class="box-footer">
                            <asp:Button ID="btnCancel" runat="server" class="btn btn-default" Text="Cancel"
                                PostBackUrl="ViewUserAccount.aspx" formnovalidate />
                            <asp:Button ID="btnUpdate" runat="server" class="btn btn-success pull-right"
                                Text="Update" OnClick="btnUpdate_Click" />
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </div>
</asp:Content>


<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Admin.master" AutoEventWireup="true" CodeFile="UpdateAccountDetails.aspx.cs" Inherits="UpdateAccountDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
    Update Account Details
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" Runat="Server">
    <form runat="server" class="form-horizontal">
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
    </form>
</asp:Content>


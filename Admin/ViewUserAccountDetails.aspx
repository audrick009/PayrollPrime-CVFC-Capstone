<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Admin.master" AutoEventWireup="true" CodeFile="ViewUserAccountDetails.aspx.cs" Inherits="Admin_ViewUserAccountDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
    <i class="fa fa-user"></i> User Account Details
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" Runat="Server">
    <form class="form-horizontal" runat="server">
        <div class="col-lg-6">
           <label class="control-label col-lg">Account ID #: </label>
                    <asp:Literal ID="ltID" runat="server"  />
            <br />
            <label class="control-label col-lg">Name: </label>
                    <asp:Literal ID="ltName" runat="server"  />
            <br />
            <label class="control-label col-lg">Username: </label>
                    <asp:Literal ID="ltUname" runat="server"  />
            <br />
            <label class="control-label col-lg">Status: </label>
                    <asp:Literal ID="ltStatus" runat="server"  />
            <br />
            <label class="control-label col-lg">Date Added: </label>
                    <asp:Literal ID="ltDateAdded"  runat="server"/>
            <br />

        </div>
    </form>
</asp:Content>


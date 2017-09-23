<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/HumanResource.master" AutoEventWireup="true" CodeFile="AttendanceOverride.aspx.cs" Inherits="Employee_AttendanceOverride" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
    Attendance Override
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" Runat="Server">
    <form runat="server" class="form-horizontal">
        <div class="col-lg-12">
            <div class="col-lg-6">
                <asp:Button ID="btnTimeIn" runat="server" class="btn btn-info pull-right" Text="Time-In" OnClick="btnTimeIn_Click"/>
                <asp:Button ID="btnTimeOut" runat="server" class="btn btn-info pull-right" Text="Time-Out" visible="false" OnClick="btnTimeOut_Click"/>
            </div>
        </div>
    </form>
</asp:Content>


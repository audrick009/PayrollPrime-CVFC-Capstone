<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/PayOfficer.master" AutoEventWireup="true" CodeFile="AddHoliday.aspx.cs" Inherits="PayrollOfficer_AddHoliday" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="Server">
    <i class="fa fa-plus"></i>Add Holiday
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="Server">

    <form id="Form1" class="form-horizontal" runat="server">
        <div class="col-lg-6">

            <div class="form-group">
                <label class="control-label col-lg-4">Name of Holiday</label>
                <div class="col-lg-8">
                    <asp:TextBox ID="txtNameHD" class="form-control" runat="server" required="required" />
                </div>
            </div>


            <div class="form-group">
                <label class="control-label col-lg-4">Date of Holiday</label>
                <div class="col-lg-8">
                    <asp:TextBox ID="txtDateHD" TextMode="Date" class="form-control" runat="server" required="required" />
                </div>
            </div>


            <div class="form-group">
                <label class="control-label col-lg-4">Description</label>
                <div class="col-lg-8">
                    <asp:TextBox ID="txtHDDesc" TextMode="MultiLine" class="form-control" runat="server" required="required" />

                    <center>
                        <asp:Button ID="addHoliday" runat="server" Text="Add Holiday" class="btn btn-success" OnClick="addHoliday_Click" />
                    </center>
                </div>
            </div>
        </div>
    </form>
</asp:Content>


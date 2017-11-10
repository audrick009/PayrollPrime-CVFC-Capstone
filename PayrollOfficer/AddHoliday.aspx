<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/PayOfficer.master" AutoEventWireup="true" CodeFile="AddHoliday.aspx.cs" Inherits="PayrollOfficer_AddHoliday" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="Server">
    <i class="fa fa-plus"></i>Add Holiday
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="Server">

    <form id="Form1" class="form-horizontal" runat="server">
        <div class="col-lg-6 col-lg-offset-3">
            <div class="box box-primary">
                <div class="box-header with-border">
                    <h3 class="box-title">Add Holiday&nbsp<i class="fa fa-calendar"></i></h3>
                </div>
                <div class="box-body">
                    <div class="col-lg-12">
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
                            </div>
                        </div>
                    </div>
                </div>
                <div class="box-footer">
                    <asp:Button ID="addHoliday" runat="server" Text="Add Holiday" class="btn btn-success pull-right" OnClick="addHoliday_Click" />
                </div>
            </div>
        </div>
    </form>
</asp:Content>


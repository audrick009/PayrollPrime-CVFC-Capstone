<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/HumanResource.master" AutoEventWireup="true" CodeFile="EmpOffense.aspx.cs" Inherits="HumanResource_EmpOffense" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
    Add Offenses Record
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" Runat="Server">
    <form runat="server"  class="form-horizontal">
        <div class="col-lg-12">
            <div class="col-lg-6">
                <div class="form-group">
                    <label class="control-label col-lg-4">Event</label>
                        <div class="col-lg-8">
                            <asp:TextBox ID="txtEvent" runat="server" class="form-control" />
                        </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-lg-4">Offense No</label>
                        <div class="col-lg-8">
                            <asp:TextBox ID="txtOffenseNo" runat="server" class="form-control" />
                        </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-lg-4">Days</label>
                        <div class="col-lg-8">
                            <asp:TextBox ID="txtDays" TextMode="Number" runat="server" class="form-control" />
                        </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-lg-4">Starting Date</label>
                        <div class="col-lg-8">
                            <asp:TextBox ID="txtDateStart" TextMode="Date" runat="server" class="form-control" />
                        </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-lg-4">Ending Date</label>
                        <div class="col-lg-8">
                            <asp:TextBox ID="txtDateEnd" TextMode="Date" runat="server" class="form-control" />
                        </div>
                </div>
                <asp:Button ID="btnAddOffense" runat="server" class="btn btn-success pull-right" Text="Add" OnClick="btnAddOffense_Click" />
            </div>
        </div>
    </form>
</asp:Content>


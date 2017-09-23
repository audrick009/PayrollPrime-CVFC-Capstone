<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/PayOfficer.master" AutoEventWireup="true" CodeFile="GenSumOfSal.aspx.cs" Inherits="PayrollOfficer_GenSumOfSal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
    Generate Summary of Salary
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" Runat="Server">
    <form runat="server" class="form-horizontal">
        <div class="col-lg-4">
            <div class="form-group">
                    <label class="control-label col-lg-4">Start Date</label>
                        <div class="col-lg-8">
                            <asp:DropDownList ID="ddlPayTerm" runat="server" class="form-control" />
                        </div>
                </div>
            </div>
            <div class="col-lg-4">
                <div class="form-group">
                    <asp:Button ID="btnGenRep" runat="server" class="btn btn-success pull-right" Text="Generate Report" OnClick="btnGenRep_Click" />
                </div>
            </div>
    </form>
</asp:Content>


<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/HumanResource.master" AutoEventWireup="true" CodeFile="EmpLoanRecords.aspx.cs" Inherits="HumanResource_EmpLoanRecords" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
    Add Loan Record
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" Runat="Server">
    <form runat="server" class="form-horizontal">
        <div class="col-lg-12">
            <div class="col-lg-6">
                <div class="form-group">
                    <label class="control-label col-lg-4">Loan Type</label>
                        <div class="col-lg-8">
                            <asp:TextBox ID="txtLType" runat="server" class="form-control" />
                        </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-lg-4">Loan Rate</label>
                        <div class="col-lg-8">
                            <asp:TextBox ID="txtLRate" runat="server" class="form-control" />
                        </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-lg-4">Total Loan</label>
                        <div class="col-lg-8">
                            <asp:TextBox ID="txtLTotal" runat="server" class="form-control" />
                        </div>
                </div>
                <asp:Button ID="btnInsertLoan" runat="server" class="btn btn-success pull-right" Text="Add Loan Record" OnClick="btnInsertLoan_Click" />
            </div>
        </div>
    </form>
</asp:Content>


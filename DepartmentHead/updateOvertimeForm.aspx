<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/DepartmentHead.master" AutoEventWireup="true" CodeFile="updateOvertimeForm.aspx.cs" Inherits="DepartmentHead_updateOvertimeForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
    <i class="fa fa-thumbs-o-up"></i> Overtime Form Approvals
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" Runat="Server">
    <form id="form2" class="form-horizontal" runat="server">
        <div class="col-lg-6">

            <div class="form-group">
                <label class="control-label col-lg-4">Overtime Form ID:</label>
                <div class="col-lg-8">
                    <asp:TextBox ID="otRIDTXT" runat="server" class="form-control" ReadOnly />
                </div>
            </div>

            <div class="form-group">
                <label class="control-label col-lg-4">Employee ID:</label>
                <div class="col-lg-8">
                    <asp:TextBox ID="employeeIDTXT" runat="server" class="form-control" ReadOnly />
                </div>
            </div>

            <div class="form-group">
                <label class="control-label col-lg-4">Date:</label>
                <div class="col-lg-8">
                    <asp:TextBox ID="dateTXT" runat="server" class="form-control" ReadOnly />
                </div>
            </div>

            <div class="form-group">
                <label class="control-label col-lg-4">Hours:</label>
                <div class="col-lg-8">
                    <asp:TextBox ID="hoursTXT" runat="server" class="form-control" ReadOnly />
                </div>
            </div>

            <div class="form-group">
                <label class="control-label col-lg-4">Start Time:</label>
                <div class="col-lg-8">
                    <asp:TextBox ID="startTXT" runat="server" class="form-control" ReadOnly />
                </div>
            </div>

            <div class="form-group">
                <label class="control-label col-lg-4">End Time:</label>
                <div class="col-lg-8">
                    <asp:TextBox ID="endTXT" runat="server" class="form-control" ReadOnly />
                </div>
            </div>

            <div class="form-group">
                <label class="control-label col-lg-4">Reason:</label>
                <div class="col-lg-8">
                    <asp:TextBox ID="reasonTXT" runat="server" class="form-control" ReadOnly />
                </div>
            </div>

            <div class="form-group">
                <label class="control-label col-lg-4">Status:</label>
                <div class="col-lg-8">
                    <asp:TextBox ID="statusTXT" runat="server" class="form-control" ReadOnly />
                </div>
            </div>

            <div class="form-group">
                <label class="control-label col-lg-4">Approved By:</label>
                <div class="col-lg-8">
                    <asp:TextBox ID="approveTXT" runat="server" class="form-control" ReadOnly />
                </div>
            </div>

            <div class="form-group">
                <div class="col-lg-offset-4 col-lg-8">
                    <asp:Button ID="approveBTN" runat="server" class="btn btn-success" Text="Approved" OnClick="approveBTN_Click" />
                    <asp:Button ID="rejectBTN" runat="server" class="btn btn-danger" Text="Reject" OnClick="rejectBTN_Click" />
                </div>
            </div>

        </div>
    </form>
</asp:Content>


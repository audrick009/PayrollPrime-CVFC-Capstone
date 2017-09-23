<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/DepartmentHead.master" AutoEventWireup="true" CodeFile="updateLeaveForm.aspx.cs" Inherits="updateLeaveForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="Server">
    <i class="fa fa-thumbs-o-up"></i> Leave Form Approvals
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="Server">
    <form id="form2" class="form-horizontal" runat="server">
        

        <div class="col-lg-6">

            <div class="form-group">
                <label class="control-label col-lg-4">Leave Form ID:</label>
                <div class="col-lg-8">
                    <asp:TextBox ID="leaveRIDTXT" runat="server" class="form-control" ReadOnly />
                </div>
            </div>


            <div class="form-group">
                <label class="control-label col-lg-4">Employee ID:</label>
                <div class="col-lg-8">
                    <asp:TextBox ID="employeeTXT" runat="server" class="form-control" ReadOnly />
                </div>
            </div>

            <div class="form-group">
                <label class="control-label col-lg-4">Status:</label>
                <div class="col-lg-8">
                    <asp:TextBox ID="statusTXT" runat="server" class="form-control" ReadOnly />
                </div>
            </div>

            <div class="form-group">
                <label class="control-label col-lg-4">Leave Type:</label>
                <div class="col-lg-8">
                    <asp:TextBox ID="leavetypeTXT" runat="server" class="form-control" ReadOnly />
                </div>
            </div>

            <div class="form-group">
                <label class="control-label col-lg-4">Days:</label>
                <div class="col-lg-8">
                    <asp:TextBox ID="daysTXT" runat="server" class="form-control" ReadOnly />
                </div>
            </div>

            <div class="form-group">
                <label class="control-label col-lg-4">Starting Date:</label>
                <div class="col-lg-8">
                    <asp:TextBox ID="startingDateTXT" runat="server" class="form-control" ReadOnly />
                </div>
            </div>

            <div class="form-group">
                <label class="control-label col-lg-4">Ending Date:</label>
                <div class="col-lg-8">
                    <asp:TextBox ID="endingDateTXT" runat="server" class="form-control" ReadOnly />
                </div>

            </div>


            <div class="form-group">
                <div class="col-lg-offset-4 col-lg-8">
                    <asp:Button ID="approveBTN" runat="server" class="btn btn-success" Text="Approved" OnClick="approveBTN_Click" />
                    <asp:Button ID="rejectBTN" runat="server" class="btn btn-danger" Text="Rejected" OnClick="rejectBTN_Click" />
                </div>
            </div>



        </div>

    </form>
</asp:Content>


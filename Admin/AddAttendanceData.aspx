<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Admin.master" AutoEventWireup="true" CodeFile="AddAttendanceData.aspx.cs" Inherits="Admin_AddAttendanceData" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
    Add Attendance Data
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" Runat="Server">
    <form runat="server" class="form-horizontal">
        <div class="col-lg-12">
            <div class="col-lg-6">
                <div class="form-group">
                    <label class="control-label col-lg-4">Employees</label>
                        <div class="col-lg-8">
                            <asp:DropDownList ID="ddlEmployees" runat="server" class="form-control"  />
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-lg-4">Date</label>
                        <div class="col-lg-8">
                            <asp:TextBox ID="txtDate" runat="server" class="form-control" TextMode="Date" />
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-lg-4">TimeIn</label>
                        <div class="col-lg-8">
                            <asp:TextBox ID="txtTimeIn" runat="server" class="form-control" TextMode="Time" format="HH:mm:ss" />
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-lg-4">TimeOut</label>
                        <div class="col-lg-8">
                            <asp:TextBox ID="txtTimeOut" runat="server" class="form-control" TextMode="Time" format="HH:mm:ss" />
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-lg-offset-4 col-lg-8">
                        <asp:Button ID="btnAdd" runat="server" class="btn btn-success" Text="Add" OnClick="btnAdd_Click" />
                    </div>
                </div>
            </div>
            <div class="col-lg-6">

            </div>
        </div>
    </form>
</asp:Content>


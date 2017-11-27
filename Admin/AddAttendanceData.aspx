<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Admin.master" AutoEventWireup="true" CodeFile="AddAttendanceData.aspx.cs" Inherits="Admin_AddAttendanceData" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="Server">
    Add Manual Attendance
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="Server">
    <%--<form runat="server" class="form-horizontal">
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
    </form>--%>

     <div class="container">
        <div class="row">
            <div class="col-lg-4 col-lg-offset-4">
                <div class="box">
                    <div class="box-header with-border">
                        <h3 class="box-title">Manual Attendance Data&nbsp<i class="fa fa-clock-o"></i></h3>
                    </div>
                    <form class="form" runat="server">
                        <div class="box-body">
                           <div class="form-group">
                                <label>Employees:</label>
                                <asp:DropDownList ID="ddlEmployees" runat="server" class="form-control"  required/>
                           </div>
                            <div class="form-group">
                                <label>Date:</label>
                                <asp:TextBox ID="txtDate" runat="server" class="form-control" TextMode="Date" required/>
                           </div>
                            <div class="form-group">
                                <label>Time-in:</label>
                                 <asp:TextBox ID="txtTimeIn" runat="server" class="form-control" TextMode="Time" format="HH:mm:ss" required/>
                           </div>
                            <div class="form-group">
                                <label>Time-out:</label>
                                 <asp:TextBox ID="txtTimeOut" runat="server" class="form-control" TextMode="Time" format="HH:mm:ss" required/>
                           </div>
                        </div>
                        <div class="box-footer">
                              <asp:Button ID="btnAdd" runat="server" class="btn btn-success pull-right" Text="Add" OnClick="btnAdd_Click" />
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </div>
                     
</asp:Content>


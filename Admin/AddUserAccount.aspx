<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Admin.master" AutoEventWireup="true" CodeFile="AddUserAccount.aspx.cs" Inherits="AddUserAccount" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="Server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="Server">
    <%-- <form runat="server" class="form-horizontal">
        <div class="col-lg-6">
            <div class="form-group">
                <label class="control-label col-lg-4">Employees</label>
                <div class="col-lg-8">
                   <asp:DropDownList ID="ddlEmployees" runat="server"
                       class="form-control"  />
                </div>
            </div>
            <div class="form-group">
                <label class="control-label col-lg-4">Username</label>
                <div class="col-lg-8">
                    <asp:TextBox ID="txtUname" runat="server"
                        class="form-control" required />
                    <div id="validatealert" runat="server" class="alert alert-danger col-lg-12" visible="false">
                            Only accepts numeric value.
                         </div>
                    <div id="validatealert2" runat="server" class="alert alert-danger col-lg-12" visible="false">
                            This username already exists!
                         </div>
                </div>
            </div>
            <div class="form-group">
                <label class="control-label col-lg-4">Password</label>
                <div class="col-lg-8">
                    <asp:TextBox ID="txtPword" runat="server"
                        class="form-control" type="password" required />
                </div>
            </div>
            <div class="form-group">
                <div class="col-lg-offset-4 col-lg-8">
                    <asp:Button ID="btnAdd" runat="server"
                        class="btn btn-success" Text="Add" OnClick="btnAdd_Click" />
                </div>
            </div>
        </div>
    </form>--%>
    <div class="row">
        <div class="col-lg-4">
        </div>
        <div class="col-lg-4">
            <!-- general form elements -->
            <div class="box box-primary">
                <div class="box-header with-border">
                    <h3 class="box-title">Create User Account <i class="fa fa-plus pull-right"></i></h3>
                </div>
                <!-- /.box-header -->
                <!-- form start -->
                <form role="form" runat="server">
                    <div class="box-body">
                        <div class="form-group">
                            <label>Employees:</label>
                            <asp:DropDownList ID="ddlEmployees" runat="server"
                                class="form-control" />
                        </div>
                        <div class="form-group">
                            <label>Username:</label>
                            <asp:TextBox ID="txtUname" runat="server"
                                class="form-control" required />
                        </div>
                        <div class="form-group">
                            <label>Password:</label>
                            <asp:TextBox ID="txtPword" runat="server"
                                class="form-control" type="password" required />
                        </div>

                    </div>
                    <!-- /.box-body -->

                    <div class="box-footer">
                        <asp:Button ID="btnCancel" runat="server" Text="Cancel" class="btn btn-danger" OnClick="btnCancel_Click" />
                        <asp:Button ID="btnAdd" runat="server"
                            class="btn btn-success pull-right" Text="Add User Account" OnClick="btnAdd_Click" />
                    </div>
                </form>
            </div>
        </div>
        <!-- /.box -->
    </div>
    <%-- <div class="row">
        <form runat="server">
            <div class="col-lg-4">

            </div>
            <div class="col-lg-4">
                <div class="form-group">
                    <label>Employees:</label>
                    <asp:DropDownList ID="ddlEmployees" runat="server"
                       class="form-control"  />
                </div>
                <div class="form-group">
                    <label>Username:</label>
                    <asp:TextBox ID="txtUname" runat="server"
                        class="form-control" required />
                </div>
                <div class="form-group">
                    <label>Password:</label>
                    <asp:TextBox ID="txtPword" runat="server"
                        class="form-control" type="password" required />
                </div>
                <div class="form-group pull-right">
                     <asp:Button ID="btnAdd" runat="server"
                        class="btn btn-success" Text="Add User Account" OnClick="btnAdd_Click" />
                </div>
            </div>
            <div class="col-lg-4">

            </div>
        </form>
    </div>--%>
</asp:Content>


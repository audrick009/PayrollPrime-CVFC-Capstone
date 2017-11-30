<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Admin.master" AutoEventWireup="true" CodeFile="addOvertime.aspx.cs" Inherits="addOvertime" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
    Apply Overtime
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" Runat="Server">
    <div class="container">
        <div class="row">
            <div class="col-lg-6 col-lg-offset-3">
                <div class="box">
                    <div class="box-header with-border">
                        <h3 class="box-title">Overtime Application Form&nbsp<i class="fa fa-clock-o"></i></h3>
                    </div>
                    <!-- /.box-header -->
                    <!-- form start -->
                    <form class="form-horizontal" runat="server">
                        <div class="box-body">
                            <div class="form-group">
                                <label class="col-sm-2 control-label">Date:</label>

                                <div class="col-sm-10">
                                    <asp:TextBox ID="dateTXT" TextMode="Date" class="form-control" runat="server" required/>
                                     <div id="error" runat="server" class="alert alert-danger" visible="false">
                                        Can only apply overtime once!
                                    </div>
                                    <p id="demo" runat="server"></p>
                                </div>
                            </div>
                            <div class="form-group">
                                <label class="col-sm-2 control-label">Hours:</label>


                                <div class="col-sm-10">
                                    <asp:TextBox ID="hoursTXT" min="1" max="14.5" step="any" TextMode="number" class="form-control" runat="server" required/>
                                </div>
                            </div>
                            <div class="form-group">
                                 <label class="col-sm-2 control-label">Reason:</label>

            

                                    <div class="col-sm-10">
                                       <asp:TextBox ID="reasonTXT" TextMode="MultiLine" class="form-control" runat="server" style="resize: none;" required/>
                                    </div>
                                </div>
                            </div>
                        <!-- /.box-body -->
                        <div class="box-footer">
                             <asp:Button ID="addOvertimeBTN" runat="server" Text="Submit Overtime Form" class="btn btn-warning pull-right" OnClick="addOvertimeBTN_Click" />
                        </div>
                        <!-- /.box-footer -->
                    </form>
                </div>
            </div>
        </div>
    </div>
</asp:Content>


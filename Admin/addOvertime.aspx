<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Admin.master" AutoEventWireup="true" CodeFile="addOvertime.aspx.cs" Inherits="addOvertime" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="Server">
    File Overtime
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="server">

    <%-- <div class="col-lg-6">

            <div class="form-group">
                <label class="control-label col-lg-4">Date of Overtime:</label>
                <div class="col-lg-8">
                    <asp:TextBox ID="dateTXT" TextMode="Date" class="form-control" runat="server" required ="required"  />
                </div>
            </div>

            <div class="form-group">
                <label class="control-label col-lg-4">Hours:</label>
                <div class="col-lg-8">
                    <asp:TextBox ID="hoursTXT" min="1" TextMode="number" class="form-control" runat="server" required ="required" />
                 
                </div>
            </div>

                   
          
            <div class="form-group">
                <label class="control-label col-lg-4">Reason</label>
                <div class="col-lg-8">
                    <asp:TextBox ID="reasonTXT" TextMode="MultiLine" class="form-control" runat="server" required = "required"/>
                    <center>
                        <asp:Button ID="addOvertimeBTN" runat="server" Text="Submit Overtime Form" class="btn btn-success" OnClick="addOvertimeBTN_Click" />
                    </center>
                </div>
            </div>
                    
           </div>--%>
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
                                </div>
                            </div>
                            <div class="form-group">
                                <label class="col-sm-2 control-label">Hours:</label>

                                <div class="col-sm-10">
                                    <asp:TextBox ID="hoursTXT" TextMode="number" class="form-control" runat="server" required/>
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


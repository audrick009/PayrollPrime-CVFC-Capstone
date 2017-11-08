<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/HumanResource.master" AutoEventWireup="true" CodeFile="AddLeave.aspx.cs" Inherits="Leave_AddLeave" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="Server">
    File Leave
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="Server">
    <div class="container">
        <div class="row">
            <div class="col-lg-6 col-lg-offset-3">
                <div class="box">
                    <div class="box-header with-border">
                        <h3 class="box-title">Leave Application Form&nbsp<i class="fa fa-clock-o"></i></h3>
                    </div>
                    <form class="form-horizontal" runat="server">
                        <div class="box-body">
                            <div class="form-group">
                                <label class="col-sm-2 control-label">Type:</label>

                                <div class="col-sm-10">
                                    <asp:DropDownList ID="ddLeaveType" runat="server" class="form-control" required>
                                        <asp:ListItem>Vacation</asp:ListItem>
                                        <asp:ListItem>Sick</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                            </div>

                            <div class="form-group">
                                <label class="col-sm-2 control-label">Day Type:</label>

                                     <div class="col-sm-10">
                                <asp:DropDownList ID="ddlDayType" runat="server" class="form-control" OnSelectedIndexChanged="ddlDayType_SelectedIndexChanged" AutoPostBack="true" required>
                                        <asp:ListItem>Whole</asp:ListItem>
                                        <asp:ListItem>Half</asp:ListItem>
                                    </asp:DropDownList>
                            </div>
                                     </div>

                            <div class="form-group">
                                <label class="col-sm-2 control-label">Start:</label>

                                <div class="col-sm-10">
                                   <asp:TextBox ID="startDateTxt" TextMode="Date" runat="server" class="form-control" required  />
                                </div>
                            </div>
                            <div class="form-group">
                                <label class="col-sm-2 control-label">End:</label>

                                <div class="col-sm-10">
                                   <asp:TextBox TextMode="Date" ID="endDateTxt"  runat="server" cssclass="form-control" required  />
                                </div>
                            </div>
                        </div>
                        <div class="box-footer">
                               <asp:Button ID="submitleaveBtn" runat="server" Text="Submit Leave Form" OnClick="Button1_Click" class="btn btn-warning pull-right" />
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </div>
</asp:Content>



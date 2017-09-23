<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/PayOfficer.master" AutoEventWireup="true" CodeFile="AddLeave.aspx.cs" Inherits="Leave_AddLeave" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="Server">
    <i class="fa fa-plus"></i> Create Leave Form Application
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="Server">
    <form id="form1" class="form-horizontal" runat="server">
        <div class="col-lg-6">
            <%--<div class="form-group">
                <label class="control-label col-lg-4">Employee ID:</label>
                <div class="col-lg-8">
                    <asp:TextBox ID="employeeIDtxt" runat="server" class="form-control"  />
                </div>
            </div>--%>

            <div class="form-group">
                <label class="control-label col-lg-4">Choose Leave Type:</label>
                <div class="col-lg-8">
                    <asp:DropDownList ID="ddLeaveType" runat="server" class="form-control" required > 
                        <asp:ListItem>Choose Leave</asp:ListItem>
                        <asp:ListItem>Vacation</asp:ListItem>
                        <asp:ListItem>Sick</asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>

            <div class="form-group">
                <label class="control-label col-lg-4">Days:</label>
                <div class="col-lg-8">
                    <asp:TextBox ID="daysTxt" TextMode="Number" runat="server" class="form-control" required />
                    <%--<asp:RegularExpressionValidator id="daysVal" runat ="server" ErrorMessage="Number Only"
                                        ControlToValidate="daysTxt" ValidationExpression="^[0-9]*$" ForeColor="Red" />--%>
                </div>
            </div>

             <div class="form-group">
                <label class="control-label col-lg-4">Start Date of Leave:</label>
                 <div class="col-lg-8">
                <asp:TextBox ID="startDateTxt" TextMode="Date" runat="server" class="form-control" required  />
                     </div>
            </div>

            <div class="form-group">
                <label class="control-label col-lg-4">End Date of Leave:</label>
                <div class="col-lg-8">
                    <asp:TextBox TextMode="Date" ID="endDateTxt"  runat="server" class="form-control" required  />
                    <center>
            <asp:Button ID="submitleaveBtn" runat="server" Text="Submit Leave Form" OnClick="Button1_Click" class="btn btn-success" />
                    </center>      
                </div>
            </div>      
        </div>
    </form> 
</asp:Content>



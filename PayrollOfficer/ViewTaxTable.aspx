<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/PayOfficer.master" AutoEventWireup="true" CodeFile="ViewTaxTable.aspx.cs" Inherits="PayrollOfficer_ViewTaxTable" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
    View Tax Table
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" Runat="Server">
    <div class="container-fluid">
        <div class="col-lg-12">
            <div class="row">
                <div class="box">
                    <div class="box-header with-border">
                        <h3 class="box-title">Tax Transmutation Table&nbsp<i class="fa fa-calculator"></i></h3>
                    </div>
                    <form class="form-horizontal" runat="server">
                        <div class="box-body">
                            <table class="table">
                                <thead>
                                    <tr>
                                        <th>Description</th>
                                        <th>Category</th>
                                        <th>Low</th>
                                        <th>High</th>
                                        <th>PercentageOver</th>
                                        <th>Base Tax</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td><asp:TextBox ID="Z1Desc" runat="server" /></td>
                                        <td><asp:TextBox ID="Z1Cat" runat="server" /></td>
                                        <td><asp:TextBox ID="Z1Low" runat="server" /></td>
                                        <td><asp:TextBox ID="Z1High" runat="server" /></td>
                                        <td><asp:TextBox ID="Z1PercentageOver" runat="server" /></td>
                                        <td><asp:TextBox ID="Z1BaseTax" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td><asp:TextBox ID="Z2Desc" runat="server" /></td>
                                        <td><asp:TextBox ID="Z2Cat" runat="server" /></td>
                                        <td><asp:TextBox ID="Z2Low" runat="server" /></td>
                                        <td><asp:TextBox ID="Z2High" runat="server" /></td>
                                        <td><asp:TextBox ID="Z2PercentageOver" runat="server" /></td>
                                        <td><asp:TextBox ID="Z2BaseTax" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td><asp:TextBox ID="Z3Desc" runat="server" /></td>
                                        <td><asp:TextBox ID="Z3Cat" runat="server" /></td>
                                        <td><asp:TextBox ID="Z3Low" runat="server" /></td>
                                        <td><asp:TextBox ID="Z3High" runat="server" /></td>
                                        <td><asp:TextBox ID="Z3PercentageOver" runat="server" /></td>
                                        <td><asp:TextBox ID="Z3BaseTax" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td><asp:TextBox ID="Z4Desc" runat="server" /></td>
                                        <td><asp:TextBox ID="Z4Cat" runat="server" /></td>
                                        <td><asp:TextBox ID="Z4Low" runat="server" /></td>
                                        <td><asp:TextBox ID="Z4High" runat="server" /></td>
                                        <td><asp:TextBox ID="Z4PercentageOver" runat="server" /></td>
                                        <td><asp:TextBox ID="Z4BaseTax" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td><asp:TextBox ID="Z5Desc" runat="server" /></td>
                                        <td><asp:TextBox ID="Z5Cat" runat="server" /></td>
                                        <td><asp:TextBox ID="Z5Low" runat="server" /></td>
                                        <td><asp:TextBox ID="Z5High" runat="server" /></td>
                                        <td><asp:TextBox ID="Z5PercentageOver" runat="server" /></td>
                                        <td><asp:TextBox ID="Z5BaseTax" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td><asp:TextBox ID="Z6Desc" runat="server" /></td>
                                        <td><asp:TextBox ID="Z6Cat" runat="server" /></td>
                                        <td><asp:TextBox ID="Z6Low" runat="server" /></td>
                                        <td><asp:TextBox ID="Z6High" runat="server" /></td>
                                        <td><asp:TextBox ID="Z6PercentageOver" runat="server" /></td>
                                        <td><asp:TextBox ID="Z6BaseTax" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td><asp:TextBox ID="Z7Desc" runat="server" /></td>
                                        <td><asp:TextBox ID="Z7Cat" runat="server" /></td>
                                        <td><asp:TextBox ID="Z7Low" runat="server" /></td>
                                        <td><asp:TextBox ID="Z7High" runat="server" /></td>
                                        <td><asp:TextBox ID="Z7PercentageOver" runat="server" /></td>
                                        <td><asp:TextBox ID="Z7BaseTax" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td><asp:TextBox ID="Z8Desc" runat="server" /></td>
                                        <td><asp:TextBox ID="Z8Cat" runat="server" /></td>
                                        <td><asp:TextBox ID="Z8Low" runat="server" /></td>
                                        <td><asp:TextBox ID="Z8High" runat="server" /></td>
                                        <td><asp:TextBox ID="Z8PercentageOver" runat="server" /></td>
                                        <td><asp:TextBox ID="Z8BaseTax" runat="server" /></td>
                                    </tr>

                                </tbody>
                            </table>
                        </div>
                        <div class="box-footer">
                               <asp:Button ID="submitleaveBtn" runat="server" Text="Submit Leave Form" class="btn btn-warning pull-right" />
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </div>
</asp:Content>


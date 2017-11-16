<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/PayOfficer.master" AutoEventWireup="true" CodeFile="ViewHolidays.aspx.cs" Inherits="PayrollOfficer_ViewHolidays" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="Server">
    View Holidays
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="Server">
    <div class="container-fluid">


        <div class="row">
            <form runat="server" class="form-horizontal">
                <div class="col-lg-12">
                    <div class="form-group">
                        <div class="box box-solid box-primary">
                            <div class="box-header">
                                <h3 class="box-title">Holidays</h3>
                            </div>
                            <div class="box-body">
                                <table class="table table-bordered">
                                    <thead>
                                        <th>Holiday Name</th>
                                        <th>Date</th>
                                        <th>Description</th>
                                    </thead>
                                    <tbody>
                                        <asp:ListView ID="lvHoliday" runat="server">
                                            <ItemTemplate>
                                                <tr>
                                                    <td><%# Eval("hName") %></td>
                                                    <td><%# Eval("Date", "{0: MMMM dd, yyyy }") %></td>
                                                    <td><%# Eval("hDesc") %></td>
                                                </tr>
                                            </ItemTemplate>
                                        </asp:ListView>
                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>
                </div>
            </form>
        </div>
    </div>
</asp:Content>


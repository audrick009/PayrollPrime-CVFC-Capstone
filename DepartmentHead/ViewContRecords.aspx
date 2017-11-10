<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/DepartmentHead.master" AutoEventWireup="true" CodeFile="ViewContRecords.aspx.cs" Inherits="HumanResource_EmpContRecords" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="Server">
    Contribution Records
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="Server">
    <%--<form runat="server" class="form-horizontal">
        <div class="col-lg-12">
            <div class="form-group container"> <!-- paki tanggal ung container PAG nag bug ung listview. Naka gilid kasi masyado kaya tinry ko lagay container-->
                <table class="table table-hover">
                    <thead>
                        <th>Contribution Type</th>
                        <th>Contribution Rate</th>
                        <th>Date Started</th>
                        <th>No. of Times</th>
                        <th>Total Contribution</th>
                    </thead>
                    <tbody>
                        <asp:ListView ID="lvContRec" runat="server">
                        <ItemTemplate>
                            <tr>
                                <td> <%# Eval("ContributionType") %></td>
                                <td> <%# Eval("ContributionRate") %></td>
                                <td> <%# Eval("NoOfCont") %></td>
                                <td> <%# Eval("TotalContribution") %> </td>
                                <td> <%# Eval("DateStarted", "{0: MMMM dd, yyyy}") %></td>
                            </tr>
                        </ItemTemplate>
                        </asp:ListView>
                    </tbody>
                </table>
            </div>
        </div>
    </form>--%>
<form runat="server" class="form-horizontal">
    <div class="box">
        <!-- /.box-header -->
        <div class="box-body no-padding">
            <table class="table table-striped">
                <thead>
                    <th>Contribution Type</th>
                    <th>Contribution Rate</th>
                    <th>Date Started</th>
                    <th>No. of Times</th>
                    <th>Total Contribution</th>
                </thead>
                <tbody>
                    <asp:ListView ID="lvContRec" runat="server">
                        <ItemTemplate>
                            <tr>
                                <td><%# Eval("ContributionType") %></td>
                                <td><%# Eval("ContributionRate") %></td>
                                <td><%# Eval("NoOfCont") %></td>
                                <td><%# Eval("TotalContribution") %> </td>
                                <td><%# Eval("DateStarted", "{0: MMMM dd, yyyy}") %></td>
                            </tr>
                        </ItemTemplate>
                        <EmptyDataTemplate>
                            <tr>
                                <td colspan="10">
                                    <h2 class="text-center">No logs Found.</h2>
                                </td>
                            </tr>
                        </EmptyDataTemplate>
                    </asp:ListView>
                </tbody>
            </table>
        </div>
        <!-- /.box-body -->
    </div>
</form>
</asp:Content>


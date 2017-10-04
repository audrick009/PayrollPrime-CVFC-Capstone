<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/HumanResource.master" AutoEventWireup="true" CodeFile="EmpDetails.aspx.cs" Inherits="HumanResource_EmpDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
    Employee Detailed Information
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" Runat="Server">
    <div class="col-lg-12">
        <div class="col-lg-6">
            <label class="control-label col-lg">Name: </label>
                    <asp:Literal ID="ltName" runat="server"  />
            <br />
            <label class="control-label">Birthdate: </label>
                    <asp:Literal ID="ltBirthDate" runat="server" />
            <br />
            <label class="control-label">Sex: </label>
                    <asp:Literal ID="ltSex" runat="server" />
            <br />
            <label class="control-label">SSSno: </label>
                    <asp:Literal ID="ltSSSno" runat="server" />
            <br />
            <label class="control-label">TINno: </label>
                    <asp:Literal ID="ltTINno" runat="server" />
            <br />
            <label class="control-label">BIRno: </label>
                    <asp:Literal ID="ltBIRno" runat="server" />
            <br />
            <label class="control-label">HDMFno: </label>
                    <asp:Literal ID="ltHDMFno" runat="server" />
        <br />
            <label class="control-label">Phone No: </label>
                    <asp:Literal ID="ltPhoneNo" runat="server" />
        <br />
    </div>
    <div class="col-lg-6">
        <label class="control-label">Mobile No: </label>
                    <asp:Literal ID="ltMobileNo" runat="server" />
        <br />
            <label class="control-label">Civil Status: </label>
                    <asp:Literal ID="ltCivStatus" runat="server" />
        <br />
            <label class="control-label">Status: </label>
                    <asp:Literal ID="ltStatus" runat="server" />
        <br />
            <label class="control-label">Position: </label>
                    <asp:Literal ID="ltPosition" runat="server" />
        <br />
            <label class="control-label">Date Employed: </label>
                    <asp:Literal ID="ltDateEmp" runat="server" />
        <br />
            <label class="control-label">Date Created: </label>
                    <asp:Literal ID="ltDateCrt" runat="server" />
        <br />
           <label class="control-label">Permanent Address: </label>
                    <asp:Literal ID="ltPermAdd" runat="server" />
        <br />
           <label class="control-label">Provincial Address: </label>
                    <asp:Literal ID="ltProvAdd" runat="server" />
        <br />
    </div>
    </div>
    <div class="col-lg-12">
     <h2 style="text-align:center">Offense Record</h2>
     <table class="table table-hover">
                <thead>
                    <th>Event</th>
                    <th>OffenseNo</th>
                    <th>Date Added</th>
                    <th>Days</th>
                    <th>Date Started</th>
                    <th>Date Ended</th>
                </thead>
                <tbody>
                    <asp:ListView ID="lvOffenseRecord" runat="server">
                        <ItemTemplate>
                            <tr>
                                <td> <%# Eval("Event") %></td>
                                <td> <%# Eval("OffenseNo") %></td>
                                <td> <%# Eval("DateAdded", "{0: MM/dd/yyyy }") %></td>
                                <td> <%# Eval("Days") %></td>
                                <td> <%# Eval("DateStarted", "{0: MM/dd/yyyy }") %></td>
                                <td> <%# Eval("DateEnded", "{0: MM/dd/yyyy }") %></td>
                            </tr>
                        </ItemTemplate>
                        <EmptyDataTemplate>
                            <tr>
                                    <td colspan="10"><h2 class="text-center">No Records Found.</h2></td>
                                </tr>
                        </EmptyDataTemplate>
                    </asp:ListView>
                </tbody>
            </table>
    </div>
    <div class="col-lg-12">
         <h2 style="text-align:center">Loan Records</h2>
    <table class="table table-hover">
                <thead>
                    <th>Loan Type</th>
                    <th>Loan Rate</th>
                    <th>Tota lLoan</th>
                    <th># Times Paid</th>
                    <th>Amount Paid</th>
                </thead>
                <tbody>
                    <asp:ListView ID="lvLoanRec" runat="server">
                        <ItemTemplate>
                            <tr>
                                <td> <%# Eval("LoanType") %></td>
                                <td> <%# Eval("LoanRate") %></td>
                                <td> <%# Eval("TotalLoan") %></td>
                                <td> <%# Eval("NoOfTimesPayed") %></td>
                                <td> <%# Eval("AmountPayed") %></td>
                            </tr>
                        </ItemTemplate>
                        <EmptyDataTemplate>
                            <tr>
                                    <td colspan="10"><h2 class="text-center">No Records Found.</h2></td>
                                </tr>
                        </EmptyDataTemplate>
                    </asp:ListView>
                </tbody>
            </table>
    </div>
</asp:Content>


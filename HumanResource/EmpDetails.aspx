<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/HumanResource.master" AutoEventWireup="true" CodeFile="EmpDetails.aspx.cs" Inherits="HumanResource_EmpDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="Server">
    Employee Detailed Information
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="Server">
    <form runat="server">
        <div class="container-fluid">
            <div class="box box-solid">
                <div class="box-header with-border">
                    <i class="fa fa-user-circle"></i>

                    <h3 class="box-title">Details</h3>
                </div>
                <!-- /.box-header -->
                <div class="box-body">
                    <div class="col-lg-6">
                        <label class="control-label col-lg">Name: </label>
                        <asp:Literal ID="ltName" runat="server" />
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
                        <label class="control-label">HDMFno: </label>
                        <asp:Literal ID="ltHDMFno" runat="server" />
                        <br />
                        <label class="control-label">Phone No: </label>
                        <asp:Literal ID="ltPhoneNo" runat="server" />
                        <br />
                        <label class="control-label">Mobile No: </label>
                        <asp:Literal ID="ltMobileNo" runat="server" />
                    </div>
                    <div class="col-lg-6">
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
                <div class="box-footer">
                    <div class="col-lg-12 col-lg-offset-6">
                         <asp:Button ID="btnReg" runat="server" class="btn btn-success"
                        OnClientClick="return confirm('Are you sure you want to make this employee regular?')" Text="Regularize Employee" OnClick="btnReg_Click" Visible="false" />
                    </div>
                   
                </div>
                <!-- /.box-body -->
            </div>
        </div>
    </form>
    <div class="container-fluid">
        <div class="box box-solid">
            <div class="box-header with-border">
                <h3 class="box-title">Employee Records</h3>
            </div>
            <!-- /.box-header -->
            <div class="box-body">
                <div class="box-group" id="accordion">
                    <!-- we are adding the .panel class so bootstrap.js collapse plugin detects it -->
                    <div class="panel box box-primary">
                        <div class="box-header with-border">
                            <h4 class="box-title">
                                <a data-toggle="collapse" data-parent="#accordion" href="#collapseOne" aria-expanded="false" class="collapsed">Loan Records
                                </a>
                            </h4>
                        </div>
                        <div id="collapseOne" class="panel-collapse collapse" aria-expanded="false" style="height: 0px;">
                            <div class="box-body">
                                <h2 style="text-align: center">Loan Records</h2>
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
                                                    <td><%# Eval("LoanType") %></td>
                                                    <td><%# Eval("LoanRate") %></td>
                                                    <td><%# Eval("TotalLoan") %></td>
                                                    <td><%# Eval("NoOfTimesPayed") %></td>
                                                    <td><%# Eval("AmountPayed") %></td>
                                                </tr>
                                            </ItemTemplate>
                                            <EmptyDataTemplate>
                                                <tr>
                                                    <td colspan="10">
                                                        <h2 class="text-center">No Records Found.</h2>
                                                    </td>
                                                </tr>
                                            </EmptyDataTemplate>
                                        </asp:ListView>
                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>
                    <div class="panel box box-danger">
                        <div class="box-header with-border">
                            <h4 class="box-title">
                                <a data-toggle="collapse" data-parent="#accordion" href="#collapseTwo" class="collapsed" aria-expanded="false">Offense Record
                                </a>
                            </h4>
                        </div>
                        <div id="collapseTwo" class="panel-collapse collapse" aria-expanded="false">
                            <div class="box-body">
                                <h2 style="text-align: center">Offense Record</h2>
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
                                                    <td><%# Eval("Event") %></td>
                                                    <td><%# Eval("OffenseNo") %></td>
                                                    <td><%# Eval("DateAdded", "{0: MMMM dd, yyyy}") %></td>
                                                    <td><%# Eval("Days") %></td>
                                                    <td><%# Eval("DateStarted", "{0: MMMM dd, yyyy}") %></td>
                                                    <td><%# Eval("DateEnded", "{0: MMMM dd, yyyy}") %></td>
                                                </tr>
                                            </ItemTemplate>
                                            <EmptyDataTemplate>
                                                <tr>
                                                    <td colspan="10">
                                                        <h2 class="text-center">No Records Found.</h2>
                                                    </td>
                                                </tr>
                                            </EmptyDataTemplate>
                                        </asp:ListView>
                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>
                    <div class="panel box box-success">
                        <div class="box-header with-border">
                            <h4 class="box-title">
                                <a data-toggle="collapse" data-parent="#accordion" href="#collapseThree" class="collapsed" aria-expanded="false">Dependent Record
                                </a>
                            </h4>
                        </div>
                        <div id="collapseThree" class="panel-collapse collapse" aria-expanded="false">
                            <div class="box-body">
                                <h2 style="text-align: center">Dependent Record</h2>
                                <table class="table table-hover">
                                    <thead>
                                        <th>Name</th>
                                        <th>Address</th>
                                        <th>Relationship</th>
                                        <th>Date Added</th>
                                        <th>Age</th>
                                    </thead>
                                    <tbody>
                                        <asp:ListView ID="lvdependents" runat="server">
                                            <ItemTemplate>
                                                <tr>
                                                    <td><%# Eval("Name") %></td>
                                                    <td><%# Eval("Address") %></td>
                                                    <td><%# Eval("Relationship") %></td>
                                                    <td><%# Eval("DateAdded " , "{0: MMMM dd, yyyy}") %></td>
                                                    <td><%# (DateTime.Now.Year - Convert.ToDateTime(Eval("BirthDate")).Year)%></td>
                                                </tr>
                                            </ItemTemplate>
                                            <EmptyDataTemplate>
                                                <tr>
                                                    <td colspan="10">
                                                        <h2 class="text-center">No Records Found.</h2>
                                                    </td>
                                                </tr>
                                            </EmptyDataTemplate>
                                        </asp:ListView>
                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!-- /.box-body -->
        </div>
    </div>
</asp:Content>


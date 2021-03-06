﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/HumanResource.master" AutoEventWireup="true" CodeFile="EmpCreate.aspx.cs" Inherits="HumanResource_EmpCreate" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
    Insert New Employee
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" Runat="Server">
<div class="row">
    <form runat="server" class="form-horizontal">
        <!-- Employee Basic Info --> 
        <div class="col-lg-12">
            <div class="col-lg-6">
                <div class="form-group">
                    <label class="control-label col-lg-4">First Name</label>
                        <div class="col-lg-8">
                            <asp:TextBox ID="txtFirstName" runat="server" class="form-control" required />
                        </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-lg-4">Last Name</label>
                        <div class="col-lg-8">
                            <asp:TextBox ID="txtLastName" runat="server" class="form-control" required />
                        </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-lg-4">Middle Name</label>
                        <div class="col-lg-8">
                            <asp:TextBox ID="txtMiddleName" runat="server" class="form-control" required />
                        </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-lg-4">Birthdate</label>
                        <div class="col-lg-8">
                            <asp:TextBox ID="txtBDate" type="Date" runat="server" class="form-control" required />
                        </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-lg-4">Sex</label>
                        <div class="col-lg-8">
                            <asp:DropDownList ID="ddlSex" runat="server" class="form-control" required >
                                <asp:ListItem Text="Female" ></asp:ListItem>
                                <asp:ListItem Text="Male" ></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-lg-4">SSSno</label>
                        <div class="col-lg-8">
                            <asp:TextBox ID="txtSSS" runat="server" type="number" min="0" class="form-control" required />
                        </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-lg-4">TINno</label>
                        <div class="col-lg-8">
                            <asp:TextBox ID="txtTin" runat="server" type="number" min="0" class="form-control" required />
                        </div>
                </div>
            </div>

            <div class="col-lg-6">
                <div class="form-group">
                    <label class="control-label col-lg-4">HDMFno</label>
                        <div class="col-lg-8">
                            <asp:TextBox ID="txtHDMF" runat="server" type="number" min="0" class="form-control" required />
                        </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-lg-4">PhoneNo</label>
                        <div class="col-lg-8">
                            <asp:TextBox ID="txtPhoneNo" runat="server" class="form-control" required />
                        </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-lg-4">MobileNo</label>
                        <div class="col-lg-8">
                            <asp:TextBox ID="txtMobileNo" runat="server" class="form-control" required />
                        </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-lg-4">CivilStatus</label>
                        <div class="col-lg-8">
                            <asp:DropDownList ID="ddlCivStat" runat="server" class="form-control" required >
                                <asp:ListItem Text="Single" ></asp:ListItem>
                                <asp:ListItem Text="Married" ></asp:ListItem>
                                <asp:ListItem Text="Widow" ></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-lg-4">Position</label>
                        <div class="col-lg-8">
                            <asp:DropDownList ID="ddlPosition" runat="server" class="form-control" required >
                                <asp:ListItem Text="Admin" ></asp:ListItem>
                                <asp:ListItem Text="Department Head" ></asp:ListItem>
                                <asp:ListItem Text="Employee" ></asp:ListItem>
                                <asp:ListItem Text="Human Resource" ></asp:ListItem>
                                <asp:ListItem Text="Payroll Officer" ></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-lg-4">BaseSalary  ₱:</label>
                        <div class="col-lg-8">
                            <asp:TextBox ID="txtBaseSalary" runat="server" type="number" min="5665.875" step="0.001" class="form-control" required />
                            <small>Note: This is Semi-Monthly Salary</small>
                        </div>
                </div>
            </div>
            <div class="col-lg-12">
                <div class="col-lg-6">
                    <h3>Permanent Address</h3>
                    <div class="form-group">
                    <label class="control-label col-lg-4">Street</label>
                        <div class="col-lg-8">
                            <asp:TextBox ID="txtPermStreet" runat="server" class="form-control" required />
                        </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-lg-4">Municipality</label>
                        <div class="col-lg-8">
                            <asp:TextBox ID="txtPermMuni" runat="server" class="form-control" required />
                        </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-lg-4">City</label>
                        <div class="col-lg-8">
                            <asp:TextBox ID="txtPermCity" runat="server" class="form-control" required />
                        </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-lg-4">Zip Code</label>
                        <div class="col-lg-8">
                            <asp:TextBox ID="txtPermZip" runat="server" type="number" min="0" class="form-control" required />
                        </div>
                </div>
                </div>
                <div class="col-lg-6">
                    <h3>Provincial Address</h3>
                    <div class="form-group">
                    <label class="control-label col-lg-4">Street</label>
                        <div class="col-lg-8">
                            <asp:TextBox ID="txtProvStreet" runat="server" class="form-control" required />
                        </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-lg-4">Municipality</label>
                        <div class="col-lg-8">
                            <asp:TextBox ID="txtProvMuni" runat="server" class="form-control" required />
                        </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-lg-4">City</label>
                        <div class="col-lg-8">
                            <asp:TextBox ID="txtProvCity" runat="server" class="form-control" required />
                        </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-lg-4">Zip Code</label>
                        <div class="col-lg-8">
                            <asp:TextBox ID="txtProvZip" runat="server" type="number" min="0" class="form-control" required />
                        </div>
                </div>
                </div>
            </div>
            <asp:Button ID="btnInsertNewEmp" runat="server" class="btn btn-success pull-right" Text="Insert" OnClick="btnInsertNewEmp_Click"/>
        </div>
        </form>
</div>
</asp:Content>


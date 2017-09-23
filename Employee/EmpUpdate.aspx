<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Employee.master" AutoEventWireup="true" CodeFile="EmpUpdate.aspx.cs" Inherits="HumanResource_EmpUpdate" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
    Update Basic Information
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" Runat="Server">
    <form runat="server" class="form-horizontal">
        <div id="updatealert" runat="server" class="alert alert-success col-lg-12" visible="false">
            Details Updated Successfully!
        </div>
        <!-- Employee Basic Info --> 
        <div class="col-lg-12">
            <div class="col-lg-6">
                <div class="form-group">
                    <label class="control-label col-lg-4">First Name</label>
                        <div class="col-lg-8">
                            <asp:TextBox ID="txtFirstName" runat="server" class="form-control" />
                        </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-lg-4">Last Name</label>
                        <div class="col-lg-8">
                            <asp:TextBox ID="txtLastName" runat="server" class="form-control" />
                        </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-lg-4">Middle Name</label>
                        <div class="col-lg-8">
                            <asp:TextBox ID="txtMiddleName" runat="server" class="form-control" />
                        </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-lg-4">Birthdate</label>
                        <div class="col-lg-8">
                            <asp:TextBox ID="txtBDate" type="date" runat="server" class="form-control" />
                        </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-lg-4">Sex</label>
                        <div class="col-lg-8">
                            <asp:TextBox ID="txtSex" runat="server" class="form-control" />
                        </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-lg-4">SSSno</label>
                        <div class="col-lg-8">
                            <asp:TextBox ID="txtSSS" runat="server" type="number" min="0" class="form-control" />
                        </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-lg-4">TINno</label>
                        <div class="col-lg-8">
                            <asp:TextBox ID="txtTin" runat="server" type="number" min="0" class="form-control" />
                        </div>
                </div>
            </div>
            <div class="col-lg-6">
                <div class="form-group">
                    <label class="control-label col-lg-4">BIRno</label>
                        <div class="col-lg-8">
                            <asp:TextBox ID="txtBIR" runat="server" type="number" min="0" class="form-control" />
                        </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-lg-4">HDMFno</label>
                        <div class="col-lg-8">
                            <asp:TextBox ID="txtHDMF" runat="server" type="number" min="0" class="form-control" />
                        </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-lg-4">PhoneNo</label>
                        <div class="col-lg-8">
                            <asp:TextBox ID="txtPhoneNo" runat="server" class="form-control" />
                        </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-lg-4">MobileNo</label>
                        <div class="col-lg-8">
                            <asp:TextBox ID="txtMobileNo" runat="server" class="form-control" />
                        </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-lg-4">CivilStatus</label>
                        <div class="col-lg-8">
                            <asp:TextBox ID="txtCivStat" runat="server" class="form-control" />
                        </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-lg-4">Position</label>
                        <div class="col-lg-8">
                            <asp:TextBox ID="txtPosition" runat="server" class="form-control" />
                        </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-lg-4">BaseSalary</label>
                        <div class="col-lg-8">
                            <asp:TextBox ID="txtBaseSalary" runat="server" type="number" min="0" class="form-control" />
                        </div>
                </div>
            </div>
        </div>
        <!-- Employee Basic INFO END --> 
        <!-- PERMANENT ADDRESS --> 
        <div class="col-lg-12">
            <div class="col-lg-6">
                <h3>Permanent Address</h3>
                <div class="form-group">
                    <label class="control-lable col-lg-4">Street</label>
                    <div class="col-lg-8">
                        <asp:TextBox ID="txtPermStreet" runat="server" class="form-control" />
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-lable col-lg-4">Municipality</label>
                    <div class="col-lg-8">
                        <asp:TextBox ID="txtPermMuni" runat="server" class="form-control" />
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-lable col-lg-4">City</label>
                    <div class="col-lg-8">
                        <asp:TextBox ID="txtPermCity" runat="server" class="form-control" />
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-lable col-lg-4">ZipCode</label>
                    <div class="col-lg-8">
                        <asp:TextBox ID="txtPermZip" runat="server" class="form-control" />
                    </div>
                </div>
            </div>
            <!-- PERMANENT ADDRESS END--> 
            <!-- PROV ADDRESS --> 
            <div class="col-lg-6">
                <h3>Provincial Address</h3>
                <div class="form-group">
                    <label class="control-lable col-lg-4">Street</label>
                    <div class="col-lg-8">
                        <asp:TextBox ID="txtProvStreet" runat="server" class="form-control" />
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-lable col-lg-4">Municipality</label>
                    <div class="col-lg-8">
                        <asp:TextBox ID="txtProvMuni" runat="server" class="form-control" />
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-lable col-lg-4">City</label>
                    <div class="col-lg-8">
                        <asp:TextBox ID="txtProvCity" runat="server" class="form-control" />
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-lable col-lg-4">ZipCode</label>
                    <div class="col-lg-8">
                        <asp:TextBox ID="txtProvZip" runat="server" class="form-control" />
                    </div>
                </div>
            </div>
            <!-- PROV ADDRESS END--> 
             <asp:Button ID="btnUpdateInfo" runat="server" class="btn btn-success pull-right" Text="Update" OnClick="btnUpdateInfo_Click"/>
        </div>
    </form>
</asp:Content>


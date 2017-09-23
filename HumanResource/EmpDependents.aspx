<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/HumanResource.master" AutoEventWireup="true" CodeFile="EmpDependents.aspx.cs" Inherits="HumanResource_EmpDependents" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
    Add Employee Dependents
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" Runat="Server">
    <form runat="server" class="form-horizontal" >
        <div id="updatealert" runat="server" class="alert alert-success col-lg-12" visible="false">
            Details Updated Successfully!
        </div>
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
                    <label class="control-label col-lg-4">Street</label>
                        <div class="col-lg-8">
                            <asp:TextBox ID="txtStreet" runat="server" class="form-control" />
                        </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-lg-4">Municipality</label>
                        <div class="col-lg-8">
                            <asp:TextBox ID="txtMuni" runat="server" class="form-control" />
                        </div>
                </div>
            </div>
            <div class="col-lg-6">
                <div class="form-group">
                    <label class="control-label col-lg-4">City</label>
                        <div class="col-lg-8">
                            <asp:TextBox ID="txtCity" runat="server" class="form-control" />
                        </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-lg-4">Relationship</label>
                        <div class="col-lg-8">
                            <asp:TextBox ID="txtRelation" runat="server" class="form-control" />
                        </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-lg-4">Status</label>
                        <div class="col-lg-8">
                            <asp:DropDownList ID="ddlStatus" runat="server" class="form-control">
                                <asp:ListItem Text="Deceased"></asp:ListItem>
                                <asp:ListItem Text="Alive"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                </div>
                 <asp:Button ID="btnAddDept" runat="server" class="btn btn-success pull-right" Text="Add" OnClick="btnAddDept_Click"/>
            </div>
      </div>
    </form>
</asp:Content>


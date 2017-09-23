<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/HumanResource.master" AutoEventWireup="true" CodeFile="addOvertime.aspx.cs" Inherits="addOvertime" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
    <i class="fa fa-plus"></i>Create Overtime Form Application
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" Runat="Server">
    
    <form id="Form1" class="form-horizontal" runat="server">
       <div class="col-lg-6">

            <div class="form-group">
                <label class="control-label col-lg-4">Date of Overtime:</label>
                <div class="col-lg-8">
                    <asp:TextBox ID="dateTXT" TextMode="Date" class="form-control" runat="server" required ="required"  />
                </div>
            </div>

            <div class="form-group">
                <label class="control-label col-lg-4">Hours:</label>
                <div class="col-lg-8">
                    <asp:TextBox ID="hoursTXT" TextMode="number" class="form-control" runat="server" required ="required" />
                 
                </div>
            </div>

                   
          
            <div class="form-group">
                <label class="control-label col-lg-4">Reason</label>
                <div class="col-lg-8">
                    <asp:TextBox ID="reasonTXT" TextMode="MultiLine" class="form-control" runat="server" required = "required"/>
                    <center>
                        <asp:Button ID="addOvertimeBTN" runat="server" Text="Submit Overtime Form" class="btn btn-success" OnClick="addOvertimeBTN_Click" />
                    </center>
                </div>
            </div>
                    
           </div>
    
    </form>
</asp:Content>


 <%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/PayOfficer.master" AutoEventWireup="true" CodeFile="ViewTaxTable.aspx.cs" Inherits="PayrollOfficer_ViewTaxTable" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="Server">
    View Tax Table
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="Server">
    <div class="container-fluid">
        <div class="col-lg-12">
            <div class="row">
                <div class="box">
                    <div class="box-header with-border">
                        <h3 class="box-title">Tax Transmutation Table&nbsp<i class="fa fa-calculator"></i></h3>
                    </div>
                    <form class="form-horizontal" runat="server">
                        <div class="box-body">
                            <small>Legend: S/ME -  Single/Married</small>
                            <br />
                            <br />
                            <div class="nav-tabs-custom">
                                <ul class="nav nav-tabs">
                                    <li class="active"><a href="#taxZe" data-toggle="tab">Zero Exemption</a></li>
                                    <li><a href="#taxSME" data-toggle="tab">S/ME No Dependents</a></li>
                                    <li><a href="#taxSME1" data-toggle="tab">S/ME 1 Dependent</a></li>
                                    <li><a href="#taxSME2" data-toggle="tab">S/ME 2 Dependents</a></li>
                                    <li><a href="#taxSME3" data-toggle="tab">S/ME 3 Dependents</a></li>
                                    <li><a href="#taxSME4" data-toggle="tab">S/ME 4 Dependents</a></li>
                                </ul>
                                <div class="tab-content">
                                    <div class="tab-pane active" id="taxZe">
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
                                                    <td><asp:TextBox ID="Z1Desc"     CssClass="taxDesc"     runat="server" /></td>
                                                    <td><asp:TextBox ID="Z1Cat"      CssClass="taxCat"      runat="server" /></td>
                                                    <td><asp:TextBox ID="Z1Low"      CssClass="taxLow"      runat="server" /></td>
                                                    <td><asp:TextBox ID="Z1High"     CssClass="taxHigh"     runat="server" /></td>
                                                    <td><asp:TextBox ID="Z1PercOver" CssClass="taxPercOver" runat="server" /></td>
                                                    <td><asp:TextBox ID="Z1Base"     CssClass="taxBase"     runat="server" /></td>
                                                </tr>
                                                <tr>
                                                    <td><asp:TextBox ID="Z2Desc"     CssClass="taxDesc"       runat="server" /></td>
                                                    <td><asp:TextBox ID="Z2Cat"      CssClass="taxCat"        runat="server" /></td>
                                                    <td><asp:TextBox ID="Z2Low"      CssClass="taxLow"        runat="server" /></td>
                                                    <td><asp:TextBox ID="Z2High"     CssClass="taxHigh"       runat="server" /></td>
                                                    <td><asp:TextBox ID="Z2PercOver" CssClass="taxPercOver"   runat="server" /></td>
                                                    <td><asp:TextBox ID="Z2Base"     CssClass="taxBase"       runat="server" /></td>
                                                </tr>
                                                <tr>
                                                    <td><asp:TextBox ID="Z3Desc"     CssClass="taxDesc"       runat="server" /></td>
                                                    <td><asp:TextBox ID="Z3Cat"      CssClass="taxCat"        runat="server" /></td>
                                                    <td><asp:TextBox ID="Z3Low"      CssClass="taxLow"        runat="server" /></td>
                                                    <td><asp:TextBox ID="Z3High"     CssClass="taxHigh"       runat="server" /></td>
                                                    <td><asp:TextBox ID="Z3PercOver" CssClass="taxPercOver"       runat="server" /></td>
                                                    <td><asp:TextBox ID="Z3Base"     CssClass="taxBase"       runat="server" /></td>
                                                </tr>
                                                <tr>
                                                    <td><asp:TextBox ID="Z4Desc"     CssClass="taxDesc"       runat="server" /></td>
                                                    <td><asp:TextBox ID="Z4Cat"      CssClass="taxCat"        runat="server" /></td>
                                                    <td><asp:TextBox ID="Z4Low"      CssClass="taxLow"        runat="server" /></td>
                                                    <td><asp:TextBox ID="Z4High"     CssClass="taxHigh"       runat="server" /></td>
                                                    <td><asp:TextBox ID="Z4PercOver" CssClass="taxPercOver"   runat="server" /></td>
                                                    <td><asp:TextBox ID="Z4Base"     CssClass="taxBase"       runat="server" /></td>
                                                </tr>
                                                <tr>
                                                    <td><asp:TextBox ID="Z5Desc"     CssClass="taxDesc"       runat="server" /></td>
                                                    <td><asp:TextBox ID="Z5Cat"      CssClass="taxCat"        runat="server" /></td>
                                                    <td><asp:TextBox ID="Z5Low"      CssClass="taxLow"        runat="server" /></td>
                                                    <td><asp:TextBox ID="Z5High"     CssClass="taxHigh"       runat="server" /></td>
                                                    <td><asp:TextBox ID="Z5PercOver" CssClass="taxPercOver"   runat="server" /></td>
                                                    <td><asp:TextBox ID="Z5Base"     CssClass="taxBase"       runat="server" /></td>
                                                </tr>
                                                <tr>
                                                    <td><asp:TextBox ID="Z6Desc"     CssClass="taxDesc"       runat="server" /></td>
                                                    <td><asp:TextBox ID="Z6Cat"      CssClass="taxCat"        runat="server" /></td>
                                                    <td><asp:TextBox ID="Z6Low"      CssClass="taxLow"        runat="server" /></td>
                                                    <td><asp:TextBox ID="Z6High"     CssClass="taxHigh"       runat="server" /></td>
                                                    <td><asp:TextBox ID="Z6PercOver" CssClass="taxPercOver"   runat="server" /></td>
                                                    <td><asp:TextBox ID="Z6Base"     CssClass="taxBase"       runat="server" /></td>
                                                </tr>
                                                <tr>
                                                    <td><asp:TextBox ID="Z7Desc"     CssClass="taxDesc"       runat="server" /></td>
                                                    <td><asp:TextBox ID="Z7Cat"      CssClass="taxCat"        runat="server" /></td>
                                                    <td><asp:TextBox ID="Z7Low"      CssClass="taxLow"        runat="server" /></td>
                                                    <td><asp:TextBox ID="Z7High"     CssClass="taxHigh"       runat="server" /></td>
                                                    <td><asp:TextBox ID="Z7PercOver" CssClass="taxPercOver"   runat="server" /></td>
                                                    <td><asp:TextBox ID="Z7Base"     CssClass="taxBase"       runat="server" /></td>
                                                </tr>
                                                <tr>
                                                    <td><asp:TextBox ID="Z8Desc"     CssClass="taxDesc"       runat="server" /></td>
                                                    <td><asp:TextBox ID="Z8Cat"      CssClass="taxCat"        runat="server" /></td>
                                                    <td><asp:TextBox ID="Z8Low"      CssClass="taxLow"        runat="server" /></td>
                                                    <td><asp:TextBox ID="Z8High"     CssClass="taxHigh"       runat="server" /></td>
                                                    <td><asp:TextBox ID="Z8PercOver" CssClass="taxPercOver"   runat="server" /></td>
                                                    <td><asp:TextBox ID="Z8Base"     CssClass="taxBase"       runat="server" /></td>
                                                </tr>

                                            </tbody>
                                        </table>
                                        <asp:Button ID="btnTaxZEup" runat="server" CssClass="btn btn-info" Text="Update" OnClick="btnTaxZEup_Click" />
                                    </div>
                                    <div class="tab-pane" id="taxSME">
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
                                                    <td><asp:TextBox ID="SME1Desc"     CssClass="taxDesc"      runat="server" /></td>
                                                    <td><asp:TextBox ID="SME1Cat"      CssClass="taxCat"       runat="server" /></td>
                                                    <td><asp:TextBox ID="SME1Low"      CssClass="taxLow"       runat="server" /></td>
                                                    <td><asp:TextBox ID="SME1High"     CssClass="taxHigh"         runat="server" /></td>
                                                    <td><asp:TextBox ID="SME1PercOver" CssClass="taxPercOver"      runat="server" /></td>
                                                    <td><asp:TextBox ID="SME1Base"     CssClass="taxBase"         runat="server" /></td>
                                                </tr>
                                                <tr>
                                                    <td><asp:TextBox ID="SME2Desc"     CssClass="taxDesc"     runat="server" /></td>
                                                    <td><asp:TextBox ID="SME2Cat"      CssClass="taxCat"      runat="server" /></td>
                                                    <td><asp:TextBox ID="SME2Low"      CssClass="taxLow"      runat="server" /></td>
                                                    <td><asp:TextBox ID="SME2High"     CssClass="taxHigh"     runat="server" /></td>
                                                    <td><asp:TextBox ID="SME2PercOver" CssClass="taxPercOver" runat="server" /></td>
                                                    <td><asp:TextBox ID="SME2Base"     CssClass="taxBase"     runat="server" /></td>
                                                </tr>
                                                <tr>
                                                    <td><asp:TextBox ID="SME3Desc"     CssClass="taxDesc"     runat="server" /></td>
                                                    <td><asp:TextBox ID="SME3Cat"      CssClass="taxCat"      runat="server" /></td>
                                                    <td><asp:TextBox ID="SME3Low"      CssClass="taxLow"      runat="server" /></td>
                                                    <td><asp:TextBox ID="SME3High"     CssClass="taxHigh"     runat="server" /></td>
                                                    <td><asp:TextBox ID="SME3PercOver" CssClass="taxPercOver" runat="server" /></td>
                                                    <td><asp:TextBox ID="SME3Base"     CssClass="taxBase"     runat="server" /></td>
                                                </tr>
                                                <tr>
                                                    <td><asp:TextBox ID="SME4Desc"     CssClass="taxDesc"     runat="server" /></td>
                                                    <td><asp:TextBox ID="SME4Cat"      CssClass="taxCat"      runat="server" /></td>
                                                    <td><asp:TextBox ID="SME4Low"      CssClass="taxLow"      runat="server" /></td>
                                                    <td><asp:TextBox ID="SME4High"     CssClass="taxHigh"     runat="server" /></td>
                                                    <td><asp:TextBox ID="SME4PercOver" CssClass="taxPercOver" runat="server" /></td>
                                                    <td><asp:TextBox ID="SME4Base"     CssClass="taxBase"     runat="server" /></td>
                                                </tr>
                                                <tr>
                                                    <td><asp:TextBox ID="SME5Desc"     CssClass="taxDesc"     runat="server" /></td>
                                                    <td><asp:TextBox ID="SME5Cat"      CssClass="taxCat"      runat="server" /></td>
                                                    <td><asp:TextBox ID="SME5Low"      CssClass="taxLow"      runat="server" /></td>
                                                    <td><asp:TextBox ID="SME5High"     CssClass="taxHigh"     runat="server" /></td>
                                                    <td><asp:TextBox ID="SME5PercOver" CssClass="taxPercOver" runat="server" /></td>
                                                    <td><asp:TextBox ID="SME5Base"     CssClass="taxBase"     runat="server" /></td>
                                                </tr>
                                                <tr>
                                                    <td><asp:TextBox ID="SME6Desc"     CssClass="taxDesc"     runat="server" /></td>
                                                    <td><asp:TextBox ID="SME6Cat"      CssClass="taxCat"      runat="server" /></td>
                                                    <td><asp:TextBox ID="SME6Low"      CssClass="taxLow"      runat="server" /></td>
                                                    <td><asp:TextBox ID="SME6High"     CssClass="taxHigh"     runat="server" /></td>
                                                    <td><asp:TextBox ID="SME6PercOver" CssClass="taxPercOver" runat="server" /></td>
                                                    <td><asp:TextBox ID="SME6Base"     CssClass="taxBase"     runat="server" /></td>
                                                </tr>
                                                <tr>
                                                    <td><asp:TextBox ID="SME7Desc"     CssClass="taxDesc"     runat="server" /></td>
                                                    <td><asp:TextBox ID="SME7Cat"      CssClass="taxCat"      runat="server" /></td>
                                                    <td><asp:TextBox ID="SME7Low"      CssClass="taxLow"      runat="server" /></td>
                                                    <td><asp:TextBox ID="SME7High"     CssClass="taxHigh"     runat="server" /></td>
                                                    <td><asp:TextBox ID="SME7PercOver" CssClass="taxPercOver" runat="server" /></td>
                                                    <td><asp:TextBox ID="SME7Base"     CssClass="taxBase"     runat="server" /></td>
                                                </tr>
                                                <tr>
                                                    <td><asp:TextBox ID="SME8Desc"     CssClass="taxDesc"     runat="server" /></td>
                                                    <td><asp:TextBox ID="SME8Cat"      CssClass="taxCat"      runat="server" /></td>
                                                    <td><asp:TextBox ID="SME8Low"      CssClass="taxLow"      runat="server" /></td>
                                                    <td><asp:TextBox ID="SME8High"     CssClass="taxHigh"     runat="server" /></td>
                                                    <td><asp:TextBox ID="SME8PercOver" CssClass="taxPercOver" runat="server" /></td>
                                                    <td><asp:TextBox ID="SME8Base"     CssClass="taxBase"     runat="server" /></td>
                                                </tr>
                                            </tbody>
                                        </table>
                                        <asp:Button ID="btnTaxSMEup" runat="server" CssClass="btn btn-info" Text="Update" OnClick="btnTaxSMEup_Click"/>
                                    </div>
                                    <div class="tab-pane" id="taxSME1">
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
                                                    <td><asp:TextBox ID="SME11Desc"       CssClass="taxDesc"      runat="server" /></td>
                                                    <td><asp:TextBox ID="SME11Cat"        CssClass="taxCat"       runat="server" /></td>
                                                    <td><asp:TextBox ID="SME11Low"        CssClass="taxLow"       runat="server" /></td>
                                                    <td><asp:TextBox ID="SME11High"       CssClass="taxHigh"      runat="server" /></td>
                                                    <td><asp:TextBox ID="SME11PercOver"   CssClass="taxPercOver"  runat="server" /></td>
                                                    <td><asp:TextBox ID="SME11Base"       CssClass="taxBase"      runat="server" /></td>
                                                </tr>
                                                <tr>
                                                    <td><asp:TextBox ID="SME12Desc"       CssClass="taxDesc"      runat="server" /></td>
                                                    <td><asp:TextBox ID="SME12Cat"        CssClass="taxCat"       runat="server" /></td>
                                                    <td><asp:TextBox ID="SME12Low"        CssClass="taxLow"       runat="server" /></td>
                                                    <td><asp:TextBox ID="SME12High"       CssClass="taxHigh"      runat="server" /></td>
                                                    <td><asp:TextBox ID="SME12PercOver"   CssClass="taxPercOver"  runat="server" /></td>
                                                    <td><asp:TextBox ID="SME12Base"       CssClass="taxBase"      runat="server" /></td>
                                                </tr>
                                                <tr>
                                                    <td><asp:TextBox ID="SME13Desc"      CssClass="taxDesc"       runat="server" /></td>
                                                    <td><asp:TextBox ID="SME13Cat"       CssClass="taxCat"        runat="server" /></td>
                                                    <td><asp:TextBox ID="SME13Low"       CssClass="taxLow"        runat="server" /></td>
                                                    <td><asp:TextBox ID="SME13High"      CssClass="taxHigh"       runat="server" /></td>
                                                    <td><asp:TextBox ID="SME13PercOver"  CssClass="taxPercOver"   runat="server" /></td>
                                                    <td><asp:TextBox ID="SME13Base"      CssClass="taxBase"       runat="server" /></td>
                                                </tr>
                                                <tr>
                                                    <td><asp:TextBox ID="SME14Desc"      CssClass="taxDesc"       runat="server" /></td>
                                                    <td><asp:TextBox ID="SME14Cat"       CssClass="taxCat"        runat="server" /></td>
                                                    <td><asp:TextBox ID="SME14Low"       CssClass="taxLow"        runat="server" /></td>
                                                    <td><asp:TextBox ID="SME14High"      CssClass="taxHigh"       runat="server" /></td>
                                                    <td><asp:TextBox ID="SME14PercOver"  CssClass="taxPercOver"   runat="server" /></td>
                                                    <td><asp:TextBox ID="SME14Base"      CssClass="taxBase"       runat="server" /></td>
                                                </tr>
                                                <tr>
                                                    <td><asp:TextBox ID="SME15Desc"      CssClass="taxDesc"       runat="server" /></td>
                                                    <td><asp:TextBox ID="SME15Cat"       CssClass="taxCat"        runat="server" /></td>
                                                    <td><asp:TextBox ID="SME15Low"       CssClass="taxLow"        runat="server" /></td>
                                                    <td><asp:TextBox ID="SME15High"      CssClass="taxHigh"       runat="server" /></td>
                                                    <td><asp:TextBox ID="SME15PercOver"  CssClass="taxPercOver"   runat="server" /></td>
                                                    <td><asp:TextBox ID="SME15Base"      CssClass="taxBase"       runat="server" /></td>
                                                </tr>
                                                <tr>
                                                    <td><asp:TextBox ID="SME16Desc"      CssClass="taxDesc"       runat="server" /></td>
                                                    <td><asp:TextBox ID="SME16Cat"       CssClass="taxCat"        runat="server" /></td>
                                                    <td><asp:TextBox ID="SME16Low"       CssClass="taxLow"        runat="server" /></td>
                                                    <td><asp:TextBox ID="SME16High"      CssClass="taxHigh"       runat="server" /></td>
                                                    <td><asp:TextBox ID="SME16PercOver"  CssClass="taxPercOver"   runat="server" /></td>
                                                    <td><asp:TextBox ID="SME16Base"      CssClass="taxBase"       runat="server" /></td>
                                                </tr>
                                                <tr>
                                                    <td><asp:TextBox ID="SME17Desc"      CssClass="taxDesc"       runat="server" /></td>
                                                    <td><asp:TextBox ID="SME17Cat"       CssClass="taxCat"        runat="server" /></td>
                                                    <td><asp:TextBox ID="SME17Low"       CssClass="taxLow"        runat="server" /></td>
                                                    <td><asp:TextBox ID="SME17High"      CssClass="taxHigh"       runat="server" /></td>
                                                    <td><asp:TextBox ID="SME17PercOver"  CssClass="taxPercOver"   runat="server" /></td>
                                                    <td><asp:TextBox ID="SME17Base"      CssClass="taxBase"       runat="server" /></td>
                                                </tr>
                                                <tr>
                                                    <td><asp:TextBox ID="SME18Desc"      CssClass="taxDesc"       runat="server" /></td>
                                                    <td><asp:TextBox ID="SME18Cat"       CssClass="taxCat"        runat="server" /></td>
                                                    <td><asp:TextBox ID="SME18Low"       CssClass="taxLow"        runat="server" /></td>
                                                    <td><asp:TextBox ID="SME18High"      CssClass="taxHigh"       runat="server" /></td>
                                                    <td><asp:TextBox ID="SME18PercOver"  CssClass="taxPercOver"   runat="server" /></td>
                                                    <td><asp:TextBox ID="SME18Base"      CssClass="taxBase"       runat="server" /></td>
                                                </tr>
                                            </tbody>
                                        </table>
                                        <asp:Button ID="btnTaxSME1up" runat="server" CssClass="btn btn-info" Text="Update" OnClick="btnTaxSME1up_Click" />
                                    </div>
                                    <div class="tab-pane" id="taxSME2">
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
                                                    <td><asp:TextBox ID="SME21Desc"      CssClass="taxDesc"       runat="server" /></td>
                                                    <td><asp:TextBox ID="SME21Cat"       CssClass="taxCat"        runat="server" /></td>
                                                    <td><asp:TextBox ID="SME21Low"       CssClass="taxLow"        runat="server" /></td>
                                                    <td><asp:TextBox ID="SME21High"      CssClass="taxHigh"       runat="server" /></td>
                                                    <td><asp:TextBox ID="SME21PercOver"  CssClass="taxPercOver"   runat="server" /></td>
                                                    <td><asp:TextBox ID="SME21Base"      CssClass="taxBase"       runat="server" /></td>
                                                </tr>
                                                <tr>
                                                    <td><asp:TextBox ID="SME22Desc"      CssClass="taxDesc"       runat="server" /></td>
                                                    <td><asp:TextBox ID="SME22Cat"       CssClass="taxCat"        runat="server" /></td>
                                                    <td><asp:TextBox ID="SME22Low"       CssClass="taxLow"        runat="server" /></td>
                                                    <td><asp:TextBox ID="SME22High"      CssClass="taxHigh"       runat="server" /></td>
                                                    <td><asp:TextBox ID="SME22PercOver"  CssClass="taxPercOver"   runat="server" /></td>
                                                    <td><asp:TextBox ID="SME22Base"      CssClass="taxBase"       runat="server" /></td>
                                                </tr>
                                                <tr>
                                                    <td><asp:TextBox ID="SME23Desc"     CssClass="taxDesc"       runat="server" /></td>
                                                    <td><asp:TextBox ID="SME23Cat"      CssClass="taxCat"        runat="server" /></td>
                                                    <td><asp:TextBox ID="SME23Low"      CssClass="taxLow"        runat="server" /></td>
                                                    <td><asp:TextBox ID="SME23High"     CssClass="taxHigh"       runat="server" /></td>
                                                    <td><asp:TextBox ID="SME23PercOver" CssClass="taxPercOver"   runat="server" /></td>
                                                    <td><asp:TextBox ID="SME23Base"     CssClass="taxBase"       runat="server" /></td>
                                                </tr>
                                                <tr>
                                                    <td><asp:TextBox ID="SME24Desc"     CssClass="taxDesc"       runat="server" /></td>
                                                    <td><asp:TextBox ID="SME24Cat"      CssClass="taxCat"        runat="server" /></td>
                                                    <td><asp:TextBox ID="SME24Low"      CssClass="taxLow"        runat="server" /></td>
                                                    <td><asp:TextBox ID="SME24High"     CssClass="taxHigh"       runat="server" /></td>
                                                    <td><asp:TextBox ID="SME24PercOver" CssClass="taxPercOver"   runat="server" /></td>
                                                    <td><asp:TextBox ID="SME24Base"     CssClass="taxBase"       runat="server" /></td>
                                                </tr>
                                                <tr>
                                                    <td><asp:TextBox ID="SME25Desc"      CssClass="taxDesc"       runat="server" /></td>
                                                    <td><asp:TextBox ID="SME25Cat"       CssClass="taxCat"        runat="server" /></td>
                                                    <td><asp:TextBox ID="SME25Low"       CssClass="taxLow"        runat="server" /></td>
                                                    <td><asp:TextBox ID="SME25High"      CssClass="taxHigh"       runat="server" /></td>
                                                    <td><asp:TextBox ID="SME25PercOver"  CssClass="taxPercOver"   runat="server" /></td>
                                                    <td><asp:TextBox ID="SME25Base"      CssClass="taxBase"       runat="server" /></td>
                                                </tr>
                                                <tr>
                                                    <td><asp:TextBox ID="SME26Desc"      CssClass="taxDesc"       runat="server" /></td>
                                                    <td><asp:TextBox ID="SME26Cat"       CssClass="taxCat"        runat="server" /></td>
                                                    <td><asp:TextBox ID="SME26Low"       CssClass="taxLow"        runat="server" /></td>
                                                    <td><asp:TextBox ID="SME26High"      CssClass="taxHigh"       runat="server" /></td>
                                                    <td><asp:TextBox ID="SME26PercOver"  CssClass="taxPercOver"   runat="server" /></td>
                                                    <td><asp:TextBox ID="SME26Base"      CssClass="taxBase"       runat="server" /></td>
                                                </tr>
                                                <tr>
                                                    <td><asp:TextBox ID="SME27Desc"      CssClass="taxDesc"       runat="server" /></td>
                                                    <td><asp:TextBox ID="SME27Cat"       CssClass="taxCat"        runat="server" /></td>
                                                    <td><asp:TextBox ID="SME27Low"       CssClass="taxLow"        runat="server" /></td>
                                                    <td><asp:TextBox ID="SME27High"      CssClass="taxHigh"       runat="server" /></td>
                                                    <td><asp:TextBox ID="SME27PercOver"  CssClass="taxPercOver"   runat="server" /></td>
                                                    <td><asp:TextBox ID="SME27Base"      CssClass="taxBase"       runat="server" /></td>
                                                </tr>
                                                <tr>
                                                    <td><asp:TextBox ID="SME28Desc"      CssClass="taxDesc"       runat="server" /></td>
                                                    <td><asp:TextBox ID="SME28Cat"       CssClass="taxCat"        runat="server" /></td>
                                                    <td><asp:TextBox ID="SME28Low"       CssClass="taxLow"        runat="server" /></td>
                                                    <td><asp:TextBox ID="SME28High"      CssClass="taxHigh"       runat="server" /></td>
                                                    <td><asp:TextBox ID="SME28PercOver"  CssClass="taxPercOver"   runat="server" /></td>
                                                    <td><asp:TextBox ID="SME28Base"      CssClass="taxBase"       runat="server" /></td>
                                                </tr>
                                            </tbody>
                                        </table>
                                        <asp:Button ID="btnTaxSME2up" runat="server" CssClass="btn btn-info" Text="Update" OnClick="btnTaxSME2up_Click"/>
                                    </div>
                                    <div class="tab-pane" id="taxSME3">
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
                                                    <td><asp:TextBox ID="SME31Desc"      CssClass="taxDesc"       runat="server" /></td>
                                                    <td><asp:TextBox ID="SME31Cat"       CssClass="taxCat"        runat="server" /></td>
                                                    <td><asp:TextBox ID="SME31Low"       CssClass="taxLow"        runat="server" /></td>
                                                    <td><asp:TextBox ID="SME31High"      CssClass="taxHigh"       runat="server" /></td>
                                                    <td><asp:TextBox ID="SME31PercOver"  CssClass="taxPercOver"   runat="server" /></td>
                                                    <td><asp:TextBox ID="SME31Base"      CssClass="taxBase"       runat="server" /></td>
                                                </tr>
                                                <tr>
                                                    <td><asp:TextBox ID="SME32Desc"     CssClass="taxDesc"       runat="server" /></td>
                                                    <td><asp:TextBox ID="SME32Cat"      CssClass="taxCat"        runat="server" /></td>
                                                    <td><asp:TextBox ID="SME32Low"      CssClass="taxLow"        runat="server" /></td>
                                                    <td><asp:TextBox ID="SME32High"     CssClass="taxHigh"       runat="server" /></td>
                                                    <td><asp:TextBox ID="SME32PercOver" CssClass="taxPercOver"   runat="server" /></td>
                                                    <td><asp:TextBox ID="SME32Base"     CssClass="taxBase"       runat="server" /></td>
                                                </tr>
                                                <tr>
                                                    <td><asp:TextBox ID="SME33Desc"     CssClass="taxDesc"        runat="server" /></td>
                                                    <td><asp:TextBox ID="SME33Cat"      CssClass="taxCat"         runat="server" /></td>
                                                    <td><asp:TextBox ID="SME33Low"      CssClass="taxLow"         runat="server" /></td>
                                                    <td><asp:TextBox ID="SME33High"     CssClass="taxHigh"        runat="server" /></td>
                                                    <td><asp:TextBox ID="SME33PercOver" CssClass="taxPercOver"    runat="server" /></td>
                                                    <td><asp:TextBox ID="SME33Base"     CssClass="taxBase"        runat="server" /></td>
                                                </tr>
                                                <tr>
                                                    <td><asp:TextBox ID="SME34Desc"     CssClass="taxDesc"        runat="server" /></td>
                                                    <td><asp:TextBox ID="SME34Cat"      CssClass="taxCat"         runat="server" /></td>
                                                    <td><asp:TextBox ID="SME34Low"      CssClass="taxLow"         runat="server" /></td>
                                                    <td><asp:TextBox ID="SME34High"     CssClass="taxHigh"        runat="server" /></td>
                                                    <td><asp:TextBox ID="SME34PercOver" CssClass="taxPercOver"    runat="server" /></td>
                                                    <td><asp:TextBox ID="SME34Base"     CssClass="taxBase"        runat="server" /></td>
                                                </tr>
                                                <tr>
                                                    <td><asp:TextBox ID="SME35Desc"      CssClass="taxDesc"       runat="server" /></td>
                                                    <td><asp:TextBox ID="SME35Cat"       CssClass="taxCat"        runat="server" /></td>
                                                    <td><asp:TextBox ID="SME35Low"       CssClass="taxLow"        runat="server" /></td>
                                                    <td><asp:TextBox ID="SME35High"      CssClass="taxHigh"       runat="server" /></td>
                                                    <td><asp:TextBox ID="SME35PercOver"  CssClass="taxPercOver"   runat="server" /></td>
                                                    <td><asp:TextBox ID="SME35Base"      CssClass="taxBase"       runat="server" /></td>
                                                </tr>
                                                <tr>
                                                    <td><asp:TextBox ID="SME36Desc"      CssClass="taxDesc"       runat="server" /></td>
                                                    <td><asp:TextBox ID="SME36Cat"       CssClass="taxCat"        runat="server" /></td>
                                                    <td><asp:TextBox ID="SME36Low"       CssClass="taxLow"        runat="server" /></td>
                                                    <td><asp:TextBox ID="SME36High"      CssClass="taxHigh"       runat="server" /></td>
                                                    <td><asp:TextBox ID="SME36PercOver"  CssClass="taxPercOver"   runat="server" /></td>
                                                    <td><asp:TextBox ID="SME36Base"      CssClass="taxBase"       runat="server" /></td>
                                                </tr>
                                                <tr>
                                                    <td><asp:TextBox ID="SME37Desc"      CssClass="taxDesc"       runat="server" /></td>
                                                    <td><asp:TextBox ID="SME37Cat"       CssClass="taxCat"        runat="server" /></td>
                                                    <td><asp:TextBox ID="SME37Low"       CssClass="taxLow"        runat="server" /></td>
                                                    <td><asp:TextBox ID="SME37High"      CssClass="taxHigh"       runat="server" /></td>
                                                    <td><asp:TextBox ID="SME37PercOver"  CssClass="taxPercOver"   runat="server" /></td>
                                                    <td><asp:TextBox ID="SME37Base"      CssClass="taxBase"       runat="server" /></td>
                                                </tr>
                                                <tr>
                                                    <td><asp:TextBox ID="SME38Desc"      CssClass="taxDesc"      runat="server" /></td>
                                                    <td><asp:TextBox ID="SME38Cat"       CssClass="taxCat"       runat="server" /></td>
                                                    <td><asp:TextBox ID="SME38Low"       CssClass="taxLow"       runat="server" /></td>
                                                    <td><asp:TextBox ID="SME38High"      CssClass="taxHigh"      runat="server" /></td>
                                                    <td><asp:TextBox ID="SME38PercOver"  CssClass="taxPercOver"  runat="server" /></td>
                                                    <td><asp:TextBox ID="SME38Base"      CssClass="taxBase"      runat="server" /></td>
                                                </tr>
                                            </tbody>
                                        </table>
                                        <asp:Button ID="btnTaxSME3up" runat="server" CssClass="btn btn-info" Text="Update" OnClick="btnTaxSME3up_Click"/>
                                    </div>
                                    <div class="tab-pane" id="taxSME4">
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
                                                    <td><asp:TextBox ID="SME41Desc"     CssClass="taxDesc"       runat="server" /></td>
                                                    <td><asp:TextBox ID="SME41Cat"      CssClass="taxCat"        runat="server" /></td>
                                                    <td><asp:TextBox ID="SME41Low"      CssClass="taxLow"        runat="server" /></td>
                                                    <td><asp:TextBox ID="SME41High"     CssClass="taxHigh"       runat="server" /></td>
                                                    <td><asp:TextBox ID="SME41PercOver" CssClass="taxPercOver"   runat="server" /></td>
                                                    <td><asp:TextBox ID="SME41Base"     CssClass="taxBase"       runat="server" /></td>
                                                </tr>
                                                <tr>
                                                    <td><asp:TextBox ID="SME42Desc"      CssClass="taxDesc"       runat="server" /></td>
                                                    <td><asp:TextBox ID="SME42Cat"       CssClass="taxCat"        runat="server" /></td>
                                                    <td><asp:TextBox ID="SME42Low"       CssClass="taxLow"        runat="server" /></td>
                                                    <td><asp:TextBox ID="SME42High"      CssClass="taxHigh"       runat="server" /></td>
                                                    <td><asp:TextBox ID="SME42PercOver"  CssClass="taxPercOver"   runat="server" /></td>
                                                    <td><asp:TextBox ID="SME42Base"      CssClass="taxBase"       runat="server" /></td>
                                                </tr>
                                                <tr>
                                                    <td><asp:TextBox ID="SME43Desc"      CssClass="taxDesc"       runat="server" /></td>
                                                    <td><asp:TextBox ID="SME43Cat"       CssClass="taxCat"        runat="server" /></td>
                                                    <td><asp:TextBox ID="SME43Low"       CssClass="taxLow"        runat="server" /></td>
                                                    <td><asp:TextBox ID="SME43High"      CssClass="taxHigh"       runat="server" /></td>
                                                    <td><asp:TextBox ID="SME43PercOver"  CssClass="taxPercOver"   runat="server" /></td>
                                                    <td><asp:TextBox ID="SME43Base"      CssClass="taxBase"       runat="server" /></td>
                                                </tr>
                                                <tr>
                                                    <td><asp:TextBox ID="SME44Desc"     CssClass="taxDesc"       runat="server" /></td>
                                                    <td><asp:TextBox ID="SME44Cat"      CssClass="taxCat"        runat="server" /></td>
                                                    <td><asp:TextBox ID="SME44Low"      CssClass="taxLow"        runat="server" /></td>
                                                    <td><asp:TextBox ID="SME44High"     CssClass="taxHigh"       runat="server" /></td>
                                                    <td><asp:TextBox ID="SME44PercOver" CssClass="taxPercOver"   runat="server" /></td>
                                                    <td><asp:TextBox ID="SME44Base"     CssClass="taxBase"       runat="server" /></td>
                                                </tr>
                                                <tr>
                                                    <td><asp:TextBox ID="SME45Desc"     CssClass="taxDesc"       runat="server" /></td>
                                                    <td><asp:TextBox ID="SME45Cat"      CssClass="taxCat"        runat="server" /></td>
                                                    <td><asp:TextBox ID="SME45Low"      CssClass="taxLow"        runat="server" /></td>
                                                    <td><asp:TextBox ID="SME45High"     CssClass="taxHigh"       runat="server" /></td>
                                                    <td><asp:TextBox ID="SME45PercOver" CssClass="taxPercOver"   runat="server" /></td>
                                                    <td><asp:TextBox ID="SME45Base"     CssClass="taxBase"       runat="server" /></td>
                                                </tr>
                                                <tr>
                                                    <td><asp:TextBox ID="SME46Desc"      CssClass="taxDesc"       runat="server" /></td>
                                                    <td><asp:TextBox ID="SME46Cat"       CssClass="taxCat"        runat="server" /></td>
                                                    <td><asp:TextBox ID="SME46Low"       CssClass="taxLow"        runat="server" /></td>
                                                    <td><asp:TextBox ID="SME46High"      CssClass="taxHigh"       runat="server" /></td>
                                                    <td><asp:TextBox ID="SME46PercOver"  CssClass="taxPercOver"   runat="server" /></td>
                                                    <td><asp:TextBox ID="SME46Base"      CssClass="taxBase"       runat="server" /></td>
                                                </tr>
                                                <tr>
                                                    <td><asp:TextBox ID="SME47Desc"      CssClass="taxDesc"       runat="server" /></td>
                                                    <td><asp:TextBox ID="SME47Cat"       CssClass="taxCat"        runat="server" /></td>
                                                    <td><asp:TextBox ID="SME47Low"       CssClass="taxLow"        runat="server" /></td>
                                                    <td><asp:TextBox ID="SME47High"      CssClass="taxHigh"       runat="server" /></td>
                                                    <td><asp:TextBox ID="SME47PercOver"  CssClass="taxPercOver"   runat="server" /></td>
                                                    <td><asp:TextBox ID="SME47Base"      CssClass="taxBase"       runat="server" /></td>
                                                </tr>
                                                 <tr>
                                                    <td><asp:TextBox ID="SME48Desc"      CssClass="taxDesc"       runat="server" /></td>
                                                    <td><asp:TextBox ID="SME48Cat"       CssClass="taxCat"        runat="server" /></td>
                                                    <td><asp:TextBox ID="SME48Low"       CssClass="taxLow"        runat="server" /></td>
                                                    <td><asp:TextBox ID="SME48High"      CssClass="taxHigh"       runat="server" /></td>
                                                    <td><asp:TextBox ID="SME48PercOver"  CssClass="taxPercOver"   runat="server" /></td>
                                                    <td><asp:TextBox ID="SME48Base"      CssClass="taxBase"       runat="server" /></td>
                                                </tr>
                                            </tbody>
                                        </table>
                                        <asp:Button ID="btnTaxSME4up" runat="server" CssClass="btn btn-info" Text="Update" OnClick="btnTaxSME4up_Click"/> 
                                    </div>
                                </div>
                            </div>
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </div>
</asp:Content>


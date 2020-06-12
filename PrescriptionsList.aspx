<%@ Page Title="Herbal Health Solution System" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="PrescriptionsList.aspx.cs" Inherits="PrescriptionsList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContentPlaceHolder" runat="Server">
    <!--content-->
    <div class="product">
        <div class="container">
            <div class="spec ">
                <h3>Prescriptions</h3>
                <div class="ser-t">
                    <b></b>
                    <span><i></i></span>
                    <b class="line"></b>
                </div>
                <div runat="server" id="msg" visible="false">
                    <br />
                    <br />
                    <h4>There is no data in prescriptions.</h4>
                </div>
            </div>
            <div class=" con-w3l agileinf" id="ProductDiv1" runat="server">
                <div class="clearfix"></div>
            </div>
            <div class=" con-w3l agileinf" id="ProductDiv2" runat="server">
                <div class="clearfix"></div>
            </div>
        </div>
    </div>
</asp:Content>
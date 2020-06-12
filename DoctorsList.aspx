<%@ Page Title="Herbal Health Solution System" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="DoctorsList.aspx.cs" Inherits="DoctorsList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContentPlaceHolder" runat="Server">
    <div class="product">
        <div class="container">
            <div class="spec ">
                <h3>Doctors</h3>
                <div class="ser-t">
                    <b></b>
                    <span><i></i></span>
                    <b class="line"></b>
                </div>
                <div runat="server" id="msg" visible="false">
                    <br />
                    <br />
                    <h4>There is no data in doctors.</h4>
                </div>
            </div>
            <div class=" con-w3l agileinf" id="Div1" runat="server">
                <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                <div class="clearfix"></div>
            </div>
            <div class=" con-w3l agileinf" id="ProductDiv" runat="server">
                <div class="clearfix"></div>
            </div>
        </div>
    </div>
    </asp:Content>
    <asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="ProductDiv1" runat="server">
    </div>
</asp:Content>
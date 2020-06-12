<%@ Page Title="Herbal Health Solution System" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContentPlaceHolder" runat="Server">
    <div class="product">
        <div class="container">
            <div class="spec ">
                <h3>Herbs</h3>
                <div class="ser-t">
                    <b></b>
                    <span><i></i></span>
                    <b class="line"></b>
                </div>
                <div runat="server" id="msg1" visible="false">
                    <br />
                    <br />
                    <h4>There is no data in herbs.</h4>
                </div>
            </div>
            <div class=" con-w3l agileinf" id="ProductDiv" runat="server">
                <div class="clearfix"></div>
            </div>
        </div>

        <div class="container">
            <div class="spec ">
                <h3>Tips</h3>
                <div class="ser-t">
                    <b></b>
                    <span><i></i></span>
                    <b class="line"></b>
                </div>
                <div runat="server" id="msg3" visible="false">
                    <br />
                    <br />
                    <h4>There is no data in tips.</h4>
                </div>
            </div>
            <div class="agileinf" id="ProductDiv3" runat="server">
                <div class="clearfix"></div>
            </div>

            <div class=" con-w3l agileinf" id="ProductDiv32" runat="server">
                <div class="clearfix"></div>
            </div>
        </div>

        <div class="container">
            <div class="spec ">
                <h3>Prescription</h3>
                <div class="ser-t">
                    <b></b>
                    <span><i></i></span>
                    <b class="line"></b>
                </div>
                <div runat="server" id="msg2" visible="false">
                    <br />
                    <br />
                    <h4>There is no data in prescriptions.</h4>
                </div>
            </div>
            <div class="agileinf" id="ProductDiv2" runat="server">
                <div class="clearfix"></div>
            </div>

            <div class=" con-w3l agileinf" id="ProductDiv22" runat="server">
                <div class="clearfix"></div>
            </div>
        </div>

    </div>
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="ProductDiv1" runat="server">
    </div>
</asp:Content>
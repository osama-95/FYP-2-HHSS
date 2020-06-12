<%@ Page Title="HHSS | Signin" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Signin.aspx.cs" Inherits="Signin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContentPlaceHolder" runat="Server">
    <script type="text/javascript">
        function HideLabel1() {
            var seconds = 3;
            setTimeout(function () {
                document.getElementById("<%=msg1.ClientID %>").style.display = "none";
            }, seconds * 1000);
        };
        function HideLabel2() {
            var seconds = 3;
            setTimeout(function () {
                document.getElementById("<%=msg2.ClientID %>").style.display = "none";
            }, seconds * 1000);
        };
        function HideLabel3() {
            var seconds = 3;
            setTimeout(function () {
                document.getElementById("<%=msg3.ClientID %>").style.display = "none";
            }, seconds * 1000);
        };
        function HideLabel4() {
            var seconds = 3;
            setTimeout(function () {
                document.getElementById("<%=msg4.ClientID %>").style.display = "none";
            }, seconds * 1000);
        };
    </script>
    <!-- Signin -->
    <style>
        .najaf {
            width: 108%;
        }
    </style>
    <div class="login">
        <div class="main-agileits">
            <div id="msg1" class="alert alert-success" role="alert" runat="server" visible="false">
                <strong>Well done!</strong> Doctor Signup Successfully.
            </div>
            <div id="msg2" class="alert alert-success" role="alert" runat="server" visible="false">
                <strong>Well done!</strong> Patient Signup Successfully.
            </div>
            <div id="msg3" class="alert alert-danger" role="alert" runat="server" visible="false">
                <strong>User Exists!</strong> Doctor Already Exists.
            </div>
            <div id="msg4" class="alert alert-danger" role="alert" runat="server" visible="false">
                <strong>User Exists!</strong> Patient Already Exists.
            </div>
            <div class="form-w3agile">
                <h3>Signin</h3>

                <div class="najaf">
                    <div class="key col-sm-11">
                        <p>Username</p>
                        <i class="fa fa-user" aria-hidden="true"></i>
                        <asp:TextBox ID="TextBox_Username" runat="server" required></asp:TextBox>
                        <div class="clearfix"></div>
                    </div>
                    <div class="clearfix"></div>
                </div>

                
                <div class="najaf">
                    <div class="key col-sm-11">
                        <p>Password</p>
                        <i class="fa fa-lock" aria-hidden="true"></i>
                        <asp:TextBox ID="TextBox_Password" runat="server" TextMode="Password" required></asp:TextBox>
                    </div>
                    <div class="clearfix"></div>
                </div>

                <center>
                    <asp:Button ID="Button1" runat="server" Text="Signin" OnClick="Button1_Click" style="width:100%"/>
                </center>
            </div>
            <div class="forg">
                <%--<a href="#" class="forg-left">Forgot Password</a>--%>
                <a href="Signup.aspx" class="forg-right">Signup</a>
                <div class="clearfix"></div>
            </div>
        </div>
    </div>
    <!-- //Signin -->
</asp:Content>

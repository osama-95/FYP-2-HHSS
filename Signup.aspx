<%@ Page Title="HHSS | Signup Patient" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Signup.aspx.cs" Inherits="Signup" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContentPlaceHolder" runat="Server">
    <script type="text/javascript">
        function HideLabel4() {
            var seconds = 10;
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
            <div id="msg4" class="alert alert-danger" role="alert" runat="server" visible="false">
                <strong>User Exists!</strong> Patient ID Already Exists.
            </div>
            <div class="form-w3agile">
                <h3>Signup as a Patient</h3>
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
                    <div class="key col-sm-5">
                        <p>Password</p>
                        <i class="fa fa-lock" aria-hidden="true"></i>
                        <asp:TextBox ID="TextBox_Password" runat="server" TextMode="Password" required></asp:TextBox>
                    </div>
                    <div class="col-sm-1"></div>
                    <div class="key col-sm-5">
                        <p>Confirm Password</p>
                        <i class="fa fa-lock" aria-hidden="true"></i>
                        <asp:TextBox ID="TextBox_CPassword" runat="server" TextMode="Password" required></asp:TextBox>
                    </div>
                    <div class="clearfix"></div>
                </div>

                <div class="najaf">
                    <div class="key col-sm-5">
                        <p>First Name</p>
                        <i class="fa fa-file-text" aria-hidden="true"></i>
                        <asp:TextBox ID="TextBox_FName" runat="server" required></asp:TextBox>
                    </div>
                    <div class="col-sm-1"></div>
                    <div class="key col-sm-5">
                        <p>Last Name</p>
                        <i class="fa fa-file-text" aria-hidden="true"></i>
                        <asp:TextBox ID="TextBox_LName" runat="server"></asp:TextBox>
                    </div>
                    <div class="clearfix"></div>
                </div>


                <div class="najaf">
                    <div class="key col-sm-5">
                        <p>Contact</p>
                        <i class="fa fa-mobile" aria-hidden="true"></i>
                        <asp:TextBox ID="TextBox_Contact" runat="server" TextMode="Number" MaxLength="11" required></asp:TextBox>
                    </div>
                    <div class="col-sm-1"></div>
                    <div class="key col-sm-5">
                        <p>Email</p>
                        <i class="fa fa-envelope" aria-hidden="true"></i>
                        <asp:TextBox ID="TextBox_Email" runat="server" TextMode="Email"></asp:TextBox>
                    </div>
                    <div class="clearfix"></div>
                </div>

                <div class="najaf">
                    <div class="key col-sm-11">
                        <p>Date Of Birth</p>
                        <i class="fa fa-calendar" aria-hidden="true"></i>
                        <asp:TextBox ID="TextBox_DateOfBirth" runat="server" TextMode="Date"></asp:TextBox>
                    </div>
                    <div class="clearfix"></div>
                </div>
                
                <center>
                    <asp:Button ID="Button1" runat="server" Text="Signup as a Patient" OnClick="Button1_Click" style="width:100%"/>
                </center>
            </div>
            <div class="forg">
                <a href="SignupDoctor.aspx" class="forg-left">Signup as a Doctor</a>
                <a href="Signin.aspx" class="forg-right">Signin</a>
                <div class="clearfix"></div>
            </div>
        </div>
    </div>
    <!-- //Signup -->
</asp:Content>

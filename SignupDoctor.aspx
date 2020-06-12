<%@ Page Title="HHSS | Signup Doctor" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="SignupDoctor.aspx.cs" Inherits="SignupDoctor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContentPlaceHolder" runat="Server">
    <script type="text/javascript">
        function HideLabel3() {
            var seconds = 10;
            setTimeout(function () {
                document.getElementById("<%=msg3.ClientID %>").style.display = "none";
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
            <div id="msg3" class="alert alert-danger" role="alert" runat="server" visible="false">
                <strong>User Exists!</strong> Doctor ID Already Exists.
            </div>
            <div class="form-w3agile">
                <h3>Signup as a Doctor</h3>

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
                    <div class="key col-sm-11">
                        <p>TibbId</p>
                        <i class="fa fa-registered" aria-hidden="true"></i>
                        <asp:TextBox ID="TextBox_TibbId" runat="server" required></asp:TextBox>
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
                        <p>Availability Time From</p>
                        <i class="fa fa-clock-o" aria-hidden="true"></i>
                        <asp:TextBox ID="TextBox_AvailabilityTimeFrom" runat="server" TextMode="Time" required></asp:TextBox>
                    </div>

                    <div class="col-sm-1"></div>
                    <div class="key col-sm-5">
                        <p>Availability Time To</p>
                        <i class="fa fa-clock-o" aria-hidden="true"></i>
                        <asp:TextBox ID="TextBox_AvailabilityTimeTo" runat="server" TextMode="Time" required></asp:TextBox>
                    </div>
                    <div class="clearfix"></div>
                </div>

                <div class="najaf">
                    <div class="key col-sm-11">
                        <p>Availability Days</p>
                        <i class="fa fa-list" aria-hidden="true"></i>
                        <asp:TextBox ID="TextBox_AvailabilityDays" runat="server" required></asp:TextBox>
                    </div>
                    <div class="clearfix"></div>
                </div>

                <div class="najaf">
                    <div class="key col-sm-5">
                        <p>Specialty</p>
                        <i class="fa fa-stethoscope" aria-hidden="true"></i>
                        <asp:TextBox ID="TextBox_Specialty" runat="server" required></asp:TextBox>
                    </div>
                    <div class="col-sm-1"></div>
                    <div class="key col-sm-5">
                        <p>Experience</p>
                        <i class="fa fa-book" aria-hidden="true"></i>
                        <asp:TextBox ID="TextBox_Experience" runat="server" required></asp:TextBox>
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
                        <p>Address</p>
                        <i class="fa fa-map-marker" aria-hidden="true"></i>
                        <asp:TextBox ID="TextBox_Address" runat="server"></asp:TextBox>
                    </div>
                    <div class="clearfix"></div>
                </div>

                <div class="najaf">
                    <div class="key col-sm-5">
                        <p>Picture</p>
                        <i class="fa fa-image" aria-hidden="true"></i>
                        <asp:FileUpload ID="FileUpload1" runat="server" required/>
                    </div>
                    <div class="col-sm-1"></div>
                    <div class="key col-sm-5">
                        <p>Date Of Birth</p>
                        <i class="fa fa-calendar" aria-hidden="true"></i>
                        <asp:TextBox ID="TextBox_DateOfBirth" runat="server" TextMode="Date"></asp:TextBox>
                    </div>
                    <div class="clearfix"></div>
                </div>

                <center>
                    <asp:Button ID="Button1" runat="server" Text="Signup as a Doctor" OnClick="Button1_Click" style="width:100%"/>
                </center>
            </div>
            <div class="forg">
                <a href="Signup.aspx" class="forg-left">Signup as a Patient</a>
                <a href="Signin.aspx" class="forg-right">Signin</a>
                <div class="clearfix"></div>
            </div>
        </div>
    </div>
    <!-- //Signup -->
</asp:Content>

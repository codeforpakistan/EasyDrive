<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <!--start-contact-->
    <div class="contact" id="contact">
        <div class="contact-head">
            <div class="container">
                <h3>Welcome to EasyDrive</h3>
            </div>
        </div>
        <div class="contact-content">
            <div class="container">
                <div class=" col-md-6 address contact-part">
                    <div class="form">
                        <h3>Login</h3>
                        <form method="post" action="#">
                            <input type="text" class="textbox" name="loginmobile" required  placeholder="Mobile">
                            <input type="text" class="textbox" name="loginpassword" required placeholder="Password">
                            <div class="clearfix"></div>
                            <div class="submit">
                                <input type="submit" value="Login" />
                            </div>
                        </form>
                    </div>
                </div>
                <div class="col-md-6 contact-part">
                    <div class="form">
                        <h3>Not a user? Register</h3>
                        <form method="post" action="usersignup.aspx" name="signupform">
                            <input type="text" class="textbox" name="signupname" required placeholder="Name" >
                            <input type="text" class="textbox" name="signupmobile" required placeholder="Mobile">
                            <input type="text" class="textbox" name="signuppassword" required placeholder="Password">
                            <div class="clearfix"></div>
                            <div class="submit">
                                <input type="submit" value="Register" />
                            </div>
                        </form>
                    </div>
                </div>
                <div class="clear"></div>
            </div>
        </div>
    </div>
</asp:Content>


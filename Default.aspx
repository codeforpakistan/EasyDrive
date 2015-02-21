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
                            <input type="text" class="textbox" value="Name" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = 'Name ';}">
                            <input type="text" class="textbox" value="Email Address" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = 'Email Address';}">
                            <input type="text" class="textbox" value="Subject" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = 'Subject';}">
                            <div class="clearfix"></div>
                            <div>
                                <textarea value="Message:" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = 'Your Message ';}">Your Message</textarea>
                            </div>
                            <div class="submit">
                                <input type="submit" value="Login" />
                            </div>
                        </form>
                    </div>
                </div>
                <div class="col-md-6 contact-part">
                    <div class="form">
                        <h3>Not a user? Register</h3>
                        <form method="post" action="#">
                            <input type="text" class="textbox" value="Name" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = 'Name ';}">
                            <input type="text" class="textbox" value="Email Address" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = 'Email Address';}">
                            <input type="text" class="textbox" value="Subject" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = 'Subject';}">
                            <div class="clearfix"></div>
                            <div>
                                <textarea value="Message:" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = 'Your Message ';}">Your Message</textarea>
                            </div>
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


<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="RegisterSchedule.aspx.cs" Inherits="RegisterSchedule" %>

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
                <div class="col-md-12 contact-part">
                    <div class="form">
                        <h3><asp:Literal ID="message" runat="server"></asp:Literal></h3>
                        <form method="post" action="usersignup.aspx" name="verificationform">
                            <input type="text" class="textbox" name="verificationcode" required value="Code" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = ' ';}">
                            <div class="clearfix"></div>
                            <div class="submit">
                                <input type="submit" value="Verify" />
                            </div>
                        </form>
                    </div>
                </div>
                <div class="clear"></div>
            </div>
        </div>
    </div>
</asp:Content>

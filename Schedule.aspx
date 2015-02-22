<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Schedule.aspx.cs" Inherits="Schedule" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <!--start-contact-->
    <div class="contact" id="contact">
        <div class="contact-head">
            <div class="container">
                <h3></h3>
            </div>
        </div>
        <div class="contact-content">
            <div class="container">
                <div class="col-md-12">
                    <h4 class="yellowColor">Days</h4>
                    <input type="checkbox" /><span style="margin-right: 20px"> Sunday</span>
                    <input type="checkbox" /><span style="margin-right: 20px"> Monday</span>
                    <input type="checkbox" /><span style="margin-right: 20px"> Tuesday</span>
                    <input type="checkbox" /><span style="margin-right: 20px"> Wednesday</span>
                    <input type="checkbox" /><span style="margin-right: 20px"> Thursday</span>
                    <input type="checkbox" /><span style="margin-right: 20px"> Friday</span>
                    <input type="checkbox" /><span style="margin-right: 20px"> Saturday</span>
                    <br />
                    <h4 class="yellowColor">Time</h4>
                    <input type="time" value="12:00:00" />
                    <br />
                    <input type="button" class="yellowbutton" value="Subscribe Alert!" style="margin-top: 10px; margin-bottom: 10px">
                </div>
            </div>
            <div class="container">
                <div class="col-md-12" id="map-canvas"></div>
            </div>
            <div class="clear"></div>
        </div>
    </div>
</asp:Content>


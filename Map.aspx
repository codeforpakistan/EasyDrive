<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Map.aspx.cs" Inherits="Map" %>

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
                <div class="col-md-10">
                    <div style="background-color:#444">
                        <h3 class="yellowColor" style="margin-left:10px; padding-top:10px">Label</h3>
                        <br />
                        <div class="col-md-3" style="background-color:#444">
                            <img src="images/pingreen.png" /><span style="color:white"> Clear</span>
                        </div>
                        <div class="col-md-3" style="background-color:#444">
                            <img src="images/pinred.png" /><span style="color:white"> Standstill</span>
                        </div>
                        <div class="col-md-3" style="background-color:#444">
                            <img src="images/pinblue.png" /><span style="color:white"> Accident</span>
                        </div>
                        <div class="col-md-3" style="background-color:#444">
                            <img src="images/pinyellow.png" /><span style="color:white"> Unknown</span>
                        </div>
                    </div>
                    <div style="background-color:#444">
                        <div class="col-md-3" style="background-color:#444; padding-bottom:10px">
                            <img src="images/pingreenpolice.png" /><span style="color:white"> Verified Clear</span>
                        </div>
                        <div class="col-md-3" style="background-color:#444; padding-bottom:10px">
                            <img src="images/pinredpolice.png" /><span style="color:white"> Verified Standstill</span>
                        </div>
                        <div class="col-md-3" style="background-color:#444; padding-bottom:10px">
                            <img src="images/pinbluepolice.png" /><span style="color:white"> Verified Accident</span>
                        </div>
                        <div class="col-md-3" style="background-color:#444; padding-bottom:10px">
                            <img src="images/pinyellowpolice.png" /><span style="color:white"> Verified Unknown</span>
                        </div>
                    </div>
                </div>
                
                <div class="col-md-10">
                    <div id="map-canvas"></div>
                    <div id="appbar" style="display: none">
                        <div class="col-md-6">
                            <input type="hidden" id="lat" />
                            <input type="hidden" id="lng" />
                            <h3 class="yellowColor">Reason</h3>
                            <select id="reason">
                                <option value="1">Clear</option>
                                <option value="2">Accident</option>
                                <option value="3">Standstill</option>
                                <option value="4">Unknown</option>
                                <option value="5">Signal</option>
                            </select>
                            <h3 class="yellowColor">Severity</h3>
                            <select id="severity">
                                <option value="1">Mild</option>
                                <option value="2">Normal</option>
                                <option value="3">Severe</option>
                            </select>
                        </div>
                        <div class="col-md-6 yellowColor">
                            <h3>Description</h3>
                            <input id="description" type="text" class="yellowbutton" />
                            <input type="button" class="yellowbutton" value="Post" style="margin-top: 10px" onclick="postClick(); return false;">
                        </div>
                    </div>
                </div>
                <div class="col-md-2">
                    <div>
                        <a class="twitter-timeline" href="https://twitter.com/IsbRwpTraffic" data-widget-id="569221134743126016">Tweets by @IsbRwpTraffic</a>
                        <script>!function (d, s, id) { var js, fjs = d.getElementsByTagName(s)[0], p = /^http:/.test(d.location) ? 'http' : 'https'; if (!d.getElementById(id)) { js = d.createElement(s); js.id = id; js.src = p + "://platform.twitter.com/widgets.js"; fjs.parentNode.insertBefore(js, fjs); } }(document, "script", "twitter-wjs");</script>
                    </div>
                </div>
                <div class="clear"></div>
            </div>
        </div>
    </div>
</asp:Content>


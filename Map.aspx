<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Map.aspx.cs" Inherits="Map" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <!--start-contact-->
    <div class="contact" id="contact">
        <div class="contact-head">
            <div class="container">
                <h3>EasyDrive</h3>
            </div>
        </div>
        <div class="contact-content">
            <div class="container">
                <div class="col-md-10">
                    <div id="map-canvas"></div>
                </div>
                <div class="col-md-2" id="sidePanel">
                    
                </div>
                <div class="clear"></div>
            </div>
        </div>
    </div>
</asp:Content>


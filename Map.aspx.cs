using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Map : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string inner = InitializeMap("33.693", "73.067");
        inner += CreateMarker("marker", "33.693", "73.067", "Hello World", "1", 1);
        inner += CreateMarker("marker2", "34.693", "73.067", "Hello World", "2", 2);


        inner += TapMap();
        string script = "function initialize() {" + inner + "}google.maps.event.addDomListener(window, 'load', initialize);";

        this.Page.Header.Controls.Add(
            new LiteralControl("<script>" + script + "</script>")); 
    }

    private string InitializeMap(string latitude, string longitude)
    {
        return Environment.NewLine + @"var mapOptions = {
                center: { lat: " + latitude + ", lng: " + longitude + @" },
                zoom: 14
                };
                var map = new google.maps.Map(document.getElementById('map-canvas'),
                    mapOptions);" + Environment.NewLine;
    }

    private string CreateMarker(string markerVariableName, string latitude, string longitude, string messageString, string innerLabel, int type)
    {
        return _InitializeLatlangVariable("latlng" + markerVariableName, latitude, longitude) + _InitializeInfoWindow("infowindow" + markerVariableName, messageString) + _ShowMarker(markerVariableName, "latlng" + markerVariableName, innerLabel, type) + _SetMarkerClick(markerVariableName);
    }

    private string TapMap()
    {
        return Environment.NewLine + @"google.maps.event.addListener(map, 'click', function (e) {
                    var latLng = e.latLng;
                    alert(latLng);
                    document.getElementbyId
                });" + Environment.NewLine;
    }

    private string _InitializeLatlangVariable(string variableName, string Latitude, string Longitude)
    {
        return Environment.NewLine + "var " + variableName + " = new google.maps.LatLng(" + Latitude + ", " + Longitude + ");" + Environment.NewLine;
    }

    private string _InitializeInfoWindow(string variableName, string messageString)
    {
        return Environment.NewLine + "var " + variableName + @" = new google.maps.InfoWindow({
                    content: '" + messageString + @"'
                });" + Environment.NewLine;
    }

    private string _ShowMarker(string variableName, string latLngVariableName, string innerLabel, int type)
    {
        string icon = "images/pinred.png";
        string labelClass = "labelsred";

        if (type == ReasonTypes.Clear)
        {
            icon = "images/pingreen.png";
            labelClass = "labelsgreen";
        }

        return Environment.NewLine + @"var " + variableName + @" = new MarkerWithLabel({
            position: " + latLngVariableName + @",
            map: map,
            labelContent: '" + innerLabel + @"',
            labelAnchor: new google.maps.Point(5, 29),
            icon: '" + icon + @"',
            labelClass: '" + labelClass + @"', // the CSS class for the label
            labelInBackground: false
        });" + Environment.NewLine;
    }

    private string _SetMarkerClick(string markerVariableName)
    {
        return Environment.NewLine + "google.maps.event.addListener(" + markerVariableName + @", 'click', function () {
            infowindow" + markerVariableName + ".open(map, " + markerVariableName + @");
        });" + Environment.NewLine;
    }

    
}
//function initialize() {
//    var mapOptions = {
//        center: { lat: 33.693, lng: 73.067 },
//        zoom: 14
//    };
//    var map = new google.maps.Map(document.getElementById('map-canvas'),
//        mapOptions);

//    var myLatlng = new google.maps.LatLng(33.693, 73.067);

//    var contentString = '<div id="content">' +
//      '<div id="siteNotice">' +
//      '</div>' +
//      '<h1 id="firstHeading" class="firstHeading">Uluru</h1>' +
//      '<div id="bodyContent">' +
//      '<p><b>Uluru</b>, also referred to as <b>Ayers Rock</b>, is a large ' +
//      'sandstone rock formation in the southern part of the ' +
//      'Northern Territory, central Australia. It lies 335&#160;km (208&#160;mi) ' +
//      'south west of the nearest large town, Alice Springs; 450&#160;km ' +
//      '(280&#160;mi) by road. Kata Tjuta and Uluru are the two major ' +
//      'features of the Uluru - Kata Tjuta National Park. Uluru is ' +
//      'sacred to the Pitjantjatjara and Yankunytjatjara, the ' +
//      'Aboriginal people of the area. It has many springs, waterholes, ' +
//      'rock caves and ancient paintings. Uluru is listed as a World ' +
//      'Heritage Site.</p>' +
//      '<p>Attribution: Uluru, <a href="https://en.wikipedia.org/w/index.php?title=Uluru&oldid=297882194">' +
//      'https://en.wikipedia.org/w/index.php?title=Uluru</a> ' +
//      '(last visited June 22, 2009).</p>' +
//      '</div>' +
//      '</div>';

//    var infowindow = new google.maps.InfoWindow({
//        content: contentString
//    });

//    var marker = new MarkerWithLabel({
//        position: myLatlng,
//        map: map,
//        icon: 'images/pingreen.png',
//        labelContent: "A",
//        labelAnchor: new google.maps.Point(5, 29),
//        labelClass: "labelsgreen", // the CSS class for the label
//        labelInBackground: false
//    });


//    google.maps.event.addListener(marker, 'click', function () {
//        infowindow.open(map, marker);
//    });

//    google.maps.event.addListener(map, "click", function (e) {
//        var latLng = e.latLng;
//        alert(latLng);
//        var sidepanel = document.getElementById('sidePanel');
//        sidepanel.innerHTML = "<h3>Clear</h3><br /><h3>Accident</h3><br /><h3>Standstill</h3><br /><h3>Unknown</h3><br /><h3>Signal</h3><br />"
//    });
//}
//google.maps.event.addDomListener(window, 'load', initialize);

function ShowAppbar() {
    document.getElementById("appbar").style.display = 'block';
}

function HideAppbar() {
    document.getElementById("appbar").style.display = 'none';
}

function postClick() {
    HideAppbar();
}
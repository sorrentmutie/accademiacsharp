var miaModale;
window.mostraModale = (idModale) => {
    console.log("Sono nella funzione");
    var d = document.getElementById(idModale);
    miaModale = new bootstrap.Modal(d);
    miaModale.show();
}
window.nascondiModale = () => {
    miaModale.hide();
}

window.chiamaDotNet = () => {
    // var elementi = DotNet.invokeMethod('DemoRazorLibrary', 'RecuperaListastringhe');
    // console.log(elementi);

    DotNet.invokeMethodAsync('DemoRazorLibrary', 'RecuperaListastringheAsync')
        .then(dati => console.log(dati));
}

let map;

window.mostraMappa = (contenitore, zoom, center) => {
    var geocoder = new google.maps.Geocoder();
    geocoder.geocode({ 'address': center }, function (risultati, status) {
//        console.log(risultati);
        if (status === 'OK') {
            var centroMappa = risultati[0].geometry.location;
            var formatted_address = risultati[0].formatted_address;
            map = new google.maps.Map(contenitore, {
                center: centroMappa,
                zoom: zoom,
            });
            const marker = new google.maps.Marker({
                position: centroMappa,
                map: map,
            });
            //const contentString = "<p>Ciao a tutti</p>"
            //const infowindow = new google.maps.InfoWindow({
            //    content: contentString,
            //});
            marker.addListener("click", () => {
                var contenutoHtml =
                    DotNet.invokeMethod('DemoRazorLibrary', 'RecuperaHtmlInfoWindow',
                        formatted_address);
                const infowindow = new google.maps.InfoWindow({
                    content: contenutoHtml,
                });

                infowindow.open({
                    anchor: marker,
                    map,
                    shouldFocus: false,
                });
            });
        }
    });
}
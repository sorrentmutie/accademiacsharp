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
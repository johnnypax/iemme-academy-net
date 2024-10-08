function aggiungi() {

    let datiLocali = localStorage.getItem("casata") !=null ? JSON.parse(localStorage.getItem("casata")) : [];

    let varNome= $("#input-nome").val();
    let varDescrizione= $("#input-descrizione").val();
    let varImmagine = $("#input-immagine").val();       

    //TODO: Verifiche

    let cst = {
        nome: varNome,
        desc: varDescrizione,
        imma: varImmagine,
        codi: "cas-" + Date.now()
    };

    datiLocali.push(cst);
    localStorage.setItem("casata", JSON.stringify(datiLocali));

    
    $("#input-nome").val("");
    $("#input-descrizione").val("");
    $("#input-immagine").val("");

    location.href="index.html"
}

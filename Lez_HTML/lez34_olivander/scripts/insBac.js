function selectCasate(){
    let elencoLocale = localStorage.getItem("casata") != null 
                            ? JSON.parse(localStorage.getItem("casata")) : [];

    let contenitore = "<option>Seleziona la casata</option>";
    for(let [idx, item] of elencoLocale.entries()){
        contenitore += `<option value="${item.codi}">${item.nome}</option>`;
    }
    document.getElementById("select-casata").innerHTML = contenitore;
}

function inserisciBacchetta(){
    let datiLocali = localStorage.getItem("bacchetta") !=null ? JSON.parse(localStorage.getItem("bacchetta")) : [];

    let nome = $("#input-nome").val();
    let mago = $("#input-mago").val();
    let casa = $("#select-casata").val();       

    //TODO: Verifiche

    let bac = {
        nome,
        mago,
        casa
    };

    datiLocali.push(bac);
    localStorage.setItem("bacchetta", JSON.stringify(datiLocali));

    
    $("#input-nome").val("");
    $("#input-descrizione").val("");
    $("#input-immagine").val("");

    location.href="listaBacchetta.html"
}

selectCasate();

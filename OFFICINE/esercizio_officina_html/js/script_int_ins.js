function popolaClienti() {

    $.ajax({
        url: "http://localhost:5270/api/clienti",
        type: "GET",
        success: function (risultato) {
            let contenutoSelect = "";
            for (let [idx, item] of risultato.entries()) {
                contenutoSelect += `<option value="${item.cod}">${item.nom} ${item.cog}</option>`;
            }
            $("#input-clie").html(contenutoSelect);
        },
        error: function (errore) {
            alert("Sono in errore");
            console.log(errore);
        }
    })

}

function salva() {
    let clie = $("#input-clie").val();
    let targ = $("#input-targ").val();
    let mode = $("#input-mode").val();
    let marc = $("#input-marc").val();
    let anno = $("#input-anno").val();
    let prez = $("#input-prez").val();
    let stat = $("#input-stat").val();

    let interv = {
        targa: targ,
        modello: mode,
        marca: marc,
        anno: anno,
        prezzo: prez,
        stato: stat,
        cliRif: {
            cod: clie,
        }
    }

    $.ajax({
        url: "http://localhost:5270/api/interventi",
        type: "POST",
        data: JSON.stringify(interv),
        contentType: "application/json",
        success: function(){
            alert("Inserimento effettuato con successo");
            window.location.href = "/lista_interventi.html";
        },
        error: function (errore) {
            alert("Sono in errore");
            console.log(errore);
        }
    })
}

popolaClienti();

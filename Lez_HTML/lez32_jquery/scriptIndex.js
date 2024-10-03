function stampaTabella(){
    console.log("Invocato Stampa")
    let elencoLocale = localStorage.getItem("scuola") != null 
                            ? JSON.parse(localStorage.getItem("scuola")) : [];

    let contenitore = "";
    for(let [idx, item] of elencoLocale.entries()){
        contenitore += `
            <tr>
                <td>${idx + 1}</td>
                <td>${item.nome}</td>
                <td>${item.cognome}</td>
                <td>${item.matr}</td>
                <td>
                    <button type="button" class="btn btn-danger" onclick="elimina(${idx})">Elimina</button>
                    <button type="button" class="btn btn-warning" onclick="modifica(${idx})">Modifica</button>
                </td>
            </tr>
        `;
    }
    document.getElementById("corpo-tabella").innerHTML = contenitore;
}

function elimina(indice){
    let elencoLocale = localStorage.getItem("scuola") != null 
                            ? JSON.parse(localStorage.getItem("scuola")) : [];

    elencoLocale.splice(indice, 1);

    localStorage.setItem("scuola", JSON.stringify(elencoLocale))
    stampaTabella();
}

function modifica(indice){
    $("#modaleModifica").modal('show');

    let elencoLocale = localStorage.getItem("scuola") != null 
                            ? JSON.parse(localStorage.getItem("scuola")) : [];

    for(let [idx, item] of elencoLocale.entries()){
        if(indice == idx){
            document.getElementById("input-posizione").value = indice;
            $("#input-nome").val(item.nome);                                //Notazione JQuery
            document.getElementById("input-cognome").value = item.cognome;
            document.getElementById("input-matricola").value = item.matr;
        }
    }
}

function salva(){
    let posizione = document.getElementById("input-posizione").value
    let varNome = document.getElementById("input-nome").value;
    let varCogn = document.getElementById("input-cognome").value;
    let varMatr = document.getElementById("input-matricola").value;

    let elencoLocale = localStorage.getItem("scuola") != null 
                            ? JSON.parse(localStorage.getItem("scuola")) : [];

    for(let [idx, item] of elencoLocale.entries()){
        if(idx == posizione){
            item.nome = varNome;
            item.cognome = varCogn;
            item.matr = varMatr;

            localStorage.setItem("scuola", JSON.stringify(elencoLocale));
            stampaTabella();
            $("#modaleModifica").modal('hide');
            return;
        }
    }
}

stampaTabella();

// setInterval(() => {
//     stampaTabella();
// }, 5000);
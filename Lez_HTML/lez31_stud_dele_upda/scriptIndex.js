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

stampaTabella();

// setInterval(() => {
//     stampaTabella();
// }, 5000);
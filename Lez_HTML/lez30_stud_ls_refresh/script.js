function aggiungi(){
    let elencoLocale = localStorage.getItem("scuola") != null 
                            ? JSON.parse(localStorage.getItem("scuola")) : [];
    
    let varNome = document.getElementById("input-nome").value;
    let varCogn = document.getElementById("input-cognome").value;
    let varMatr = document.getElementById("input-matricola").value;

    let stud = {
        nome: varNome,
        cognome: varCogn,
        matr: varMatr
    }

    elencoLocale.push(stud);
    localStorage.setItem("scuola", JSON.stringify(elencoLocale))
    stampaTabella();
}

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
            </tr>
        `;
    }
    document.getElementById("corpo-tabella").innerHTML = contenitore;
}

setInterval(() => {
    stampaTabella();
}, 500);
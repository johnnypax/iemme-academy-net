// let elencoStringa = localStorage.getItem("scuola");
// let elenco = [];

// if(elencoStringa == null){
//     localStorage.setItem("scuola", JSON.stringify(elenco))
// }
// else{
//     elenco = JSON.parse(elencoStringa);
// }

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

stampaTabella();
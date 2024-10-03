let elenco = [
    {
        nome: "Giovanni",
        cognome: "Pace",
        matr: 1234
    },
    {
        nome: "Valeria",
        cognome: "Verdi",
        matr: 1235
    },
    {
        nome: "Mario",
        cognome: "Rossi",
        matr: 1236
    },
]

function aggiungi(){
    let varNome = document.getElementById("input-nome").value;
    let varCogn = document.getElementById("input-cognome").value;
    let varMatr = document.getElementById("input-matricola").value;

    let stud = {
        nome: varNome,
        cognome: varCogn,
        matr: varMatr
    }

    elenco.push(stud);
    stampaTabella();
}

function stampaTabella(){
    let contenitore = "";
    for(let [idx, item] of elenco.entries()){
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
let contenuto = "";
let contatore = 0;

function salva(){

    let varNom = document.getElementById("input-nome").value;
    let varCog = document.getElementById("input-cogn").value;
    let varTel = document.getElementById("input-tele").value;
    let varEma = document.getElementById("input-emai").value;

    contenuto += `
        <tr>
            <td>${contatore + 1}</td>
            <td>${varNom}</td>
            <td>${varCog}</td>
            <td>${varTel}</td>
            <td>${varEma}</td>
        </tr>
    `; 

    document.getElementById("corpo-tabella").innerHTML = contenuto;  
    contatore++;

    //Pulisce il form
    document.getElementById("input-nome").value = "";
    document.getElementById("input-cogn").value = "";
    document.getElementById("input-tele").value = "";
    document.getElementById("input-emai").value = "";
}
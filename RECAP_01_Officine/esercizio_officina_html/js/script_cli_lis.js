function stampaTabella(){
    $.ajax(
        {
            url: "http://localhost:5270/api/clienti",
            type: "GET",
            success: function(risultato){
                let contenuto = "";
                for(let [idx, item] of risultato.entries()){
                    // console.log(item)
                    contenuto += `
                        <tr>
                            <td>${item.nom}</td>
                            <td>${item.cog}</td>
                            <td>${item.ind}</td>
                            <td>${item.tel}</td>
                            <td>${item.ema}</td>
                            <td>
                                <button type="button" class="btn btn-danger" 
                                    onclick="elimina('${item.cod}')">Elimina</button>
                                <button type="button" class="btn btn-warning" 
                                    onclick="modifica('${item.cod}')">Modifica</button>
                            </td>
                        </tr>
                    `;
                }

                $("#contenuto-tabella").html(contenuto)
            },
            error: function(errore){
                console.log(errore);
                alert("Sono in errore");
            },
        }
    );
}

function elimina(varCodice){
    $.ajax({
        url: `http://localhost:5270/api/clienti/${varCodice}`,
        type: "DELETE",
        success: function(){
            alert("Operazione effettuata con successo");
            stampaTabella();
        },
        error: function(errore){
            console.log(errore);
            alert("Sono in errore");
        },
    })
}

function modifica(varCodice){

    $.ajax({
        url: `http://localhost:5270/api/clienti/${varCodice}`,
        type: "GET",
        success: function(risultato){

            $("#update-nome").val(risultato.nom);
            $("#update-cogn").val(risultato.cog);
            $("#update-indi").val(risultato.ind);
            $("#update-tele").val(risultato.tel);
            $("#update-emai").val(risultato.ema);

            $("#puls-salva").data("codice", varCodice);

            $("#modaleAggiornamento").modal("show");
        },
        error: function(errore){
            console.log(errore);
            alert("Sono in errore");
        },
    })

}

function effettuaModifica(btnSalva){
    let cod = $(btnSalva).data("codice")

    let nom = $("#update-nome").val();
    let cog = $("#update-cogn").val();
    let ind = $("#update-indi").val();
    let tel = $("#update-tele").val();
    let ema = $("#update-emai").val();

    if (nom.trim() == "") {
        alert("Attenzione, il campo Nome non può essere vuoto");
        $("#input-nome").focus();
        return;
    }

    if (cog.trim() == "") {
        alert("Attenzione, il campo Cognome non può essere vuoto");
        $("#input-cogn").focus();
        return;
    }

    let cli = {
        nom,
        cog,
        ind,
        tel,
        ema
    };

    $.ajax({
        url: `http://localhost:5270/api/clienti/${cod}`,
        type: "PUT",
        data: JSON.stringify(cli),
        contentType: "application/json",
        success: function(){
            alert("Modifica effettuata con successo");
            stampaTabella();

            $("#modaleAggiornamento").modal("hide");
        },
        error: function(errore){
            console.log(errore);
            alert("Sono in errore");
        },
    })
}

stampaTabella();
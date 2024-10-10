function stampaTabella(){
    $.ajax(
        {
            url: "http://localhost:5015/api/videoteche",
            type: "GET",
            success: function(risultato){

                let contenuto = "";
                for(let [idx, item] of risultato.entries()){
                    contenuto += `
                        <tr>
                            <td>${item.nom}</td>
                            <td>${item.ind}</td>
                            <td>
                                <button type="button" class="btn btn-danger" onclick="elimina('${item.cod}')">X</button>
                            </td>
                        </tr>
                    `;
                }

                $("#contenuto-tabella").html(contenuto);

            },
            error: function(errore){
                alert("Sto in errore");
                console.log(errore)
            }
        }
    );
}

function elimina(varCod){
    $.ajax(
        {
            url: "http://localhost:5015/api/videoteche/" + varCod,
            type: "DELETE",
            success: function(){
                alert("STAPPPOOOOOOOOOOO");
                stampaTabella();
            },
            error: function(errore){
                alert("Sto in errore");
                console.log(errore)
            }
        }
    );
}

function salva(){

    let varNome = $("#ins-nome").val();
    let varIndi = $("#ins-indi").val();

    if(varNome.trim() == ""){
        alert("Attenzione, nome vuoto");
        $("#ins-nome").focus();
        return;
    }
    
    if(varIndi.trim() == ""){
        alert("Attenzione, indirizzo vuoto");
        $("#ins-indi").focus();
        return;
    }

    $.ajax({
        url: "http://localhost:5015/api/videoteche",
        type: "POST",
        data: JSON.stringify(
            {
                nom: varNome,
                ind: varIndi
            }
        ),
        contentType: "application/json",
        // dataType: "json",
        success: function(){
            alert("STAPPPOOOOOOOOOOO");
            stampaTabella();
        },
        error: function(errore){
            alert("Sto in errore");
            console.log(errore)
        },
        complete: function(){
            // alert("Ho finito");
        }

    })
}

stampaTabella();
function popolaSelect(){
    $.ajax({
        url: "http://localhost:5270/api/clienti",
        type: "GET",
        success: function(risultato){
            let contenuto = "";

            risultato.forEach(element => {
                contenuto += `<option value="${element.cod}">${element.nom}</option>`;
            });

            $("#input-clie").html(contenuto)
        },
        error: function(errore){
            alert("Sono in errore");
            console.log(errore)
        }
    })
}

function salva(){
    let var_cli = $("#input-clie").val();
    let var_tar = $("#input-targ").val();
    let var_mod = $("#input-mode").val();
    let var_mar = $("#input-marc").val();
    let var_ann = $("#input-anno").val();
    let var_pre = $("#input-prez").val();
    let var_sta = $("#input-stat").val();

    let intervento = {
        tar: var_tar,
        mod: var_mod,
        mar: var_mar,
        ann: var_ann,
        pre: var_pre,
        sta: var_sta,
        cli: {
            cod: var_cli
        }
    };

    $.ajax(
        {
            url: "http://localhost:5270/api/interventi",
            type: "POST",
            data: JSON.stringify(intervento),
            contentType: "application/json",
            success: function(){
                alert("Inserimento effettuato con successo");
                window.location.href = "index.html"
            },
            error: function(errore){
                alert("Errore di inserimento");
                console.log(errore);
            }
        }
    );
}

popolaSelect();
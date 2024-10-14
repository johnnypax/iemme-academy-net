function salva() {

    let nom = $("#input-nome").val();
    let cog = $("#input-cogn").val();
    let ind = $("#input-indi").val();
    let tel = $("#input-tele").val();
    let ema = $("#input-emai").val();

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


    $.ajax(
        {
            url: "http://localhost:5270/api/clienti",
            type: "POST",
            data: JSON.stringify(cli),
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
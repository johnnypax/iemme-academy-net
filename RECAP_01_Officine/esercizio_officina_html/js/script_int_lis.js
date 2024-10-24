function stampaTabella(){
    $.ajax({
        url: "http://localhost:5270/api/interventi",
        type: "GET",
        success: function(risultato){
            let contenuto = "";
            for(let [idx, item] of risultato.entries()){
                contenuto += `
                    <tr>
                        <td>${item.targa}</td>
                        <td>${item.modello}</td>
                        <td>${item.marca}</td>
                        <td>${item.anno}</td>
                        <td>${item.prezzo}</td>
                        <td>${item.stato}</td>
                        <td>${item.dataIngresso}</td>
                        <td>${item.cliRif.nom} ${item.cliRif.cog}</td>
                    </tr>
                `;
            }

            $("#contenuto-tabella").html(contenuto);
        },
        error: function(errore){
            alert("Sono in errore");
            console.log(errore);
        }
    })
}

stampaTabella();
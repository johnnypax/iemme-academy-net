function stampaTabella(){
    $.ajax(
        {
            url: "http://localhost:5015/api/videoteche",
            type: "GET",
            success: function(data){
                let contenuto = "";

                for(let [idx, item] of data.entries()){
                    contenuto += `
                        <tr>
                            <td>${item.nom}</td>
                            <td>${item.ind}</td>
                        </tr>
                    `
                }

                document.getElementById("contenuto-tabella").innerHTML = contenuto;
            },
            error: function(errore){
                console.log(errore)

            }
        }
    );
}

stampaTabella();
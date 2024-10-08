function stampaTabella(){
    let elencoLocale = localStorage.getItem("casata") != null 
                            ? JSON.parse(localStorage.getItem("casata")) : [];

    let contenitore = "";
    for(let [idx, item] of elencoLocale.entries()){
        contenitore += `
            <tr>
                <td>${item.nome}</td>
                <td>${item.desc}</td>
                <td>
                    <img src="${item.imma}" />
                </td>
                <td>${calcola(item.codi)}</td>
                <td>
                    <button type="button" class="btn btn-danger" onclick="elimina('${item.codi}')">
                        <i class="fa fa-trash"></i>
                    </button>
                </td>
            </tr>
        `;
    }
    document.getElementById("casate-tabella").innerHTML = contenitore;
}

function calcola(varCodCasa){

    let elencoBacc = localStorage.getItem("bacchetta") != null 
                            ? JSON.parse(localStorage.getItem("bacchetta")) : [];

    let contatore = 0;
    for(let [idx, bac] of elencoBacc.entries()){     
        if(bac.casa == varCodCasa){
            contatore++;
        }
    }         
    return contatore;
}

setInterval(() => {
    stampaTabella();
}, 1000);


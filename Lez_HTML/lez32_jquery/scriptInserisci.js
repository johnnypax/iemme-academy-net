function aggiungi(){
    let elencoLocale = localStorage.getItem("scuola") != null 
                            ? JSON.parse(localStorage.getItem("scuola")) : [];
    
    let varNome = $("#input-nome").val();                               //JQUERY
    let varCogn = document.getElementById("input-cognome").value;
    let varMatr = document.getElementById("input-matricola").value;

    let stud = {
        nome: varNome,
        cognome: varCogn,
        matr: varMatr
    }

    elencoLocale.push(stud);
    localStorage.setItem("scuola", JSON.stringify(elencoLocale))
    
    location.href = "index.html"
}
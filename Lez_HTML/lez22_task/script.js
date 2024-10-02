// function verifica(){
//     debugger;
//     let temp = document.getElementById("in-temp").value;

//     if(isNaN(temp) || temp.trim() == ""){
//         document.getElementById("risultato").innerHTML = `
//             <div class="alert alert-danger mt-3" role="alert">
//                 Caratteri testuali non ammessi
//             </div>`;
//         return;
//     }
       
//     if(temp < 34 || temp > 42){
//         document.getElementById("risultato").innerHTML = `
//             <div class="alert alert-danger mt-3" role="alert">
//                 Fuori dal range
//             </div>`;
//         return;
//     }

//     if(temp >= 37.5){
//         document.getElementById("risultato").innerHTML = `
//             <div class="alert alert-danger mt-3" role="alert">
//                 Tu non puoi passare!
//             </div>`;
//     }
//     else{
//         document.getElementById("risultato").innerHTML = `
//             <div class="alert alert-success mt-3" role="alert">
//                 Benvenuto
//             </div>`;
//     }
// }

function verifica(){
    debugger;
    let temp = document.getElementById("in-temp").value;
    let stringa = "";
    let colore = "danger";
    let errore = false;

    if(isNaN(temp) || temp.trim() == ""){
        stringa = "Caratteri testuali non ammessi";
        errore = true;
    }
       
    if(temp < 34 || temp > 42){
        stringa = "Fuori dal range";
        errore = true;
    }

    if(errore == false){
        if(temp >= 37.5){
            stringa = "Tu non puoi passare!";
        }
        else{
            stringa = "Benvenuto";
            colore = "success";
        }
    }    

    document.getElementById("risultato").innerHTML = `
            <div class="alert alert-${colore} mt-3" role="alert">${stringa}</div>`;
}
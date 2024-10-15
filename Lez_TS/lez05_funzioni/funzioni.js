// function saluta(nome: string, eta: number) : string{
//     return `Ciao, ${nome} ${eta}`
// }
// console.log( saluta("Giovanni", 37) );
// // ------------------------------------------------ ARROW
// const salutaDue = (nome: string) : string => {
//     return `Ciao, ${nome}`
// }
// console.log( salutaDue("Valeria") );
// --------------------------------------------------- OPZIONALI
var ringrazia = function (nome, titolo) {
    if (titolo)
        return "Grazie ".concat(titolo, " ").concat(nome);
    return "Grazie ".concat(nome);
};
console.log(ringrazia("Valeria", "Ing."));
console.log(ringrazia("Marika"));

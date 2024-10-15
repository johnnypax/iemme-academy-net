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

const ringrazia = (nome: string, titolo?: string) : string => {
    if(titolo)
        return `Grazie ${titolo} ${nome}`

    return `Grazie ${nome}`
}

console.log( ringrazia("Valeria", "Ing.") )
console.log( ringrazia("Marika") )
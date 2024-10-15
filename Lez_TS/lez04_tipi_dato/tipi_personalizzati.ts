type Persona = {
    nominativo: string,
    eta: number
}

// // let gio : Persona = {
// //     nominativo: "Giovanni",
// //     eta: 37
// // }

function getPersona() : Persona {
    return {
        nominativo: "Giovani",
        eta: 37
    }
}

//------------------------------------------------------------

interface Animale{
    nome: string,
    specie: string
}

function getAnimale() : Animale{
    return {
        nome: "Bu",
        specie: "Testadigatto"
    }
}
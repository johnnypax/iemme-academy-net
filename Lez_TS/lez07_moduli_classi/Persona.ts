export default class Persona{
    nome: string | undefined;
    cognome: string | undefined;

    constructor(nome: string, cognome: string){
        this.nome = nome;
        this.cognome = cognome
    }

    saluta() : void {
        console.log(`Ciao ${this.nome} ${this.cognome}`);
        
    }
}
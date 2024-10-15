import Rivista from "./Rivista";

export default class Edicola{
    private indirizzo: string | undefined;
    private elenco: Rivista[] = new Array();

    constructor(indirizzo: string){
        this.indirizzo = indirizzo;
    }

    addRivista(riv: Rivista) : void {
        this.elenco.push(riv);
    }

    stampaRiviste(): void{
        console.log(`Edicola: ${this.indirizzo}`)

        this.elenco.forEach(element => {
            element.stampaDettaglio()
        });
    }
}
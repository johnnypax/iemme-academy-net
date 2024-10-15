export default class Rivista{
    private codice: string | undefined;
    private titolo: string | undefined;

    constructor(codice?: string, titolo?: string){
        this.codice = codice;
        this.titolo = titolo;
    }

    stampaDettaglio() : void {
        console.log(`Rivista: ${this.codice} ${this.titolo}`)
    }
}
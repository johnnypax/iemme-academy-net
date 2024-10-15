import Camera from "./Camera";

export default class Albergo{
    private indirizzo: string | undefined;
    private elenco: Camera[] | undefined;

    constructor(indirizzo: string){
        this.indirizzo = indirizzo;
    }

    aggiungiCamera(cam: Camera) : void{
        if(!this.elenco)
            this.elenco = new Array()

        this.elenco.push(cam);
    }

    stampaAlbergo(): void {
        console.log(`Albergo: ${this.indirizzo}`);

        if(this.elenco)
            this.elenco.forEach(element => {
                element.dettaglioCamera();
            });
    }
}
export class Prodotto {
    cod: string | undefined;
    nom: string | undefined;
    des: string | undefined;
    qua: number | undefined;
    pre: number | undefined;

    StampaDettaglio() : void{
        console.log(this.cod, this.nom, this.des, this.qua, this.pre);
    }
}

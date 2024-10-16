export class Prodotto {
    nom: string | undefined;
    des: string | undefined;
    pre: number | undefined;

    constructor(nom?: string, des?: string, pre?: number){
        this.nom = nom;
        this.des = des;
        this.pre = pre;
    }
}

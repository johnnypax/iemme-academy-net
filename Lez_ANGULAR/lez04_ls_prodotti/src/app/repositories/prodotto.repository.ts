import { Injectable } from "@angular/core";
import { Prodotto } from "../models/prodotto";

@Injectable({
    providedIn: 'root'
})
export class ProdottoRepository {

    private elenco: Prodotto[] =  [];

    constructor() {

        if(!localStorage.getItem("negozio"))
            localStorage.setItem("negozio", JSON.stringify([]))

        let stringaLs: string | null = localStorage.getItem("negozio");
        if(stringaLs !== null){
            this.elenco = JSON.parse(stringaLs);
        }
    }

    Create(p: Prodotto): boolean{
        this.elenco.push(p);
        localStorage.setItem("negozio", JSON.stringify(this.elenco))
        
        return true;
    }

    GetAll(): Prodotto[] {
        return this.elenco;
    }

    /**
     * Funzione per l'eliminazine dal local storage di un elemento
     * @param varCod codice univoco dell'elemento sotto forma di UUID
     * @returns risultato booleano dell'eliminazione: true | false
     */
    Delete(varCod: string): boolean{
        let risultato: boolean = true;

        for(let [idx, item] of this.elenco.entries()){
            if(item.cod === varCod){
                this.elenco.splice(idx, 1);
                risultato = true;
                localStorage.setItem("negozio", JSON.stringify(this.elenco))
            }
        }

        return risultato;
    }

    GetById(varCod: string): Prodotto | null{
        let risultato: Prodotto | null = null;

        for(let [idx, item] of this.elenco.entries()){
            if(item.cod === varCod){
                risultato = item;
            }
        }

        return risultato;
    }
}
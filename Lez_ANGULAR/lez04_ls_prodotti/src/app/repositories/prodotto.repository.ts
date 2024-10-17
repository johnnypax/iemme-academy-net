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
}
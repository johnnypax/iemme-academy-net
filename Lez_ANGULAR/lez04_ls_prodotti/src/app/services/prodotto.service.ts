import { Injectable } from '@angular/core';
import { Prodotto } from '../models/prodotto';

@Injectable({
  providedIn: 'root'
})
export class ProdottoService {

  constructor() { }

  InserisciProd(prod: Prodotto){
    prod.cod = "AB1234";  //TODO: Assegnamo codice...

    //Todo: chiama la Repo...
  }
}

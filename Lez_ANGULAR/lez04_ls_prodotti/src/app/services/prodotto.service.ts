import { Injectable } from '@angular/core';
import { Prodotto } from '../models/prodotto';
import { v4 as uuidv4 } from 'uuid';
import { ProdottoRepository } from '../repositories/prodotto.repository';

@Injectable({
  providedIn: 'root'
})
export class ProdottoService {

  constructor(private repo: ProdottoRepository) { }

  InserisciProd(prod: Prodotto): boolean{
    prod.cod = uuidv4();

    return this.repo.Create(prod);
  }

  ListaProdotti(): Prodotto[]{
    return this.repo.GetAll();
  }
}

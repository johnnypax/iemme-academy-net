import { Injectable } from '@angular/core';
import { Corso } from '../models/corso';

@Injectable({
  providedIn: 'root'
})
export class CorsoService {

  constructor() { }

  async Lista():  Promise<Corso[]> {
    let risultato : Corso[] = await ((await fetch("http://localhost:5292/api/corso")).json());

    return risultato;
  }
}

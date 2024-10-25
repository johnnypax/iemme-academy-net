import { Injectable } from '@angular/core';
import { Iscrizione } from '../models/iscrizione';

@Injectable({
  providedIn: 'root'
})
export class IscrizioneService {

  constructor() { }

  async Inserisci(iscri: Iscrizione): Promise<string | null> {
    let risultato = await (await fetch("http://localhost:5292/api/iscrizione",
      {
        headers: {
          "Content-Type": "application/json"
        },
        method: "POST",
        body: JSON.stringify(iscri)
      }
    )).json();
    
    if(risultato.codiceDisiscrizione)
      return risultato.codiceDisiscrizione;

    return null;
  }
}

import { Injectable } from '@angular/core';
import { Risposta } from '../models/risposta';

@Injectable({
  providedIn: 'root'
})
export class ProfiloService {

  constructor() { }

  async CaricaProfilo() : Promise<Risposta | null>{
    let valoreToken = localStorage.getItem("ilToken");

    if(valoreToken){
      let risultato = await(await fetch("http://localhost:5031/api/User/profilo", {
        headers: {
          "Content-Type": "application/json",
          "Authorization": "Bearer " + valoreToken
        },
        method: "GET"
      })).json();

      return risultato;
    }
    else{
      return null;
    }
  }
}

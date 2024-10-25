import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { TokenRisposta } from '../models/token-risposta';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  constructor(private http: HttpClient) { }

  async EffettuaLogin(username: string, password: string): Promise<TokenRisposta> {
    let invio: any = {
      username,
      password
    }

    let risultato = await(await fetch("http://localhost:5031/api/Auth/login", {
      headers: {
        "Content-Type": "application/json"
      },
      method: "POST",
      body: JSON.stringify(invio)
    })).json();

    return risultato;
  }


  // EffettuaLogin(username: string, password: string): Observable<TokenRisposta>{
  //   let customHeaders = new HttpHeaders();
  //   customHeaders.set("Content-Type", "application/json");

  //   let invio : any = {
  //     username,
  //     password
  //   }

  //   return this.http.post<any>("http://localhost:5031/api/Auth/login", invio, { headers: customHeaders})
  // }
}

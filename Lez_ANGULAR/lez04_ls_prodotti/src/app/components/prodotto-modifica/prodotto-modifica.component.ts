import { Component } from '@angular/core';
import { ActivatedRoute, Route, Router } from '@angular/router';
import { ProdottoService } from '../../services/prodotto.service';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { Prodotto } from '../../models/prodotto';

@Component({
  selector: 'app-prodotto-modifica',
  standalone: true,
  imports: [FormsModule, CommonModule],
  templateUrl: './prodotto-modifica.component.html',
  styleUrl: './prodotto-modifica.component.css'
})
export class ProdottoModificaComponent {

  codice: string | undefined;
  nome: string | undefined;
  descrizione: string | undefined;
  quantita: number | undefined;
  prezzo: number | undefined;

  errore: boolean = false;
  successo: boolean = false;

  constructor(
    private rottaAttiva: ActivatedRoute, 
    private service: ProdottoService,
    private router: Router){
    
  }

  ngOnInit(){
    this.rottaAttiva.params.subscribe( (risultato) => {
      this.codice = risultato['codice'];
      if(this.codice && this.codice.trim() !== ""){
        
        let prod = this.service.DettaglioProdotto(this.codice);
        if(prod !== null){
  
          this.nome = prod.nom;
          this.descrizione = prod.des;
          this.quantita = prod.qua;
          this.prezzo = prod.pre;
  
        }
      }
    })
  }

  salva(){

    if(!this.nome || !this.quantita || !this.prezzo || 
      this.nome?.trim() === "" || this.quantita < 0 || this.prezzo < 0){
        this.errore = true;
        return;
    }

    let prod = new Prodotto();
    prod.cod = this.codice;
    prod.nom = this.nome;
    prod.des = this.descrizione;
    prod.pre = this.prezzo;
    prod.qua = this.quantita;

    if(this.service.ModificaProdotto(prod)){
      this.successo = true;

      setTimeout(() => {
        this.router.navigateByUrl("/prodotti/lista")
      }, 2000);

    }
    else{
      this.errore = true;
    }
  }
}

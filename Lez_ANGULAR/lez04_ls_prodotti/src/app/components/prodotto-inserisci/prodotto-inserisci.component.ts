import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { Prodotto } from '../../models/prodotto';
import { ProdottoService } from '../../services/prodotto.service';

@Component({
  selector: 'app-prodotto-inserisci',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './prodotto-inserisci.component.html',
  styleUrl: './prodotto-inserisci.component.css'
})
export class ProdottoInserisciComponent {

  nome?: string;
  descrizione?: string;
  quantita: number = 1;
  prezzo: number = 0;

  errore: boolean = false;

  constructor(private service: ProdottoService){

  }

  salva(){
    if(!this.nome || this.nome?.trim() === "" || this.quantita < 0 || this.prezzo < 0){
      this.errore = true;
      return;
    }

    let prod = new Prodotto();
    prod.nom = this.nome;
    prod.des = this.descrizione;
    prod.pre = this.prezzo;
    prod.qua = this.quantita;

    this.service.
  }
}

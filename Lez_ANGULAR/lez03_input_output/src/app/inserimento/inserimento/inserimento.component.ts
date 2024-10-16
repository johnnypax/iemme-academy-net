import { Component } from '@angular/core';
import { Prodotto } from '../../models/prodotto';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-inserimento',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './inserimento.component.html',
  styleUrl: './inserimento.component.css'
})
export class InserimentoComponent {

  nome: string | undefined;
  descrizione: string | undefined;
  prezzo: number = 0;

  elenco: Prodotto[] = new Array();

  salva(){
    let prod = new Prodotto(this.nome, this.descrizione, this.prezzo);
    this.elenco.push(prod)

    this.nome = "";
    this.descrizione = "";
    this.prezzo = 0;
  }

}

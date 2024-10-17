import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ProdottoService } from '../../services/prodotto.service';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-prodotto-modifica',
  standalone: true,
  imports: [FormsModule, CommonModule],
  templateUrl: './prodotto-modifica.component.html',
  styleUrl: './prodotto-modifica.component.css'
})
export class ProdottoModificaComponent {

  nome: string | undefined;
  descrizione: string | undefined;
  quantita: number | undefined;
  prezzo: number | undefined;

  errore: boolean = false;
  successo: boolean = false;

  constructor(private rottaAttiva: ActivatedRoute, private service: ProdottoService){
    
  }

  ngOnInit(){
    this.rottaAttiva.params.subscribe( (risultato) => {
      let codice = risultato['codice'];
      
      let prod = this.service.DettaglioProdotto(codice);
      if(prod !== null){

        this.nome = prod.nom;
        this.descrizione = prod.des;
        this.quantita = prod.qua;
        this.prezzo = prod.pre;

      }
    })
  }

  salva(){

  }
}

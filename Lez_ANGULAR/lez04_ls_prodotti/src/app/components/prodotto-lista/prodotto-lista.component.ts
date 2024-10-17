import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { Prodotto } from '../../models/prodotto';
import { ProdottoService } from '../../services/prodotto.service';
import { ReadVarExpr } from '@angular/compiler';

@Component({
  selector: 'app-prodotto-lista',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './prodotto-lista.component.html',
  styleUrl: './prodotto-lista.component.css'
})
export class ProdottoListaComponent {

  elencoprodotti: Prodotto[] = [];
  successo: boolean = false;

  constructor(private service: ProdottoService){

  }

  ngOnInit(){
    this.stampaTabella();
  }

  stampaTabella(){
    this.elencoprodotti = this.service.ListaProdotti();
  }

  elimina(varCodice?: string){
    if(varCodice && varCodice.trim() !== ""){
      if(this.service.EliminaProdotto(varCodice)){
        this.stampaTabella();

        this.successo = true;

        setTimeout(() => {
          this.successo = false;
        }, 2000);
      }
    }
  }
}

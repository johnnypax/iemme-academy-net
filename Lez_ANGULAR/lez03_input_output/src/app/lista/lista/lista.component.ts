import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { Prodotto } from '../../models/prodotto';

@Component({
  selector: 'app-lista',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './lista.component.html',
  styleUrl: './lista.component.css'
})
export class ListaComponent {

  visualizzaTabella: boolean = true;

  elenco_stringhe: string[] = ["Fiat", "Maserati", "Lamborghini", "BMW"];

  elenco_prodotti: Prodotto[] = [
    new Prodotto("Biscotti", "Molto buoni se della classe di fianco", 0),
    new Prodotto("Marmellata", "Molto buona se della classe di fianco", 10),
    new Prodotto("Succhino", "Molto dolce se della classe di fianco", 1.5),
  ]

  toggla() {
    this.visualizzaTabella = !this.visualizzaTabella;
  }
}

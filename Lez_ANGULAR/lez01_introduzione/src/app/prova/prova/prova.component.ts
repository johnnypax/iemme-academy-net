import { Component } from '@angular/core';
import { Persona } from '../../Models/persona';

@Component({
  selector: 'app-prova',
  standalone: true,
  imports: [],
  templateUrl: './prova.component.html',
  styleUrl: './prova.component.css'
})
export class ProvaComponent {

  constructor(){
    console.log("Ciao sono il costruttore di ProvaComponent " + (new Date()).valueOf());

    let gio = new Persona();
    gio.nome = "Giovanni";
    gio.cognome = "Pace"
  }

  ngOnInit() {
    console.log("Ciao sono il onInit di Prova Component " + (new Date()).valueOf());
  }

}

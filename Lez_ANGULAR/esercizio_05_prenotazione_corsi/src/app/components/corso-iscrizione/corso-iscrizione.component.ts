import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { Iscrizione } from '../../models/iscrizione';
import { IscrizioneService } from '../../services/iscrizione.service';

@Component({
  selector: 'app-corso-iscrizione',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './corso-iscrizione.component.html',
  styleUrl: './corso-iscrizione.component.css'
})
export class CorsoIscrizioneComponent {

  nome: string | undefined;
  cogn: string | undefined;
  emai: string | undefined;
  codi: string | undefined;

  constructor(private routeActive: ActivatedRoute, private service: IscrizioneService){

  }

  Iscriviti() {
    this.routeActive.params.subscribe( (risultato) => {
      this.codi = risultato['corso'];
      if(this.codi && this.codi.trim() !== ""){
        
        let iscrizione : Iscrizione = {
          nome: this.nome,
          cognome: this.cogn,
          email: this.emai,
          corsoiscr: {
            cod: this.codi,
          }
        }

        this.service.Inserisci(iscrizione).then(risultato => {
          if(risultato)
            alert("Ecco il tuo codice di disiscrizione " + risultato);
          else
            alert("Errore di iscrizione")
        });
      }
    })
  }

}

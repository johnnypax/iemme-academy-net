import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { ListaComponent } from './lista/lista/lista.component';
import { InserimentoComponent } from './inserimento/inserimento/inserimento.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, ListaComponent, InserimentoComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'lez03_input_output';
}

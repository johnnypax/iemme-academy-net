import { Routes } from '@angular/router';
import { CorsoListaComponent } from './components/corso-lista/corso-lista.component';

export const routes: Routes = [
    {path: "", redirectTo: "corsi", pathMatch: "full"}, 
    {path: "corsi", component: CorsoListaComponent}
];

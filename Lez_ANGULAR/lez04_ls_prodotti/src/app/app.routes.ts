import { Routes } from '@angular/router';
import { ProdottoListaComponent } from './components/prodotto-lista/prodotto-lista.component';
import { ProdottoInserisciComponent } from './components/prodotto-inserisci/prodotto-inserisci.component';
import { ProdottoModificaComponent } from './components/prodotto-modifica/prodotto-modifica.component';

export const routes: Routes = [
    {path: "", redirectTo: "prodotti/lista", pathMatch: "full"},
    {path: "prodotti/lista", component: ProdottoListaComponent},
    {path: "prodotti/inserisci", component: ProdottoInserisciComponent},
    {path: "prodotti/modifica/:codice", component: ProdottoModificaComponent}
];

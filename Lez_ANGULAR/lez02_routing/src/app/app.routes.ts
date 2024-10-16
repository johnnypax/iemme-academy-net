import { Routes } from '@angular/router';
import { HomeComponent } from './home/home/home.component';
import { ServiziComponent } from './servizi/servizi/servizi.component';
import { ChiSiamoComponent } from './chi-siamo/chi-siamo/chi-siamo.component';
import { ContattiComponent } from './contatti/contatti/contatti.component';

export const routes: Routes = [
    {path: "", redirectTo: "home", pathMatch: "full"},
    {path: "home", component: HomeComponent},
    {path: "servizi", component: ServiziComponent},
    {path: "chisiamo", component: ChiSiamoComponent},
    {path: "contatti", component: ContattiComponent},
];
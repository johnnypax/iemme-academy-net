import Edicola from "./Edicola";
import Rivista from "./Rivista";

let edi = new Edicola("Via le mani dal naso");

edi.addRivista(new Rivista("AB1234", "Ciao"))
edi.addRivista(new Rivista("AB1235", "Saluti"))
edi.addRivista(new Rivista("AB1236", "Il Carlino"))

edi.stampaRiviste();
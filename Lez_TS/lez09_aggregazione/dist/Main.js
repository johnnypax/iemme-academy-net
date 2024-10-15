"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var Edicola_1 = require("./Edicola");
var Rivista_1 = require("./Rivista");
var edi = new Edicola_1.default("Via le mani dal naso");
edi.addRivista(new Rivista_1.default("AB1234", "Ciao"));
edi.addRivista(new Rivista_1.default("AB1235", "Saluti"));
edi.addRivista(new Rivista_1.default("AB1236", "Il Carlino"));
edi.stampaRiviste();

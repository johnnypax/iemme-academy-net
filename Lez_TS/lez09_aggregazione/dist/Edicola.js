"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var Edicola = /** @class */ (function () {
    function Edicola(indirizzo) {
        this.elenco = new Array();
        this.indirizzo = indirizzo;
    }
    Edicola.prototype.addRivista = function (riv) {
        this.elenco.push(riv);
    };
    Edicola.prototype.stampaRiviste = function () {
        console.log("Edicola: ".concat(this.indirizzo));
        this.elenco.forEach(function (element) {
            element.stampaDettaglio();
        });
    };
    return Edicola;
}());
exports.default = Edicola;

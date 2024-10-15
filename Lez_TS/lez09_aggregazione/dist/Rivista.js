"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var Rivista = /** @class */ (function () {
    function Rivista(codice, titolo) {
        this.codice = codice;
        this.titolo = titolo;
    }
    Rivista.prototype.stampaDettaglio = function () {
        console.log("Rivista: ".concat(this.codice, " ").concat(this.titolo));
    };
    return Rivista;
}());
exports.default = Rivista;

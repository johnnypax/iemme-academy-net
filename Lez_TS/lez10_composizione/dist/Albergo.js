"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var Albergo = /** @class */ (function () {
    function Albergo(indirizzo) {
        this.indirizzo = indirizzo;
    }
    Albergo.prototype.aggiungiCamera = function (cam) {
        if (!this.elenco)
            this.elenco = new Array();
        this.elenco.push(cam);
    };
    Albergo.prototype.stampaAlbergo = function () {
        console.log("Albergo: ".concat(this.indirizzo));
        if (this.elenco)
            this.elenco.forEach(function (element) {
                element.dettaglioCamera();
            });
    };
    return Albergo;
}());
exports.default = Albergo;

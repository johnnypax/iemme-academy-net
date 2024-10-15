"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var Persona = /** @class */ (function () {
    function Persona(nome, cognome, eta) {
        this.risparmi = 0;
        this.nome = nome;
        this.cognome = cognome;
        this.eta = eta;
    }
    Persona.prototype.setRisparmi = function (valRisparmi) {
        if (valRisparmi > 0)
            this.risparmi = valRisparmi;
        else
            console.log("Errore, valore negativo");
    };
    Persona.prototype.getRisparmi = function () {
        return this.risparmi;
    };
    return Persona;
}());
exports.default = Persona;

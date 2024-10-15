"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var Persona = /** @class */ (function () {
    function Persona(nome, cognome) {
        this.nome = nome;
        this.cognome = cognome;
    }
    Persona.prototype.saluta = function () {
        console.log("Ciao ".concat(this.nome, " ").concat(this.cognome));
    };
    return Persona;
}());
exports.default = Persona;

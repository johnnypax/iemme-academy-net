"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var Animale = /** @class */ (function () {
    function Animale(hasPelo) {
        this.hasPelo = false;
        this.hasPelo = hasPelo;
    }
    Animale.prototype.dormi = function () {
        console.log("zzzzZZZZZZ");
    };
    return Animale;
}());
exports.default = Animale;

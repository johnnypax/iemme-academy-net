"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var Camera = /** @class */ (function () {
    function Camera(numero) {
        this.numero = numero;
    }
    Camera.prototype.dettaglioCamera = function () {
        console.log("CAMERA: ".concat(this.numero));
    };
    return Camera;
}());
exports.default = Camera;

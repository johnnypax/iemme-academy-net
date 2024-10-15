var Automobile = /** @class */ (function () {
    function Automobile(varMarca, varModello) {
        this.marca = varMarca;
        this.modello = varModello;
    }
    Automobile.prototype.stampaDettaglio = function () {
        console.log("Automobile: ".concat(this.marca, " ").concat(this.modello));
    };
    return Automobile;
}());
var ectoUno = new Automobile("Forda", "Fuocus");
ectoUno.stampaDettaglio();

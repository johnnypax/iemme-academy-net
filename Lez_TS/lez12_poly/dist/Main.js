"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var Cane_1 = require("./Cane");
var Gatto_1 = require("./Gatto");
// function verso( ani: Animale ){
//     ani.versoEmesso();
// }
// verso( new Gatto("Bu", true) );
// verso( new Gatto("Bah", true) );
// verso( new Cane("Bubba", true) );
// -----------------------------------------------------------
var bu = new Gatto_1.default("Bu", true);
var xi = new Gatto_1.default("Xi", false);
var xiu = new Cane_1.default("Xi", true);
// bu.versoEmesso();
// xi.versoEmesso();
// xiu.versoEmesso();
var elenco = new Array();
elenco.push(bu);
elenco.push(xi);
elenco.push(xiu);
elenco.forEach(function (element) {
    element.versoEmesso();
    if (element instanceof Gatto_1.default) {
        element.faFusa();
    }
});

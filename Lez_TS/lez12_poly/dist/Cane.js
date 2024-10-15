"use strict";
var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (Object.prototype.hasOwnProperty.call(b, p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        if (typeof b !== "function" && b !== null)
            throw new TypeError("Class extends value " + String(b) + " is not a constructor or null");
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
Object.defineProperty(exports, "__esModule", { value: true });
var Animale_1 = require("./Animale");
var Cane = /** @class */ (function (_super) {
    __extends(Cane, _super);
    function Cane(nome, hasPelo) {
        var _this = _super.call(this, hasPelo) || this;
        _this.nome = nome;
        return _this;
    }
    Cane.prototype.versoEmesso = function () {
        console.log("Bau Bau");
    };
    return Cane;
}(Animale_1.default));
exports.default = Cane;

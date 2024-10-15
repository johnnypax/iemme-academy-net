class Automobile{
    marca;
    modello;

    constructor(varMarca, varModello){
        console.log("Sono il costruttore con due parametri")
        this.marca = varMarca,
        this.modello = varModello;
    }

    stampaDettaglio(){
        console.log( `Automobile: ${this.marca} ${this.modello}`);
    }
}

let autoUno = new Automobile();
autoUno.marca = "Forda";
autoUno.modello = "Fuocus";

let autoDue = new Automobile("Fiat");
autoDue.modello = "Panda";

let autoTre = new Automobile("Fiat", "Multipla");

autoUno.stampaDettaglio();
autoDue.stampaDettaglio();
autoTre.stampaDettaglio();
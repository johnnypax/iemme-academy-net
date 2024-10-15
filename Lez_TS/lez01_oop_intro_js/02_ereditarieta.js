class Automobile{
    constructor(varMarca, varModello){
        this.marca = varMarca;
        this.modello = varModello;
    }

    stampaDettaglio(){
        console.log(`Automobile: ${this.marca} ${this.modello}`)
    }
}

class Elettrica extends Automobile{
    constructor(varMar, varMod, varAutonomia){
        super(varMar, varMod)
        this.autonomia = varAutonomia
    }

    stampaDettaglio(){
        console.log(`Elettrica:
                Marca: ${this.marca}
                Modello: ${this.modello}
                Autonomia: ${this.autonomia}`)
    }
}

let ele = new Elettrica(undefined, "Type S", 856);
ele.stampaDettaglio();

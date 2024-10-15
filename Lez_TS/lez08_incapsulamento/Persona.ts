export default class Persona{
    private nome: string | undefined;
    private cognome: string | undefined;
    private eta: number | undefined;
    private risparmi: number = 0;

    constructor(nome?: string, cognome?: string, eta?: number){
        this.nome = nome;
        this.cognome = cognome;
        this.eta = eta;
    }

    setRisparmi(valRisparmi : number) : void{
        if(valRisparmi > 0)
            this.risparmi = valRisparmi;
        else
            console.log("Errore, valore negativo");
    }

    getRisparmi() : number {
        return this.risparmi
    }
}


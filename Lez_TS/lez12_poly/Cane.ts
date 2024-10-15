import Animale from "./Animale";

export default class Cane extends Animale{
    private nome: string | undefined;

    constructor(nome: string, hasPelo: boolean){
        super(hasPelo);
        this.nome = nome;
    }

    versoEmesso(): void {
        console.log("Bau Bau");
    }
}
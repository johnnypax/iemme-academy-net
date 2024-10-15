import Animale from "./Animale";

export default class Gatto extends Animale{
    private nome: string | undefined;

    constructor(nome: string, hasPelo: boolean){
        super(hasPelo);
        this.nome = nome;
    }

    versoEmesso(): void {
        console.log("Miau miau");
    }
}
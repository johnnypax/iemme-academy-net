export default abstract class Animale{
    private hasPelo: boolean = false;

    constructor(hasPelo: boolean){
        this.hasPelo = hasPelo;
    }

    abstract versoEmesso(): void;

    dormi(): void{
        console.log("zzzzZZZZZZ")
    }
}
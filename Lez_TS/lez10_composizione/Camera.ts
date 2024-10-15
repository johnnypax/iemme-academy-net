export default class Camera{
    private numero: string | undefined;
    
    constructor(numero: string){
        this.numero = numero
    }

    dettaglioCamera() : void {
        console.log(`CAMERA: ${this.numero}`)
    }
}
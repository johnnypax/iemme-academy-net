import Utente from "./Utente";

export default class Oggetto{
    private codice: string | undefined;
    private nome: string | undefined;
    private descrizione: string | undefined;
    private proprietario: Utente | undefined;
}
namespace Lez02_01_TaskInvitati
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
             * Scrivere un sistema di gestione invitati alla propria festa
             * L'inserimento avviene tramite console e prende in input, in tre tempi diversi, il nome, il cognome ed il numero di telefono.
             * 
             * All'uscita del programma verrà stampato l'elenco delle persone precedentemente inserite separato da virgola.
             * 
             * TIP: Crea una stringa all'inizio del programma che ti potrà essere utile per aggiungere gli invitati.
             */

            bool insAbi = true;

            while(insAbi)
            {
                Console.Write("Dimmi cosa vuoi fare:\n- I per inserimento\n- Q per uscire");
                string? inputUtente = Console.ReadLine();
            }
        }
    }
}

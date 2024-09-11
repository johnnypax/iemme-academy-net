namespace Lez02_01_Task
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
            string? elencoinvitati = "";

            while (insAbi)
            {
                Console.WriteLine("Dimmi cosa vuoi fare:\n- I per inserimento\n- Q per uscire");
                string? inputUtente = Console.ReadLine();

                if(inputUtente is not null)
                    inputUtente = inputUtente.ToUpper();

                switch (inputUtente)
                {
                    case "I":
                        Console.Write("Dammi il nome:");
                        string? inNome = Console.ReadLine();
                        Console.Write("Dammi il cognome:");
                        string? inCogn = Console.ReadLine();
                        Console.Write("Dimmi il tuo telefono:");
                        string? inTele = Console.ReadLine();

                        elencoinvitati += $"{inNome} {inCogn} {inTele}, ";
                        Console.WriteLine("Inserimento effettuato con successo");
                        break;
                    case "Q":
                        insAbi = !insAbi;
                        break;
                    default:
                        Console.WriteLine("Comando non riconosciuto");
                        break;
                }
            }


            Console.WriteLine($"Elenco invitati:\n{elencoinvitati}");
        }
    }
}

namespace Lez01_09_CicliSemplici
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * indice
             * 
             * while(condizione){
             *      //Operazione da iterare
             *      
             *      incremento
             * }
             */

            //int indice = 0;
            //int max = 0;

            //while(indice < max)
            //{
            //    Console.WriteLine($"Ciao, sono al numero {indice + 1}");

            //    indice++;
            //}

            //--------------------------------

            //int i = 0;
            //int max = 0;

            //do
            //{
            //    Console.WriteLine($"Ciao, sono al numero {i + 1}");

            //    i++;
            //} while (i < max);

            //--------------------------------

            bool inserimentoAbilitato = true;

            while (inserimentoAbilitato)
            {
                Console.WriteLine("Chi vuoi salutare? Digita Q per uscire");
                string? inputUtente = Console.ReadLine();

                if (inputUtente is not null && inputUtente.Equals("Q"))
                    inserimentoAbilitato = false;
                else
                    Console.WriteLine($"Ciao, {inputUtente}");
            }

            /* 
             * Scrivere un sistema di gestione invitati alla propria festa
             * L'inserimento avviene tramite console e prende in input, in tre tempi diversi, il nome, il cognome ed il numero di telefono.
             * 
             * All'uscita del programma verrà stampato l'elenco delle persone precedentemente inserite separato da virgola.
             * 
             * TIP: Crea una stringa all'inizio del programma che ti potrà essere utile per aggiungere gli invitati.
             */
        }
    }
}

namespace Lez01_07_InputUtente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Creare un programma che in input prenda il nome, cognome ed età dell'utente e che in output lo saluti e gli dica se è maggiorenne o minorenne.
             */

            Console.Write("Inserisci il nome: ");
            string? inputNome = Console.ReadLine();

            Console.Write("Inserisci il cognome: ");
            string? inputCognome = Console.ReadLine();

            Console.Write("Inserisci l'età: ");

            //string? inputEta = Console.ReadLine();
            //int eta = Convert.ToInt32(inputEta);      //Ottimizzo

            try
            {
                int eta = Convert.ToInt32(Console.ReadLine());

                string? risultato;
                if (eta >= 18)
                {
                    risultato = " maggiorenne";
                }
                else
                {
                    risultato = " minorenne";
                }

                Console.Write($"Ciao {inputNome} {inputCognome}, sei {risultato}");


            }
            catch (FormatException)
            {
                Console.WriteLine("Errore, formato non ammesso!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Errore, numero troppo grande!");
            }
            catch (Exception)
            {
                Console.WriteLine("errore");
            }

        }
    }
}

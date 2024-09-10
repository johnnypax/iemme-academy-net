namespace Lez01_06_TaskTemperatura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Creare un sistema di controllo accessi al ristorante, in input (sotto forma di variabile) ci sarà la temperatura.
             * 
             * Se la temperatura è maggiore o uguale a 37.5° non permettere l'accesso al ristorante.
             * 
             * ATTENZIONE: Non ci vuole un medico per stabilire che al di sotto dei 34° potrebbe esserci qualche problema, oppure al di sopra dei 42 potrebbe esserci qualche sintomo di una apocalisse zombie (a cui non dovrebbe essere permesso l'accesso). Restituire un errore.
             */

            //float temperatura = 332.0f;

            //if(temperatura > 34 && temperatura < 42)
            //{
            //   if(temperatura <= 37.5f)
            //    {
            //        Console.WriteLine("Puoi entrare");
            //    }
            //    else
            //    {
            //        Console.WriteLine("NON Puoi entrare");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("ERRORE");
            //}

            //-------------------------------------------

            //Console.WriteLine("Ciao, inserisci il tuo nome");
            //string? inputUtente = Console.ReadLine();
            //Console.WriteLine($"Benvenuto {inputUtente}");

            //-------------------------------------------

            //Console.WriteLine("Inserisci la temperatura:");

            //string? inputUtente = Console.ReadLine();
            //double temperatura = Convert.ToDouble(inputUtente);

            //if (temperatura > 34 && temperatura < 42)
            //{
            //    if (temperatura <= 37.5d)
            //    {
            //        Console.WriteLine("Puoi entrare");
            //    }
            //    else
            //    {
            //        Console.WriteLine("NON Puoi entrare");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("ERRORE");
            //}

            //-------------------------------------------------

            Console.WriteLine("Inserisci la temperatura:");

            string? inputUtente = Console.ReadLine();

            try
            {
                double temperatura = Convert.ToDouble(inputUtente);

                if (temperatura > 34 && temperatura < 42)
                {
                    if (temperatura <= 37.5d)
                    {
                        Console.WriteLine("Puoi entrare");
                    }
                    else
                    {
                        Console.WriteLine("NON Puoi entrare");
                    }
                }
                else
                {
                    Console.WriteLine("ERRORE");
                }
            }
            catch
            {
                Console.WriteLine("ERRORE DI INPUT");
            }
            
        }
    }
}

namespace Lez01_05_Stringhe
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //string nominativo = null!;
            //nominativo = "Giovanni";

            //Console.WriteLine(nominativo);

            //------------------------------------

            //Console.WriteLine("Giovanni" + "Pace");

            //int a = 5;
            //int b = 10;

            //Console.WriteLine("La somma dei numeri è: " + a + b);  // ... è: 510
            //Console.WriteLine("La somma dei numeri è: " + (a + b));
            //Console.WriteLine(a + b + " è la somma dei due numeri");

            //----------------------------------------------------

            /*
             * Scrivere un programma che mandi in output le seguenti due stringhe:
             * 
             * Giovanni Pace è 37 anni vecchio ed ha una temperatura corporea di 36.2°
             * Mario Rossi è 35 anni vecchio ed ha una temperatura corporea di 37.3°
             */

            //string nominativo = "Giovanni Pace";
            //int eta = 37;
            //float temperatura = 36.2f;

            //Console.WriteLine($"{nominativo} è {eta} anni vecchio ed ha una temperatura corporea di {temperatura}°");

            //nominativo = "Mario Rossi";
            //eta = 35;
            //temperatura = 37.3f;

            //Console.WriteLine($"{nominativo} è {eta} anni vecchio ed ha una temperatura corporea di {temperatura}°");

            //------------------------------------------------

            //Console.WriteLine($"Guarda la somma di questi numeri, è: {5 + 6}");

            //string nominativo = "Giovanni Pace";
            //Console.WriteLine($"La lunghezza del nome {nominativo} è: {nominativo.Length}");

            //int lunghezza = nominativo.Length;
            //Console.WriteLine($"La lunghezza del nome {nominativo} è: {lunghezza}");

            //--------------------------------------------------

            //string? frase = "Mi piace tanto \"programmare\"";
            //Console.WriteLine(frase);

            //char prova = 'A';

            //--------------------------------------------------

            string? frase = "Sono Giovanni e mi piace programmare";

            //Console.WriteLine(frase.IndexOf("Sono"));

            if (frase.IndexOf("Giovanni") >= 0)
            {
                Console.WriteLine("Trovato");
            }
            else
            {
                Console.WriteLine("Non trovat");
            }






        }
    }
}

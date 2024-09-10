namespace lez00_introduzione
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Singola linea di commento
            /*
             * Commento 
             * multi linea
             */


#if DEBUG
            Console.WriteLine("Sono in modalità Debug");
#elif RELEASE
            Console.WriteLine("Sono in modalità Release");
#endif

        }
    }
}

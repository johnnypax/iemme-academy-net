using Lez05_01_CorrezioneEsercizioUno.classes;
using System.Numerics;

namespace Lez05_01_CorrezioneEsercizioUno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calcolatrice calUno = new Calcolatrice();
            //Calcolatrice calDue = new Calcolatrice();
            //NON PERMESSO PERCHé PRIVATO

            double? prova = Calcolatrice.Divisione(5, 0);
            Console.WriteLine(prova);
        }
    }
}

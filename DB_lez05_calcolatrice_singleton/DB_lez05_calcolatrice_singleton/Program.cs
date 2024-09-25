using DB_lez05_calcolatrice_singleton.classes;

namespace DB_lez05_calcolatrice_singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calcolatrice.GetInstance().Somma(20, 5));
            Console.WriteLine(Calcolatrice.GetInstance().Somma(21, 5));
            Console.WriteLine(Calcolatrice.GetInstance().Sottrazione(22, 5));
            Console.WriteLine(Calcolatrice.GetInstance().Sottrazione(23, 5));
            Console.WriteLine(Calcolatrice.GetInstance().Moltiplicazione(24, 5));
        }
    }
}

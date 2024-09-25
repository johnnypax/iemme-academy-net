namespace LINQ_lez01_filtri_numeri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> elenco = new List<int>() { 1, 4, 6, 8, 2, 3, 9, 10, 11 };

            var risultato = from numero in elenco
                            where numero > 5
                            orderby numero
                            select numero;

            foreach (var num in risultato)
            {
                Console.WriteLine(num);
            }
        }
    }
}

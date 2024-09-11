namespace Lez02_06_Metodi
{
    internal class Program
    {
        static void SalutaGiovanni()
        {
            Console.WriteLine("Ciao sono Giovanni");
            Console.WriteLine("Sono il docente di informatica");
            Console.WriteLine("Vi mando i miei saluti");
        }

        static void SalutaPersona(string varNominativo)
        {
            Console.WriteLine($"Ciao, {varNominativo}");
        }
        static void SalutaPersonaConEta(string varNominativo, int varEta)
        {
            Console.WriteLine($"Ciao, {varNominativo}, so che hai {varEta} anni");
        }

        static int Somma(int varA, int varB)
        {
            int risultato = varA + varB;
            return risultato;
        }

        static void Main(string[] args)
        {

            Console.WriteLine(Somma(1, 2));
            Console.WriteLine(Somma(11, 22));
            Console.WriteLine(Somma(13, 23));
        }
    }
}

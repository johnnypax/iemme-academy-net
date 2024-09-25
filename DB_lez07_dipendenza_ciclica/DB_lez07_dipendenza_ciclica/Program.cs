using DB_lez07_dipendenza_ciclica.Models;

namespace DB_lez07_dipendenza_ciclica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Albergo gh = new Albergo()
            { Nome = "Grand Hotel", Indirizzo = "Via le mani dal naso", Stelle = 5 };

            Camera aur = new Camera("Aurora", 5, "Molto bella", gh);
            Camera tra = new Camera("Tramonto", 4, "Molto scura", gh);

            gh.AggiungiCamera(aur);
            gh.AggiungiCamera(tra);

            Console.WriteLine(aur);
            //Console.WriteLine(gh);

        }
    }
}

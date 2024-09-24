using DB_lez02_refactor.classes;

namespace DB_lez02_refactor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DipendenteDAO dDao = new DipendenteDAO();

            //List<Dipendente> elencoDip = dDao.FindAll();

            //foreach (Dipendente dip in elencoDip)
            //{
            //    Console.WriteLine(dip);
            //}

            //Dipendente? dipe = dDao.FindById(110);
            //Console.WriteLine(dipe);

            Dipendente val = new Dipendente()
            {
                Nome = "Valeria",
                Cogn = "Verdi",
                Dipa = "IT",
                Sala = 98000
            };

            if (dDao.Insert(val))
                Console.WriteLine("STAPPOOOOOOOO");
            else
                Console.WriteLine("ERRORE");

        }
    }
}

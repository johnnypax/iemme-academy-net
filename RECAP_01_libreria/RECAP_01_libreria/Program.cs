using RECAP_01_libreria.Models;

namespace RECAP_01_libreria
{
    internal class Program
    {
        static void Main(string[] args)
        {

            using(var ctx = new RecapLibrContext())
            {
                try
                {
                    Utente per = ctx.Utentes.Single(u => u.Email == "mario.rossi@email.com");
                    Libro lib = ctx.Libros.Single(l => l.CodLibro == "9B5C164E-E6B0-4BB3-88AF-749272B655A2");

                    var pre = new Prestito()
                    {
                        DataPres = DateOnly.FromDateTime(DateTime.UtcNow),
                        LibroRifNavigation = lib,
                        UtenteRifNavigation = per
                    };

                    ctx.Prestitos.Add(pre);
                    ctx.SaveChanges();

                    Console.WriteLine("stappooooooooooooo");

                } catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            } 

        }
    }
}

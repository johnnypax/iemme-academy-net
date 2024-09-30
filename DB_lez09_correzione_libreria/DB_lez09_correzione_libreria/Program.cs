using DB_lez09_correzione_libreria.Models;

namespace DB_lez09_correzione_libreria
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Recap lazy
            //using(var ctx = new RecapLibrContext())
            //{
            //    try
            //    {
            //        Prestito pre = ctx.Prestitos.Single(p => p.PrestitoId == 1);
            //        Libro lib = ctx.Libros.Single(l => l.LibroId == pre.LibroRif);
            //        Utente ute = ctx.Utentes.Single(u => u.UtenteId == pre.UtenteRif);

            //        Console.WriteLine($"Utente: {ute.Nome} {ute.Cognome} ha preso {lib.Titolo} il giorno {pre.DataPres}");

            //    } catch (Exception ex)
            //    {
            //        Console.Write(ex.ToString());
            //    }
            //}
            #endregion

            //if(Biblioteca.GetInstance().AggiungiLibro("Il boh di Gio", 2024))
            //{
            //    Console.WriteLine("STAPPOOOOOOO");
            //}
            //else
            //{
            //    Console.WriteLine("Errore di inserimento");
            //}

            //if (Biblioteca.GetInstance().AggiungiPrenotazione("5E76E9A0-3003-4F13-9D88-D64395B832F7", "457F2B17-47EC-425A-BC0E-E244EB7C5BDF"))
            //{
            //    Console.WriteLine("STAPPOOOOOOO");
            //}
            //else
            //{
            //    Console.WriteLine("Errore di inserimento");
            //}

            Biblioteca.GetInstance().StampaUtenteConPrenotazioni("5E76E9A0-3003-4F13-9D88-D64395B832F7");

        }
    }
}

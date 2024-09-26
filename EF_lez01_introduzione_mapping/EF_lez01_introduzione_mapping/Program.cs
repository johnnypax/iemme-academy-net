using EF_lez01_introduzione_mapping.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections;

namespace EF_lez01_introduzione_mapping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region scaffolding
            //Scaffold-DbContext "Server=BOOK-N57JVKH6HJ\SQLEXPRESS;Database=db_lez02_libreria;User Id=academy;Password=academy!;MultipleActiveResultSets=true;Encrypt=false;TrustServerCertificate=false" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models
            #endregion

            // ------------------------------------------------------

            //Libro libUno = new Libro()
            //{
            //    Titolo = "Mandala a casa...",
            //    Autore = "Giovanni Pace",
            //    Editore = "Un pazzo",
            //    Pagine = 987,
            //    Isbn = "111111"
            //};

            //Libro libDue = new Libro()
            //{
            //    Titolo = "Mandala a prende il caffè...",
            //    Autore = "Giovanni Pace",
            //    Editore = "Un pazzo",
            //    Pagine = 125,
            //    Isbn = "111112"
            //};

            //using(var ctx = new DbLez02LibreriaContext())
            //{
            //    try
            //    {
            //        ctx.Libros.Add(libUno);
            //        ctx.Libros.Add(libDue);
            //        ctx.SaveChanges();

            //        Console.WriteLine("Inserimento effettuato con successo");
            //    } catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            //}

            // ------------------------------------------------------

            //IList<Libro> elenco = new List<Libro>();
            //ICollection<Libro> elencoDue = new List<Libro>();
            //IEnumerable<Libro> elencoTre = new List<Libro>();

            //ArrayList ar = new ArrayList();

            // ------------------------------------------------------

            using(var ctx = new DbLez02LibreriaContext())
            {
                //ICollection<Libro> elenco = ctx.Libros.ToList();

                //foreach(Libro l in elenco)
                //{
                //    Console.WriteLine(l);
                //}

                // -------------------------------------

                //try
                //{
                //    Libro lib = ctx.Libros.Single(l => l.Isbn.Equals("9780747832699"));
                //    Console.Write(lib);
                //} catch (Exception ex){
                //    Console.WriteLine(ex.Message);
                //}

                //

                Libro? libDue = ctx.Libros.FirstOrDefault(l => l.Isbn.Equals("9780747832699"));
                Console.Write(libDue);
            }


        }
    }
}

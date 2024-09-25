using LINQ_lez03_raggruppamenti.Models;

namespace LINQ_lez03_raggruppamenti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Libro> elenco = new List<Libro>() {
                new Libro("Libro A", "Autore 1", "Fantasy"),
                new Libro("Libro B", "Autore 2", "Sci-Fi"),
                new Libro("Libro C", "Autore 1", "Horror"),
                new Libro("Libro D", "Autore 3", "Fantasy"),
                new Libro("Libro E", "Autore 2", "Horror")
            };

            //var risultato = from libro in elenco
            //                select libro;

            //var risultato = from libro in elenco
            //                select libro.Categoria;

            //var risultato = from libro in elenco
            //                select libro.Categoria is not null && libro.Categoria.Equals("Fantasy") ?
            //                    libro.Titolo + " è un libro Fantasy" : "Non mi interessa";

            var risultato = from libro in elenco
                            where libro.Categoria is not null && libro.Categoria.Equals("Fantasy")
                            select libro;

            foreach (var l in risultato)
            {
                Console.WriteLine(l);
            }
        }
    }
}

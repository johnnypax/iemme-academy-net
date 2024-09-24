using DB_lez04_libreria.classes;
using DB_lez04_libreria.classes.DAL;

namespace DB_lez04_libreria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool insAbi = true;

            while (insAbi)
            {
                Console.WriteLine("Digita il comando per scegliere l'operazioe\n" +
                    "I - Inserimento\n" +
                    "S - Stampa\n" +
                    "Q - Esci");
                string? inputUtente = Console.ReadLine();

                switch(inputUtente)
                {
                    case "I":
                        Console.WriteLine("Inserisci il titolo");
                        string? inTitolo = Console.ReadLine();
                        Console.WriteLine("Inserisci il autore");
                        string? inAutore = Console.ReadLine();
                        Console.WriteLine("Inserisci il pagine");
                        int inPagine = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Inserisci l'editore");
                        string? inEditore = Console.ReadLine();
                        Console.WriteLine("Inserisci ISBN");
                        string? inIsbn = Console.ReadLine();

                        Libro lib = new Libro()
                        {
                            Titolo = inTitolo is not null ? inTitolo : "N.D.",
                            Autore = inAutore is not null ? inAutore : "N.D.",
                            Pagine = inPagine,
                            Editore = inEditore is not null ? inEditore : "N.D.",
                            Isbn = inIsbn is not null ? inIsbn : "N.D."
                        };

                        if (LibroDAO.GetInstance().Insert(lib))
                            Console.WriteLine("Libro inserito con successo");
                        else
                            Console.WriteLine("ERRORE di inserimento");

                        break;
                    case "S":
                        List<Libro> elenco = LibroDAO.GetInstance().GetAll();

                        foreach(Libro libro in elenco)
                        {
                            Console.WriteLine(libro);
                        }
                        break;
                    case "Q":
                        insAbi = false;
                        break;
                    default:
                        Console.WriteLine("Non conosco questo comando!");
                        break;
                }
            }
        }
    }
}

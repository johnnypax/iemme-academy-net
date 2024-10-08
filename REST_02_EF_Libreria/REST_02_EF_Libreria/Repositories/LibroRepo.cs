using REST_02_EF_Libreria.Models;

namespace REST_02_EF_Libreria.Repositories
{
    public class LibroRepo : IRepo<Libro>
    {
        private static LibroRepo? instance;

        public static LibroRepo GetInstance()
        {
            if (instance == null)
                instance = new LibroRepo();

            return instance;
        }
        private LibroRepo() { }

        public bool Delete(int id)
        {
            bool risultato = false;

            using (var ctx = new AEfLez02LibreriaContext())
            {
                try
                {
                    Libro lib = ctx.Libros.Single(l => l.LibroId == id);
                    ctx.Libros.Remove(lib);
                    ctx.SaveChanges();

                    risultato = true;
                } catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return risultato;
        }

        public List<Libro> GetAll()
        {
            List<Libro> elenco = new List<Libro>();

            using (var ctx = new AEfLez02LibreriaContext())
                elenco = ctx.Libros.ToList();

            return elenco;
        }

        public Libro? GetById(int id)
        {
            Libro? risultato = null;

            using (var ctx = new AEfLez02LibreriaContext())
                risultato = ctx.Libros.FirstOrDefault(l => l.LibroId == id);

            return risultato;
        }

        public Libro? GetByCodice(string varCodice)
        {
            Libro? risultato = null;

            using (var ctx = new AEfLez02LibreriaContext())
                risultato = ctx.Libros.FirstOrDefault(l => l.Codice == varCodice);

            return risultato;
        }

        public bool Insert(Libro t)
        {
            bool risultato = false;

            using (var ctx = new AEfLez02LibreriaContext())
            {
                try
                {
                    ctx.Libros.Add(t);
                    ctx.SaveChanges();

                    risultato = true;
                } catch (Exception ex){
                    Console.WriteLine(ex.Message);
                }
            }

            return risultato;
        }

        public bool Update(Libro t)
        {
            bool risultato = false;

            using (var ctx = new AEfLez02LibreriaContext())
            {
                try
                {
                    Libro temp = ctx.Libros.Single(l => l.Codice == t.Codice);

                    t.LibroId = temp.LibroId;
                    t.Titolo = t.Titolo is not null ? t.Titolo : temp.Titolo;
                    t.Descrizione = t.Descrizione is not null ? t.Descrizione : temp.Descrizione;
                    t.Quantita = t.Quantita != 0 ? t.Quantita : temp.Quantita;
                    t.Prezzo = t.Prezzo != 0 ? t.Prezzo : temp.Prezzo;
                    t.Autore = t.Autore is not null ? t.Autore : temp.Autore;

                    ctx.Entry(temp).CurrentValues.SetValues(t);
                    ctx.SaveChanges();

                    risultato = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return risultato;
        }
    }
}

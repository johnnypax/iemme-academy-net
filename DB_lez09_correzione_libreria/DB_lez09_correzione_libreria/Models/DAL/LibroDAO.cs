using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_lez09_correzione_libreria.Models.DAL
{
    internal class LibroDAO : IDao<Libro>
    {
        private static LibroDAO? instance;

        public static LibroDAO GetInstance()
        {
            if(instance == null)
                instance = new LibroDAO();

            return instance;
        }
        private LibroDAO() { }

        public List<Libro> GetAll()
        {
            List<Libro> libros;

            using(var ctx = new RecapLibrContext())
            {
                libros = ctx.Libros.ToList();
            }

            return libros;
        }

        public Libro? GetById(int id)
        {
            Libro? libro;

            using (var ctx = new RecapLibrContext())
            {
                libro = ctx.Libros.FirstOrDefault(l => l.LibroId == id);
            }

            return libro;
        }

        public Libro? GetByCodice(string codice)        //Non presente nell'interfaccia
        {
            Libro? libro;

            using (var ctx = new RecapLibrContext())
            {
                libro = ctx.Libros.FirstOrDefault(l => l.CodLibro == codice);
            }

            return libro;
        }

        public bool Insert(Libro t)
        {
            bool risultato = false;

            using (var ctx = new RecapLibrContext())
            {
                try
                {
                    ctx.Libros.Add(t);
                    ctx.SaveChanges();

                    risultato = true;
                } catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);  
                }
            }

            return risultato;
        }


    }
}

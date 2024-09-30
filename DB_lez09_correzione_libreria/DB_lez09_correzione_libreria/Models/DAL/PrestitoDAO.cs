using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_lez09_correzione_libreria.Models.DAL
{
    internal class PrestitoDAO : IDao<Prestito>
    {
        private static PrestitoDAO? instance;

        public static PrestitoDAO GetInstance()
        {
            if(instance == null)
                instance = new PrestitoDAO();

            return instance;
        }
        private PrestitoDAO() { }

        public List<Prestito> GetAll()
        {
            List<Prestito> list;

            using(var ctx = new RecapLibrContext())
            {
                list = ctx.Prestitos.ToList();
            }

            return list;
        }

        public Prestito? GetById(int id)
        {
            Prestito? obj;

            using (var ctx = new RecapLibrContext())
            {
                obj = ctx.Prestitos.FirstOrDefault(l => l.PrestitoId == id);
            }

            return obj;
        }

        public bool Insert(Prestito t)
        {
            bool risultato = false;

            using (var ctx = new RecapLibrContext())
            {
                try
                {
                    ctx.Prestitos.Add(t);
                    ctx.SaveChanges();

                    risultato = true;
                } catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);  
                }
            }

            return risultato;
        }

        public List<Prestito> GetPrestitoByUtenteId(int utenteId)
        {
            List<Prestito> risultato = new List<Prestito>();
            
            using (var ctx = new RecapLibrContext())
            {
                risultato = ctx.Prestitos.Where(p => p.UtenteRif == utenteId).ToList();
            }

            return risultato;
        }

    }
}

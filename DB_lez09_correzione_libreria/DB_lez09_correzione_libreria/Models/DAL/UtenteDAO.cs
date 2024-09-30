using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_lez09_correzione_libreria.Models.DAL
{
    internal class UtenteDAO : IDao<Utente>
    {
        private static UtenteDAO? instance;

        public static UtenteDAO GetInstance()
        {
            if(instance == null)
                instance = new UtenteDAO();

            return instance;
        }
        private UtenteDAO() { }

        public List<Utente> GetAll()
        {
            List<Utente> list;

            using(var ctx = new RecapLibrContext())
            {
                list = ctx.Utentes.ToList();
            }

            return list;
        }

        public Utente? GetById(int id)
        {
            Utente? obj;

            using (var ctx = new RecapLibrContext())
            {
                obj = ctx.Utentes.FirstOrDefault(l => l.UtenteId == id);
            }

            return obj;
        }

        public Utente? GetByCodice(string codice)        //Non presente nell'interfaccia
        {
            Utente? ute;

            using (var ctx = new RecapLibrContext())
            {
                ute = ctx.Utentes.FirstOrDefault(l => l.CodUtente == codice);
            }

            return ute;
        }

        public Utente? GetByCodiceConPrenotazioni(string codice)        //Non presente nell'interfaccia
        {
            Utente? ute;

            using (var ctx = new RecapLibrContext())
            {
                ute = ctx.Utentes.FirstOrDefault(l => l.CodUtente == codice);
            }

            if (ute is not null)
                ute.Prestitos = PrestitoDAO.GetInstance().GetPrestitoByUtenteId(ute.UtenteId);

            return ute;
        }

        public bool Insert(Utente t)
        {
            bool risultato = false;

            using (var ctx = new RecapLibrContext())
            {
                try
                {
                    ctx.Utentes.Add(t);
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

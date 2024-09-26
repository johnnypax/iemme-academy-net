using DB_lez06_task_edicola.Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_lez06_task_edicola.Models
{
    internal class Edicola
    {
        private static Edicola? instance;
        private List<Oggetto> elencoOggetti = new List<Oggetto>();

        public static Edicola GetInstance()
        {
            if (instance == null)
                instance = new Edicola();

            return instance;
        }

        private Edicola() { }

        public bool InserisciRivista(double varPrezzo, string varTitolo, string varCasaEd)
        {
            bool risultato = false;

            Rivista riv = new Rivista()
            {
                Titolo = varTitolo,
                CasaEd = varCasaEd,
                Prezzo = varPrezzo
            };

            if (RivistaDAO.GetInstance().Insert(riv))
                risultato = true;            

            return risultato;
        }

        public void StampaOggetti()
        {
            foreach (Oggetto o in elencoOggetti)
            {
                Console.WriteLine(o);
            }
        }

        public void RecuperaTutto()
        {
            List<Rivista> riviste = RivistaDAO.GetInstance().GetAll();
            List<Giocattolo> giocattoli = GiocattoloDAO.GetInstance().GetAll();

            if (riviste is not null && giocattoli is not null)
            {
                elencoOggetti.AddRange(riviste);
                elencoOggetti.AddRange(giocattoli);
            }
        }

        public void StampaRiviste()
        {
            RecuperaTutto();

            var risultato = from o in elencoOggetti
                            where o.GetType() == typeof(Rivista)
                            select o;

            foreach(var r in risultato)
            {
                Console.WriteLine(r);
            }
        }

        public void StampaGiocattoli()
        {
            RecuperaTutto();

            var risultato = elencoOggetti.Where(o => o.GetType() == typeof(Giocattolo));

            foreach (var r in risultato)
            {
                Console.WriteLine(r);
            }
        }
    }
}

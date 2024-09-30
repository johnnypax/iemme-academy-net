using DB_lez09_correzione_libreria.Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_lez09_correzione_libreria.Models
{
    internal class Biblioteca
    {
        private static Biblioteca? instance;

        public static Biblioteca GetInstance()
        {
            if (instance == null)
                instance = new Biblioteca();

            return instance;
        }
        private Biblioteca() { }

        public bool AggiungiLibro(string varTitolo, int varAnno)
        {
            Libro lib = new Libro()
            {
                Titolo = varTitolo,
                AnnoPub = varAnno
            };

            return LibroDAO.GetInstance().Insert(lib);
        }

        public bool AggiungiPrenotazione(string varCodUtente, string varCodLibro)
        {
            bool risultato = false;

            Libro? lib = LibroDAO.GetInstance().GetByCodice(varCodLibro);

            if (lib is not null && lib.StatoDis == true)
            {
                Utente? ute = UtenteDAO.GetInstance().GetByCodice(varCodUtente);

                if (ute is not null)
                {
                    Prestito pre = new Prestito()
                    {
                        DataPres = DateOnly.FromDateTime(DateTime.Now),
                        UtenteRifNavigation = ute,
                        LibroRifNavigation = lib,
                    };

                    risultato = PrestitoDAO.GetInstance().Insert(pre);
                }

            }

            return risultato;
        }

        public void StampaUtenteConPrenotazioni(string varCodUtente)
        {
            Utente? ute = UtenteDAO.GetInstance().GetByCodiceConPrenotazioni(varCodUtente);

            Console.WriteLine(ute);
        }

    }
}

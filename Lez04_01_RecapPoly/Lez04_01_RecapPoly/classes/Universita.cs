using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez04_01_RecapPoly.classes
{
    internal class Universita
    {
        public string? Nome { get; set; }
        public string? Indirizzo { get; set; }
        public string? Facolta { get; set; }
        public List<Persona> Elenco { get; set; } = new List<Persona>();    //AGGREGAZIONE

        #region Inserimenti
        public void AggiungiStudente(Studente objStu)
        {
            Elenco.Add(objStu);
            Console.WriteLine("Studente aggiunto con successo");
        }

        public void AggiungiDocente(Docente objDoc)
        {
            Elenco.Add(objDoc);
            Console.WriteLine("Docente aggiunto con successo");
        }
        #endregion

        #region Stampa
        public void StampaTutti()
        {
            foreach(Persona per in Elenco)
            {
                Console.WriteLine(per.ToString());
            }
        }

        public void StampaStudenti()
        {
            foreach (Persona per in Elenco)
            {
                if (per.GetType() == typeof(Studente))
                    Console.WriteLine(per.ToString());
            }
        }
        public void StampaDocenti()
        {
            foreach (Persona per in Elenco)
            {
                if (per.GetType() == typeof(Docente))
                    Console.WriteLine(per.ToString());
            }
        }

        public void StampaCertificatiStudentiElenco()
        {
            foreach(Persona per in Elenco)
            {
                if(per.GetType() == typeof(Studente))
                {
                    Studente stu = (Studente)per;
                    stu.StampaCartaInt();
                }
            }
        }
        #endregion
    }
}

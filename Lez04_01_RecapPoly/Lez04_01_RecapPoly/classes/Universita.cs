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
        #endregion
    }
}

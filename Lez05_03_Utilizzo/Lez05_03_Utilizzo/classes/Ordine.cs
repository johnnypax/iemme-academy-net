using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez05_03_Utilizzo.classes
{
    internal class Ordine
    {
        #region Composizione
        //public List<Oggetto>? Elenco { get; set; }

        //public void AggiungiOggetto(Oggetto ogg)
        //{
        //    if (Elenco is null)
        //        Elenco = new List<Oggetto>();

        //    Elenco.Add(ogg);
        //}
        #endregion

        public string? Codice { get; set; }
        public Indirizzo? Spedizione { get; set; }
        public Indirizzo? Fatturazione { get; set; }

        public override string ToString()
        {
            return $"Codice: {Codice} \n " +
                $"Spedizione: {Spedizione} \n " +
                $"Fatturazione:{Fatturazione}";
        }



    }
}

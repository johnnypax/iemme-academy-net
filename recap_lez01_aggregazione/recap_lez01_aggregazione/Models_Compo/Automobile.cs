using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recap_lez01_aggregazione.Models_Compo
{
    internal class Automobile
    {
        public List<Componente>? Elenco { get; set; }

        public void AggiungiComponente(Componente comp)
        {
            if(Elenco is null)
                Elenco = new List<Componente>();

            Elenco.Add(comp);
        }

        public void EliminaComponente(Componente com)
        {
            if(Elenco is not null)
            {
                Elenco.Remove(com);

                if (Elenco.Count() == 0)
                    Elenco = null;
            }
        }
    }
}

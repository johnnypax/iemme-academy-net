using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recap_lez01_aggregazione.Eredita
{
    internal abstract class Personaggio
    {
        public string? Nome { get; set; }
        public string? Cognome { get; set; }


        public Personaggio() { 
        
        }

        public Personaggio(string varNome, string varCognome)
        {
            Nome = varNome; 
            Cognome = varCognome;
        }

        public void StampaPersonaggio()
        {

        }
    }
}

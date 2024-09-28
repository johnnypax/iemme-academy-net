using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recap_lez01_aggregazione.Models
{
    internal class Persona
    {
        public string? Nominativo { get; set; }
        public int Eta { get; set; }

        public Persona(string varNominativo,  int varEta)
        {
            Nominativo = varNominativo;
            Eta = varEta;
        }

    }
}

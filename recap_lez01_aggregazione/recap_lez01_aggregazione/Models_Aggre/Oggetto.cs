using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recap_lez01_aggregazione.Models
{
    internal abstract class Oggetto
    {
        public float Prezzo { get; set; }
        public string Codice { get; set; } = null!;
    }
}

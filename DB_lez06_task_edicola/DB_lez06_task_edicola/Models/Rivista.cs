using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_lez06_task_edicola.Models
{
    internal class Rivista : Oggetto
    {
        public string Titolo { get; set; } = null!;
        public string CasaEd { get; set; } = null!;

        public override string ToString()
        {
            return $"[RIVISTA] {Codice} {Prezzo} {Titolo} {CasaEd}";
        }

    }
}

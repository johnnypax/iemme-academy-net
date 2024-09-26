using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_lez06_task_edicola.Models
{
    internal class Giocattolo : Oggetto
    {
        public string Materiale { get; set; } = null!;
        public int EtaMin { get; set; }

        public override string ToString()
        {
            return $"[GIOCATTOLO] {Codice} {Prezzo} {Materiale} {EtaMin}";
        }
    }
}

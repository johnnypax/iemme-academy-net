using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_lez06_task_edicola.Models
{
    internal abstract class Oggetto
    {
        public int Id { get; set; }
        public string Codice { get; set; } = null!;
        public double Prezzo { get; set; } = 0;

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_lez03_dal_refactor.classes
{
    internal class Dipendente
    {
        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public string Cogn { get; set; } = null!;
        public string? Dipa { get; set; }
        public string Iden { get; set; } = null!;
        public int Sala { get; set; }

        public override string ToString()
        {
            return $"[DIPENDENTE] {Id} {Nome} {Cogn} {Dipa} {Iden} {Sala}";
        }
    }
}

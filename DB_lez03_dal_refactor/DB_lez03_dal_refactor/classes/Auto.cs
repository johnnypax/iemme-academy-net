using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_lez03_dal_refactor.classes
{
    internal class Auto
    {
        public int Id { get; set; }
        public string Targa { get; set; } = null!;
        public string Modello { get; set; } = null!;
    }
}

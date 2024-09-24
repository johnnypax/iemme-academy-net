using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_lez03_dal_refactor.classes
{
    internal class Asset
    {
        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public int Quan { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez03_06.classes
{
    internal abstract class Animale
    {
        public bool HasPelo { get; set; }
        public int NumZampe { get; set; }
        public bool Vola { get; set; }

        public abstract void VersoEmesso();
    }
}

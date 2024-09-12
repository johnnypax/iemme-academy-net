using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez03_06.classes
{
    internal class Coccodrillo : Animale
    {
        public bool HasSquame { get; set; }

        public override void VersoEmesso()
        {
            Console.WriteLine("Non c'è nessuno che lo sa");
        }
    }
}

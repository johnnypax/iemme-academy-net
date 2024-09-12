using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez03_06.classes
{
    internal class Gatto : Animale
    {
        public string? Colore { get; set; }

        public override void VersoEmesso()
        {
            Console.WriteLine("Miau miau");
        }
    }
}

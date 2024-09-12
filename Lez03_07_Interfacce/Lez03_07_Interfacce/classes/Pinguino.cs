using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez03_07_Interfacce.classes
{
    internal class Pinguino : IAnimale
    {
        public string? Colore { get; set; }

        public void TipoMovimento()
        {
            Console.WriteLine("Ciondola");
        }

        public void VersoEmesso()
        {
            Console.WriteLine("Boh...");
        }
    }
}

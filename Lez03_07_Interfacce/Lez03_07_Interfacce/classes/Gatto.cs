using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez03_07_Interfacce.classes
{
    internal class Gatto : IAnimale
    {
        public bool HasPelo { get; set; }
        public string? Colore { get; set; }
        public string? NumZampe { get; set; }

        public void TipoMovimento()
        {
            Console.WriteLine("Cammina");
        }

        public void VersoEmesso()
        {
            Console.WriteLine("Miau Miau");
        }
    }
}

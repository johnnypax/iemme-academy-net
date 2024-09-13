using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez04_04_statici.classes
{
    internal class Studente
    {
        private static int contatore = 0;
        public string? Nominativo { get; set; }
        public string? Matricola { get; set; }

        public Studente()
        {
            contatore++;
        }

        public static int getContatore()
        {
            return contatore;
        }
    }
}

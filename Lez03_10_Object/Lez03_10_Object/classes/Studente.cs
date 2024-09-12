using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez03_10_Object.classes
{
    internal class Studente : Persona
    {
        public string? Matricola { get; set; }

        public override string ToString()
        {
            return $"[Studente] {Nominativo} {Matricola}";
        }

    }
}

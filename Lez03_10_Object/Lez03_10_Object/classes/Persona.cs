using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez03_10_Object.classes
{
    internal class Persona : Object
    {
        public string? Nominativo { get; set; }

        public override string ToString()
        {
            return $"[Persona] {Nominativo}";
        }
    }
}

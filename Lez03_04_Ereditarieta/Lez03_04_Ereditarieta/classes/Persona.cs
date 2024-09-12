using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez03_04_Ereditarieta.classes
{
    internal class Persona
    {
        public string? Nome { get; set; }
        public string? Cognome { get; set; }

        public virtual void StampaDettaglio()
        {
            Console.WriteLine($"[Persona] {Nome} {Cognome}");
        }
    }
}

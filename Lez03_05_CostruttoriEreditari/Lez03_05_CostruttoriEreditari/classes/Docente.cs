using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez03_05_CostruttoriEreditari.classes
{
    internal class Docente : Persona
    {
        public string? Dipartimento { get; set; }

        public Docente()
        {
            Console.WriteLine("Sono il costruttore di DOCENTE");
        }

        public override void StampaDettaglio()
        {
            Console.WriteLine($"[Docente] {Nome} {Cognome} {Dipartimento}");
        }
    }
}

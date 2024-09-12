using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez03_05_CostruttoriEreditari.classes
{
    internal class Persona
    {
        public string? Nome { get; set; }
        public string? Cognome { get; set; }
        public Persona() {
            Console.WriteLine("Default di persona");
        }

        public Persona(string varNome, string varCognome)
        {
            this.Nome = varNome;
            this.Cognome = varCognome;
            Console.WriteLine("Due parametri di persona");
        }
        public virtual void StampaDettaglio()
        {
            Console.WriteLine($"[Persona] {Nome} {Cognome}");
        }
    }
}

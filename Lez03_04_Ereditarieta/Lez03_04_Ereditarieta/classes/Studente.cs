using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez03_04_Ereditarieta.classes
{
    internal class Studente : Persona
    {
        public string? Matricola { get; set; }

        public override void StampaDettaglio()
        {
            Console.WriteLine($"" +
                $"[Studente] {Nome} {Cognome} {Matricola}");
        }
    }
}

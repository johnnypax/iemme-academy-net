using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez03_05_CostruttoriEreditari.classes
{
    internal class Studente : Persona
    {
        public string? Matricola { get; set; }

        public Studente(string varNome, string varCognome, string varMatricola)
        {
            base.Nome = varNome;
            base.Cognome = varCognome;
            this.Matricola = varMatricola;
        }

        public override void StampaDettaglio()
        {
            Console.WriteLine($"" +
                $"[Studente] {Nome} {Cognome} {Matricola}");
        }
    }
}

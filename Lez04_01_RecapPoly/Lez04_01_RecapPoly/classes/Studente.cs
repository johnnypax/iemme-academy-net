using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez04_01_RecapPoly.classes
{
    internal class Studente : Persona
    {
        public string? Matricola { get; set; }
        public string? Corso { get; set; }

        public Studente() { }

        public Studente(string varNome, string varCognome, string varCodFis, string varMatr, string varCorso)
        {
            Nome = varNome;
            Cognome = varCognome;
            CodFis = varCodFis;
            Matricola = varMatr;
            Corso = varCorso;
        }

        public override string ToString()
        {
            return $"[Studente] {Nome} {Cognome} {CodFis} {Matricola} {Corso}";
        }

        public void StampaCartaInt()
        {
            Console.WriteLine("-------------------- *** -------------------");
            Console.WriteLine($" Lo studente: {Nome} {Cognome}");
            Console.WriteLine($" Iscritto al corso di: {Corso}");
            Console.WriteLine("-------------------- *** -------------------");
        }
    }
}

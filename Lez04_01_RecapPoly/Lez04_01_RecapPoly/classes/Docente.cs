using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez04_01_RecapPoly.classes
{
    internal class Docente : Persona
    {
        public string? Dipartimento { get; set; }
        public bool IsPresidente { get; set; } = false;

        public Docente(string varNome, string varCognome, string varCodFis, string varDipartimento, bool varPresidente)
        {
            Nome = varNome;
            Cognome = varCognome;
            CodFis = varCodFis;
            Dipartimento = varDipartimento;
            IsPresidente = varPresidente;
        }

        public override string ToString()
        {
            return $"[Docente] {Nome} {Cognome} {CodFis} {Dipartimento} {IsPresidente}";
        }

        public void DettaglioDocente()
        {
            Console.WriteLine("-------------DOCENTE-------------");
            Console.WriteLine($"Sono il docente: {Nome} {Cognome}");
            Console.WriteLine($"LAVORO AL DIPARTIMENTO: {Dipartimento}");
            Console.WriteLine("---------------------------------");
        }
    }
}

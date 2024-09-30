using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez06_01_protected.Models
{
    internal class Studente : Persona
    {
        public string? Matricola { get; set; }

        public Studente(string varNome, string varCognome, string varMatr)
        {
            Matricola = varMatr;
            Nome = varNome;
            Cognome = varCognome;
            Titolo = "Stud.";
        }
    }
}

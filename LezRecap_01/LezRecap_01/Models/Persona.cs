using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LezRecap_01.Models
{
    internal class Persona
    {
        public string? Nome { get; set; }
        public string? Cognome { get; set; }
        public string? CodFis { get; set; }

        public override string ToString()
        {
            return $"{Nome} {Cognome} {CodFis}";
        }

        public override bool Equals(object? obj)
        {
            bool risultato = false;

            if(obj is not null && obj.GetType() == typeof(Persona))
            {
                Persona temp = (Persona)obj;

                if(temp.Nome == this.Nome && temp.Cognome == this.Cognome && temp.CodFis == this.CodFis)
                    risultato = true;
            }

            return risultato;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() + 999;
        }
    }
}

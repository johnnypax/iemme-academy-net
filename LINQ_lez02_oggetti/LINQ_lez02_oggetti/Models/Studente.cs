using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_lez02_oggetti.Models
{
    internal class Studente
    {
        public string? Nominativo { get; set; }
        public int Eta { get; set; }
        public string? Matricola { get; set; }

        public override string ToString()
        {
            return $"{Nominativo} {Eta} {Matricola}";
        }
    }
}

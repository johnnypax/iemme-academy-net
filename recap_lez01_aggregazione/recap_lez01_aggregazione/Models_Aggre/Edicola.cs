using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recap_lez01_aggregazione.Models
{
    internal class Edicola
    {
        public string? Nome { get; set; }
        public ICollection<Oggetto> Elenco { get; set; } = new List<Oggetto>();

        public Edicola(string varNome)
        {
            Nome = varNome;
        }

        public void AggiungiOggetto(Oggetto ogg)
        {
            Elenco.Add(ogg);
        }

        public void EliminaComponente(Oggetto ogg)
        {
            Elenco.Remove(ogg);
        }

        // void Saluta(string)
        public void Saluta(string varNome)
        {
            Console.WriteLine(varNome);
        }

        // void Saluta(string, string)
        public void Saluta(string varNome, string varCognome)
        {
            Console.WriteLine(varNome + varCognome);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_lez05_taskino.Models
{
    internal class Prodotto
    {
        public string Nome { get; set; } = null!;
        public string Descrizione { get; set; } = null!;
        public float Prezzo { get; set; } = 0;
        public string Categoria { get; set; } = null!;
        public float Quantita { get; set; } = 0;

        public Prodotto() { }
        public Prodotto(string nome, string descrizione, float prezzo, string categoria, float quantita)
        {
            Nome = nome;
            Descrizione = descrizione;
            Prezzo = prezzo;
            Categoria = categoria;
            Quantita = quantita;
        }

        public override string ToString()
        {
            return $"[Prodotto] {Nome} {Descrizione} {Prezzo} {Categoria} {Quantita}";
        }
    }
}

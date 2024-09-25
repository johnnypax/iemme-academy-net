using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_lez03_raggruppamenti.Models
{
    internal class Libro
    {
        public int Id { get; set; }
        public string? Titolo { get; set; }
        public string? Autore { get; set; }
        public string? Categoria { get; set; }

        public Libro(string? titolo, string? autore, string? categoria)
        {
            Titolo = titolo;
            Autore = autore;
            Categoria = categoria;
        }

        public Libro(int id, string? titolo, string? autore, string? categoria)
        {
            Id = id;
            Titolo = titolo;
            Autore = autore;
            Categoria = categoria;
        }

        public override string ToString()
        {
            return $"[LIBRO] {Id} {Titolo} {Autore} {Categoria}";
        }
    }
}

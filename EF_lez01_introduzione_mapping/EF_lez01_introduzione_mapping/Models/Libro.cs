using System;
using System.Collections.Generic;

namespace EF_lez01_introduzione_mapping.Models;

public partial class Libro
{
    public int LibroId { get; set; }

    public string Titolo { get; set; } = null!;

    public string Autore { get; set; } = null!;

    public int Pagine { get; set; }

    public string Editore { get; set; } = null!;

    public string Isbn { get; set; } = null!;

    public override string ToString()
    {
        return $"[LIBRO] {LibroId} {Titolo} {Autore} {Pagine} {Isbn}";
    }
}

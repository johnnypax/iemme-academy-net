using System;
using System.Collections.Generic;

namespace REST_04_EF_Videoteche.Models;

public partial class Videoteca
{
    public int VideotecaId { get; set; }

    public string Codice { get; set; } = null!;

    public string Nome { get; set; } = null!;

    public string? Indirizzo { get; set; }

    public virtual ICollection<Supporto> Supportos { get; set; } = new List<Supporto>();
}

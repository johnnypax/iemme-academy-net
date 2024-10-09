using System;
using System.Collections.Generic;

namespace REST_03_EF_ferramenta.Models;

public partial class Prodotto
{
    public int ProdottoId { get; set; }

    public string CodiceBarre { get; set; } = null!;

    public string Nome { get; set; } = null!;

    public string? Descrizione { get; set; }

    public decimal? Prezzo { get; set; }

    public int Quantita { get; set; }

    public int RepartoRif { get; set; }

    public virtual Reparto RepartoRifNavigation { get; set; } = null!;
}

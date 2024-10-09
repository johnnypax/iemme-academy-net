using System;
using System.Collections.Generic;

namespace REST_03_EF_ferramenta.Models;

public partial class Reparto
{
    public int RepartoId { get; set; }

    public string RepartoCod { get; set; } = null!;

    public string Nome { get; set; } = null!;

    public string Fila { get; set; } = null!;

    public virtual ICollection<Prodotto> Prodottos { get; set; } = new List<Prodotto>();
}

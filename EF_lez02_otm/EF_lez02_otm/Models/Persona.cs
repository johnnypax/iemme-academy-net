using System;
using System.Collections.Generic;

namespace EF_lez02_otm.Models;

public partial class Persona
{
    public int PersonaId { get; set; }

    public string Nome { get; set; } = null!;

    public string Cognome { get; set; } = null!;

    public string? Email { get; set; }

    public virtual ICollection<Cartum> Carta { get; set; } = new List<Cartum>();

    public string StampaDettaglio()
    {
        return $"[PERSONA] {Nome} {Cognome} {Email}";
    }
}

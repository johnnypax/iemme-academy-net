using System;
using System.Collections.Generic;

namespace WPF_lez04_Contatti.Models;

public partial class Contatto
{
    public int ContattoId { get; set; }

    public string Nome { get; set; } = null!;

    public string Cognome { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string CodFis { get; set; } = null!;
}

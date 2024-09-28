using System;
using System.Collections.Generic;

namespace RECAP_01_libreria.Models;

public partial class Prestito
{
    public int PrestitoId { get; set; }

    public DateOnly DataPres { get; set; }

    public DateOnly? DataRit { get; set; }

    public int? UtenteRif { get; set; }

    public int? LibroRif { get; set; }

    public virtual Libro? LibroRifNavigation { get; set; }

    public virtual Utente? UtenteRifNavigation { get; set; }
}

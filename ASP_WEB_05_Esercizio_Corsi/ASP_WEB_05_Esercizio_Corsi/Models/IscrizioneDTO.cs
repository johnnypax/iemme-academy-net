using System.ComponentModel.DataAnnotations.Schema;

namespace ASP_WEB_05_Esercizio_Corsi.Models
{
    public class IscrizioneDTO
    {
        public string? Codice { get; set; }
        public string Nome { get; set; } = null!;
        public string Cognome { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? CodiceDis { get; set; }
        public CorsoDTO? CorsoIscr { get; set; }
    }
}

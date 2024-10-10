using System.ComponentModel.DataAnnotations.Schema;

namespace REST_05_EF_Videoteche_Ref.Models
{
    [Table("Videoteca")]
    public class Videoteca
    {
        public int VideotecaID { get; set; }
        public string Codice { get; set; } = null!;
        public string Nome { get; set; } = null!;
        public string? Indirizzo { get; set; }
    }
}

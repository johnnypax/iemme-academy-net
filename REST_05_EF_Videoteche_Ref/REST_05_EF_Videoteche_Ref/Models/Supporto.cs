using System.ComponentModel.DataAnnotations.Schema;

namespace REST_05_EF_Videoteche_Ref.Models
{
    [Table("Supporto")]
    public class Supporto
    {
        public int SupportoID { get; set; }
        public string Codice { get; set; } = null!;
        public string Titolo { get; set; } = null!;
        public int Anno { get; set; }
        public int Disponibilita { get; set; }
        public string Tipo { get; set; } = null!;
        public int VideotecaRIF { get; set; }
    }
}

using System.ComponentModel.DataAnnotations.Schema;

namespace ASP_WEB_05_Esercizio_Corsi.Models
{
    [Table("Corso")]
    public class Corso
    {
        [Column]
        public int CorsoID { get; set; }
        [Column("codice")]
        public string CodCorso { get; set; } = null!;
        [Column]
        public string Nome { get; set; } = null!;
        [Column]
        public string? Descrizione { get; set; }
        [Column]
        public decimal Prezzo { get; set; }
        [Column("num_part")]
        public int MaxPartecipanti { get; set; }
        [Column("data_corso")]
        public DateTime DataCorso { get; set; }
    }
}

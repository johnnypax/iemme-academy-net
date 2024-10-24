using System.ComponentModel.DataAnnotations.Schema;

namespace esercizio_01_officina.Models
{
    [Table("Intervento")]
    public class Intervento
    {
        public int InterventoID { get; set; }
        public string Codice { get; set; } = null!;
        public string Targa { get; set; } = null!;
        public string Modello { get; set; } = null!;
        public string Marca { get; set; } = null!;
        public int Anno { get; set; }
        public decimal Prezzo { get; set; }
        public string Stato { get; set; } = null!;

        [Column("data_ingresso")]
        public DateTime DataIngresso { get; set; }      // ! attenzione
        public int ClienteRIF { get; set; }

        //public Cliente? ClienteNavigation { get; set; }

    }
}

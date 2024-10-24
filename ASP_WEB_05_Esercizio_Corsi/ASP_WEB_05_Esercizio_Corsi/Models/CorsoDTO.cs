using System.ComponentModel.DataAnnotations.Schema;

namespace ASP_WEB_05_Esercizio_Corsi.Models
{
    public class CorsoDTO
    {
        public string? Cod { get; set; }
        public string? Nom { get; set; }
        public string? Des { get; set; }
        public decimal Pre { get; set; }
        public int Par { get; set; }
        public DateTime Dat { get; set; }
    }
}

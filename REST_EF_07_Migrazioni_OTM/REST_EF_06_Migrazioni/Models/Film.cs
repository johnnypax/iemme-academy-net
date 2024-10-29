using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace REST_EF_06_Migrazioni.Models
{
    [Table("Proiezioni")]
    public class Film
    {
        [Key]
        public int FilmID { get; set; }

        [Required]
        [MaxLength(250)]
        public string Titolo { get; set; } = null!;

        [MaxLength(500)]
        public string? Descrizione { get; set; }

        [Required]
        public int Anno { get; set; }

        [MaxLength(250)]
        public string? Autore { get; set; }

        [MaxLength(250)]
        public string? Distribuzione { get; set; }

        [MaxLength(36)]
        [Required]
        public string? Codice { get; set; }

        public ICollection<Film_Categoria> FilmCatList { get; set; } = new List<Film_Categoria>();
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace REST_EF_06_Migrazioni.Models
{
    [Table("Categorie")]
    public class Categoria
    {
        [Key]
        public int CategoriaID { get; set; }

        [Required]
        [MaxLength(250)]
        public string Nome { get; set; } = null!;

        [Required]
        public string Codice { get; set; } = Guid.NewGuid().ToString();

        public ICollection<Film_Categoria> FilmCatList { get; set; } = new List<Film_Categoria>();
    }
}

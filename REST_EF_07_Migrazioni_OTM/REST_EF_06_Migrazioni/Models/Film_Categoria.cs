using Microsoft.AspNetCore.Routing.Constraints;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace REST_EF_06_Migrazioni.Models
{
    [Table("Film_Categoria")]
    public class Film_Categoria
    {
        [Key]
        public int FilmCategoriaID { get; set; }

        public int FilmRIF { get; set; }
        public int CategoriaRIF { get; set; }

        public Film? FilmNavigation { get; set; }
        public Categoria? CategoriaNavigation { get; set; }
    }
}

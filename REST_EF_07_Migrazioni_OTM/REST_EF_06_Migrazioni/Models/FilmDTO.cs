using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace REST_EF_06_Migrazioni.Models
{
    public class FilmDTO
    {
        public string Tit { get; set; } = null!;
        public string? Des { get; set; }
        public int Ann { get; set; }
        public string? Aut { get; set; }
        public string? Dis { get; set; }
        public string? Cod { get; set; }

        //public ICollection<Film_Categoria> FilmCatList { get; set; } = new List<Film_Categoria>();
    }
}

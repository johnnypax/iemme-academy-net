using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP_WEB_05_Esercizio_Corsi.Models
{
    [Table("Amministratore")]
    public class Admin
    {
        [Column("amministratoreID")]
        public int Id { get; set; }

        [Column("usern")]
        public string User { get; set; } = null!;

        [Column("passw")]
        public string Pass { get; set; } = null!;

    }
}

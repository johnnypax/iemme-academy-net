using System.ComponentModel.DataAnnotations.Schema;

namespace REST_05_EF_Videoteche_Ref.Models
{
    public class VideotecaDTO
    {
        public string? Cod { get; set; }
        public string? Nom { get; set; }
        public string? Ind { get; set; }
    }
}

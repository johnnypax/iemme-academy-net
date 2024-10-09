namespace REST_03_EF_ferramenta.Models
{
    public class RepartoDTO
    {
        public string? Cod { get; set; }

        public string Nom { get; set; } = null!;

        public string Fil { get; set; } = null!;

        public List<ProdottoDTO> Ele { get; set; } = new List<ProdottoDTO>();
    }
}

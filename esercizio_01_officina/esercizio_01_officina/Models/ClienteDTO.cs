using System.Text.Json.Serialization;

namespace esercizio_01_officina.Models
{
    public class ClienteDTO
    {
        public string? Cod { get; set; }
        public string? Nom { get; set; }
        public string? Cog { get; set; }
        public string? Ind { get; set; }
        public string? Tel { get; set; }
        public string? Ema { get; set; }

        public IEnumerable<InterventoDTO>? Interventi { get; set; }

    }
}

using System.Text.Json.Serialization;

namespace esercizio_01_officina.Models
{
    public class ClienteDTOCompleto : ClienteDTO
    {
        public IEnumerable<InterventoDTO>? Interventi { get; set; }

    }
}

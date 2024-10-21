namespace esercizio_01_officina.Models
{
    public class InterventoDTO
    {
        public string? Codice { get; set; }
        public string Targa { get; set; } = null!;
        public string Modello { get; set; } = null!;
        public string Marca { get; set; } = null!;
        public int Anno { get; set; }
        public decimal Prezzo { get; set; }
        public string Stato { get; set; } = null!;
        public DateTime DataIngresso { get; set; }      // ! attenzione

        public ClienteDTO? CliRif { get; set; }

    }
}

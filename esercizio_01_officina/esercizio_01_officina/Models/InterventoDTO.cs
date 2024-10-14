namespace esercizio_01_officina.Models
{
    public class InterventoDTO
    {
        public string? Cod { get; set; }
        public string Tar { get; set; } = null!;
        public string Mod { get; set; } = null!;
        public string Mar { get; set; } = null!;
        public int Ann { get; set; }
        public decimal Pre { get; set; }
        public string Sta { get; set; } = null!;
        public DateTime Dat { get; set; }      // ! attenzione

        public ClienteDTO? Cli { get; set; }

    }
}

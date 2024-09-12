using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez02_03_Costruttori.classes
{
    internal class Automobile
    {
        public string Marca { get; set; } = null!;
        public int Cilindrata { get; set; } = 0;
        public string Colore { get; set; } = null!;

        // Automobile()
        public Automobile()
        {
            Console.WriteLine("Sono il default!");
        }

        // Automobile(string, string)
        public Automobile(string varMarca, string varColore)
        {
            this.Marca = varMarca;
            this.Colore = varColore;

            Console.WriteLine("Sono il costruttore con 2 parametri");
        }

        // Automobile(string, int, string)
        public Automobile(string varMarca, int varCilindrata, string varColore)
        {
            this.Marca = varMarca;
            if(varCilindrata > 0)
                this.Cilindrata = varCilindrata;
            this.Colore = varColore;

            Console.WriteLine("Sono il costruttore con 3 parametri");
        }

        // Automobile(int, string, string)
        public Automobile(int varCilindrata, string varMarca, string varColore)
        {
            this.Marca = varMarca;
            if (varCilindrata > 0)
                this.Cilindrata = varCilindrata;
            this.Colore = varColore;

            Console.WriteLine("Sono il costruttore con 3 parametri secondario");
        }

        public void StampaDettaglio()
        {
            Console.WriteLine($"[Automobile] {Marca} {Cilindrata} {Colore}");
        }

        public override string ToString()
        {
            return $"[Automobile] {Marca} {Cilindrata} {Colore}";
        }
    }
}

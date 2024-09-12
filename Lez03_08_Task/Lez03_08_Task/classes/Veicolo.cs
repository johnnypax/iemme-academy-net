using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez03_08_Task.classes
{
    internal abstract class Veicolo
    {
        public string? Targa { get; set; }
        public string? Colore { get; set; }
        public string? Marca { get; set; }
        public string? Modello { get; set; }

        public Veicolo() { }

        public virtual void StampaDettaglio()
        {
            Console.WriteLine($"[Veicolo] {Targa} {Colore} {Marca} {Modello}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez03_09_Poly.classes
{
    internal class Automobile : Veicolo
    {
        public int Porte { get; set; }
        public int Posti { get; set; }

        public override void StampaDettaglio()
        {
            Console.WriteLine($"[Automobile] {Targa} {Colore} {Marca} {Modello} {Porte} {Posti}");
        }

        public void SuonaNelTraffico()
        {
            Console.WriteLine("Bip bip");
        }
    }
}

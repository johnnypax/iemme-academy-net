using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez02_05_ClassiEdOggetti.classes
{
    internal class Automobile
    {
        private string? modello;
        private string? colore;
        private int? cilindrata;

        public void StampaDettaglio()
        {
            Console.WriteLine($"Modello: {modello}\nColore: {colore}\nCilindrata: {cilindrata}\n");
        }
    }
}

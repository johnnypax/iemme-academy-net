using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez03_02_Properties.classes
{
    internal class Bottiglia
    {
        public string? Materiale { get; set; }
        public string? Marca { get; set; }

        private float altezza = 0;

        public float Altezza
        {
            get { return altezza; }
            set {
                if (value > 0)
                    altezza = value;
                else
                    Console.WriteLine("Errore di altezza");
            }
        }

        private float diametro = 0;

        public float Diametro
        {
            get { return diametro; }
            set { 
                if (value > 0)
                    diametro = value;
                else
                    Console.WriteLine("Errore di diametro");
            }
        }

        public float CalcolaVolume()
        {
            float raggio = diametro / 2;
            float area = (float)Math.PI * (raggio * raggio);
            return area * altezza;
        }



    }
}

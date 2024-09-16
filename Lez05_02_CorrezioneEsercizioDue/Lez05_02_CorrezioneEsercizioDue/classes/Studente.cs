using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez05_02_CorrezioneEsercizioDue.classes
{
    internal class Studente
    {
        public string? Nome { get; set; }
        public string? Cognome { get; set; }

        private double voto;

        public double Voto
        {
            get { return voto; }
            set {
                if (value >= 0 && value <= 10)
                    voto = value;
                else
                    Console.WriteLine("Voto non ammesso");
            }
        }

        public override string ToString()
        {
            return $"{Nome} {Cognome} {Voto}";
        }

    }
}

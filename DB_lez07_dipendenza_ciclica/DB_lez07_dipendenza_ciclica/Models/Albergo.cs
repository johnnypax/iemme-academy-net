using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_lez07_dipendenza_ciclica.Models
{
    internal class Albergo
    {
        public string Nome { get; set; } = null!;
        public string Indirizzo { get; set; } = null!;
        public int Stelle { get; set; } = 1;

        public List<Camera>? Camere { get; set; } = null;

        public void AggiungiCamera(Camera cam)
        {
            if(Camere is null)
                Camere = new List<Camera>();

            Camere.Add(cam);

            Console.WriteLine("Camera aggiunta con successo");
        }

        public string StampaDettaglio()
        {
            return $"[ALBERGO] {Nome} {Indirizzo} {Stelle}";
        }

        public override string ToString()
        {
            string camereString = "";
            if(Camere is not null)
                foreach(Camera cam in Camere)
                {
                    camereString += cam.StringaDettaglio();
                }

            return $"[ALBERGO] {Nome} {Indirizzo} {Stelle} Elenco: [{camereString}]";
        }
    }
}

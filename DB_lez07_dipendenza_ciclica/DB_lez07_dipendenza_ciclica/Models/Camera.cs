using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_lez07_dipendenza_ciclica.Models
{
    internal class Camera
    {
        public string Codice { get; set; } = null!;
        public int Posti { get; set; } = 1;
        public string Descrizione { get; set; } = null!;
        public Albergo? AlbApparten { get; private set; }

        public Camera(Albergo albApparten)
        {
            AlbApparten = albApparten;
        }

        public Camera(string codice, int posti, string descrizione, Albergo albApparten)
        {
            Codice = codice;
            Posti = posti;
            Descrizione = descrizione;
            AlbApparten = albApparten;
        }

        public override string ToString()
        {
            string albergo = AlbApparten is not null ? AlbApparten.StampaDettaglio() : "";

            return $"[CAMERA] {Codice} {Posti} {Descrizione} {albergo}";
        }
        public string StringaDettaglio()
        {
            return $"[CAMERA] {Codice} {Posti} {Descrizione}";
        }
    }
}

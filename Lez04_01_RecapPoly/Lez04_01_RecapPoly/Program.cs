using Lez04_01_RecapPoly.classes;

namespace Lez04_01_RecapPoly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Creare un sistema di gestione scolastica dove le informazioni di cui abbiamo bisogno sono:
             * - Studente
             * - Docente
             */

            //Persona gio = new Studente("Giovanni", "Pace", "PCAGNN", "AB1234", "Informatica");
            //Persona val = new Studente("Valeria", "Verdi", "VLRVRD", "AB1235", "Ingegneria");

            //Persona doc = new Docente("Marika", "Mariko", "MRKMRK", "Informatica", true);

            //List<Persona> elenco = new List<Persona>();
            //elenco.Add(gio);
            //elenco.Add(val);
            //elenco.Add(doc);

            //foreach(Persona per in elenco)
            //{
            //    if(per.GetType() == typeof(Studente))
            //    {
            //        Studente stu = (Studente)per;
            //        stu.StampaCartaInt();
            //    }

            //    if(per.GetType() == typeof(Docente))
            //    {
            //        Docente d = (Docente)per;
            //        d.DettaglioDocente();
            //    }

            //}

            //-----------------------------------------------------------------

            Studente gio = new Studente("Giovanni", "Pace", "PCAGNN", "AB1234", "Informatica");
            Studente val = new Studente("Valeria", "Verdi", "VLRVRD", "AB1235", "Ingegneria");

            Docente doc = new Docente("Marika", "Mariko", "MRKMRK", "Informatica", true);

            Universita iemacademy = new Universita();
            iemacademy.AggiungiStudente(gio);
            iemacademy.AggiungiStudente(val);
            iemacademy.AggiungiDocente(doc);

            iemacademy.StampaTutti();
        }
    }
}

using Lez03_05_CostruttoriEreditari.classes;

namespace Lez03_05_CostruttoriEreditari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Studente gio = new Studente("Giovanni", "Pace", "AB12345");
            gio.StampaDettaglio();

            Persona per = new Persona("Mario", "Rossi");
            Persona perDue = new Persona();

            //Docente doc = new Docente();
            //doc.StampaDettaglio();
        }
    }
}

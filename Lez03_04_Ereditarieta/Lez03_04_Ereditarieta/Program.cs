using Lez03_04_Ereditarieta.classes;

namespace Lez03_04_Ereditarieta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Studente gio = new Studente();
            gio.Nome = "Giovanni";
            gio.Cognome = "Pace";
            gio.Matricola = "AB1234";
            gio.StampaDettaglio();

            Docente doc = new Docente();
            doc.Nome = "Valeria";
            doc.Cognome = "Verdi";
            doc.Dipartimento = "Ing.";
            doc.StampaDettaglio();
        }
    }
}

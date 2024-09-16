using Lez05_02_CorrezioneEsercizioDue.classes;

namespace Lez05_02_CorrezioneEsercizioDue
{
    internal class Program
    {
        static void Main(string[] args)
        {

            GestoreStudente ges = new GestoreStudente();
            ges.AggiungiStudente(new Studente() { Nome = "Valeria", Cognome = "Verdi", Voto = 9 });
            ges.AggiungiStudente(new Studente() { Nome = "Giovanni", Cognome = "Pace", Voto = 1});

            ges.ModificaStudente(
                new Studente() { Nome = "Giovanni", Cognome = "Pace" },
                new Studente() { Nome = "Giovanna", Cognome = "Paci", Voto = 5 });


            ges.StampaStudenti();

        }
    }
}

using Lez02_05_ClassiEdOggetti.classes;

namespace Lez02_05_ClassiEdOggetti
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Automobile ford = new Automobile();
            ford.colore = "Blu";
            ford.cilindrata = 2000;
            ford.modello = "Focus";
            ford.StampaDettaglio();

            Automobile fiat = new Automobile();
            fiat.colore = null;
            fiat.cilindrata = -1200;
            fiat.modello = "Panda";
            fiat.StampaDettaglio();

            Automobile ferrari = new Automobile();
            ferrari.colore = "Rosso";
            ferrari.cilindrata = 3000;
            ferrari.modello = "Modena";
            ferrari.StampaDettaglio();


        }
    }
}

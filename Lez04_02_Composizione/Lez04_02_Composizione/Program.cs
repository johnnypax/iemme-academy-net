using Lez04_02_Composizione.classes;

namespace Lez04_02_Composizione
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fiore ros = new Fiore();
            Fiore vio = new Fiore();
            Fiore cal = new Fiore();

            Mazzo ma = new Mazzo();
            ma.AggiungiFiore(ros);
            ma.AggiungiFiore(vio);
            ma.AggiungiFiore(cal);
        }
    }
}

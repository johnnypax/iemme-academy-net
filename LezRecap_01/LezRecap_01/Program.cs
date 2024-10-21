using LezRecap_01.Models;

namespace LezRecap_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona gio = new Persona()
            {
                Nome = "Giovanni",
                Cognome = "Pace",
                CodFis = "PCAGNN"
            };

            Persona val = new Persona()
            {
                Nome = "Giovanni",
                Cognome = "Pace",
                CodFis = "PCAGNN"
            };

            Persona mar = gio;

            Console.WriteLine(gio.GetHashCode());
            Console.WriteLine(mar.GetHashCode());
        }
    }
}

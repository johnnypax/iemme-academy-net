using Lez03_06.classes;

namespace Lez03_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Animale ani = new Animale(); //NON POSSIBILE
            Gatto bu = new Gatto();
            bu.VersoEmesso();

            Cane can = new Cane();  
            can.VersoEmesso();

            Coccodrillo cocco = new Coccodrillo();
            cocco.VersoEmesso();
        }
    }
}

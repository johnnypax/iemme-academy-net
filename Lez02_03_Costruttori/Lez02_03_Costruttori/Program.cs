using Lez02_03_Costruttori.classes;

namespace Lez02_03_Costruttori
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Automobile focus = new Automobile();
            focus.Marca = "FORD";
            focus.Cilindrata = 1300;
            focus.Colore = "Rosso";
            Console.WriteLine(focus);

            Automobile panda = new Automobile();
            Console.WriteLine(panda);

            Automobile ypsilon = new Automobile("Lancia", 1200, "Giallo");
            Console.WriteLine(ypsilon);

            Automobile micra = new Automobile("Nissan", "Beige");
            Console.WriteLine(micra);

            Automobile delta = new Automobile(2000, "Lancia", "Giallo");
            Console.WriteLine(delta);



        }
    }
}

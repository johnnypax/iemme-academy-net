using Lez03_02_Properties.classes;

namespace Lez03_02_Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bottiglia acqua = new Bottiglia();
            acqua.Materiale = "PET";
            acqua.Marca = "Santa lucia";
            acqua.Altezza = 10f;
            acqua.Diametro = 11f;

            Console.WriteLine(acqua.CalcolaVolume());

        }
    }
}

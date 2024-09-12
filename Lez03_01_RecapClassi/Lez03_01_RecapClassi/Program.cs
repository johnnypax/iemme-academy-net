using Lez03_01_RecapClassi.classes;

namespace Lez03_01_RecapClassi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bottiglia acqua = new Bottiglia();
            acqua.SetAltezza(15.8f);
            acqua.SetDiametro(9.1f);

            //Console.WriteLine(
            //    acqua.CalcolaVolume());

            acqua.DettaglioGeometria();


        }
    }
}

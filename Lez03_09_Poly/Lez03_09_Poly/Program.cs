using Lez03_09_Poly.classes;

namespace Lez03_09_Poly
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Veicolo focus = new Automobile();

            Console.WriteLine(focus.GetType() == typeof(Moto));

            Veicolo panda = new Automobile();

            Veicolo honda = new Moto();
            Veicolo ducati = new Moto();

            List<Veicolo> elenco = new List<Veicolo>();
            elenco.Add(focus);
            elenco.Add(panda);
            elenco.Add(honda);
            elenco.Add(ducati);



            foreach(Veicolo vei in elenco)
            {
                //vei.Accensione();

                if(vei.GetType() == typeof(Automobile))
                {
                    Automobile au = (Automobile)vei;
                    au.SuonaNelTraffico();
                }
                    
            }


        }
    }
}

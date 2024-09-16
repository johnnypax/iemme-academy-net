using Lez05_03_Utilizzo.classes;

namespace Lez05_03_Utilizzo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Ordine ord = new Ordine()
            //{
            //    Codice = "AB1234",
            //    Spedizione = new Indirizzo()
            //    {
            //        Nominativo = "Giovanni",
            //        Via = "Le mani dal naso",
            //        Citta = "Rocca cannuccia",
            //        Cap = 1111,
            //        Provincia = "BOH"
            //    },
            //    Fatturazione = new Indirizzo()
            //    {
            //        Nominativo = "Valeria",
            //        Via = "P.zza la bomba (pasticcino) e scappa",
            //        Citta = "Rocca preturo",
            //        Cap = 1112,
            //        Provincia = "BOH"
            //    }
            //};

            //Console.WriteLine(ord.Codice);
            //Console.WriteLine(ord.Spedizione.Nominativo);

            //--------------------------------------------------------

            Indirizzo gio = new Indirizzo()
            {
                Nominativo = "Giovanni",
                Via = "Le mani dal naso",
                Citta = "Rocca cannuccia",
                Cap = 1111,
                Provincia = "BOH"
            };

            Ordine ordUno = new Ordine()
            {
                Codice = "AB1235",
                Fatturazione = gio,
                Spedizione = gio,
            };

            Ordine ordDue = new Ordine()
            {
                Codice = "CC856",
                Fatturazione = gio,
                Spedizione = gio,
            };

        }
    }
}

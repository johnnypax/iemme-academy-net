using recap_lez01_aggregazione.Eredita;
using recap_lez01_aggregazione.Models;

namespace recap_lez01_aggregazione
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] elenco = { 1, 2, 3 };

            //int somma = 0;
            //for(int i=0; i<elenco.Length; i++)
            //{
            //    somma += elenco[i];
            //}

            //float media = somma / elenco.Length;
            //Console.WriteLine(media);

            //---------------------------------------

            //int[] elenco = { 4, 6, 7 };

            //int somma = 0;
            //foreach (int num in elenco)
            //{
            //    somma += num;
            //}

            //Console.Write(somma / elenco.Length);

            //---------------------------------------
            //Numero massimo

            //int[] elenco = { 8, 6, 7 };

            //int risultato = 0;
            //for(int i=0; i<elenco.Length; i++)
            //{
            //    if (elenco[i] > risultato)
            //        risultato = elenco[i];
            //}

            //Console.WriteLine(risultato);

            //---------------------------------------
            //int[] elenco = { 8, 6, 7 };

            //int risultato = 0;
            //foreach (int num in elenco)
            //{
            //    if(num > risultato)
            //    {
            //        risultato = num;
            //    }
            //}

            //Console.WriteLine(risultato);

            //---------------------------------------

            //int[] elenco = { 8, 6, 7 };
            //Console.WriteLine(elenco.Max());

            //---------------------------------------

            //int[] elenco = { 8, 6, 7, 9, 13 };

            //int contatore = 0;
            //for(int i = 0;i < elenco.Length; i++)
            //{
            //    if (elenco[i] % 2 != 0)
            //    {
            //        //Console.WriteLine(elenco[i]);
            //        contatore++;
            //    }
            //}

            //int[] dispari = new int[contatore];

            //int indDis = 0;
            //for (int i = 0; i < elenco.Length; i++)
            //{
            //    if (elenco[i] % 2 != 0)
            //    {
            //        dispari[indDis] = elenco[i];
            //        indDis++;
            //    }
            //}

            //------------------------------------------------------ Media età

            List<Models.Persona> elenco = new List<Models.Persona>()
            {
                new Models.Persona("GIovanni Pace", 37),
                new Models.Persona("Valeria Verdi", 85),
                new Models.Persona("Marika Mariko", 32),
            };

            int somma = 0;
            foreach(Models.Persona persona in elenco)
            {
                somma += persona.Eta;
            }

            Console.WriteLine(somma / elenco.Count);


        }
    }
}

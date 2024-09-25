using LINQ_lez05_taskino.Models;

namespace LINQ_lez05_taskino
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Creare una lista di prodotti caratterizzati da:
                - Nome
                - Descrizione
                - Prezzo
                - Categoria
                - Quantità

                Inserire un numero n di prodotti:
                - Mandare in output tutti i prodotti di una certa categoria
                - Calcolare il prezzo medio dei prodotti
                - Riepilogare le quantità numeriche per categoria di prodotto
                - Creare un report del valore del negozio calcolato come "quantità x prezzo" di ogni prodotto   
            */

            List<Prodotto> elenco = new List<Prodotto>() { 
                new Prodotto("Biscotti", "Buoni", 1.25f, "Alimenti", 250),
                new Prodotto("Nutella", "Buona", 4.35f, "Alimenti", 85),
                new Prodotto("Martello", "Durissimo", 3.25f, "Bricolage", 12),
                new Prodotto("Corda", "Non so", 0.25f, "Bricolage", 83)
            };

            #region Mandare in output tutti i prodotti di una certa categoria
            ////var risultato = from prodotto in elenco
            ////                where prodotto.Categoria is not null && prodotto.Categoria.Equals("Alimenti")
            ////                select prodotto;

            //var risultato = elenco
            //                    .Where(p => p.Categoria.Equals("Alimenti"))
            //                    .Select(p => p.Nome);

            //foreach (var p in risultato)
            //{
            //    Console.WriteLine(p);
            //}
            #endregion

            #region Calcolare il prezzo medio dei prodotti

            //var prezzi = elenco.Select(p => p.Prezzo);

            //float somma = 0;
            //foreach (var p in prezzi)
            //{
            //    somma = somma + p;
            //}

            //Console.WriteLine(somma / prezzi.Count());

            // -----------------------------------------------------------

            //var prezzi = from p in elenco
            //             select p.Prezzo;

            //float media = prezzi.Average();

            //Console.WriteLine(media);

            // -----------------------------------------------------------

            //var risultato = elenco.Average(p => p.Prezzo);

            //Console.WriteLine(risultato);

            #endregion

            #region Riepilogare le quantità numeriche per categoria di prodotto

            var raggrupamenti = from prodotto in elenco
                                group prodotto by prodotto.Categoria into contCategoria
                                select contCategoria;

            foreach (var gruppo in raggrupamenti)
            {
                Console.WriteLine(gruppo.Key);
                float somma = gruppo.Sum(p => p.Quantita);
                Console.WriteLine(somma);
            }

            #endregion
        }
    }
}

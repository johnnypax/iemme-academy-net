using DB_lez06_task_edicola.Models;
using DB_lez06_task_edicola.Models.DAL;
using System.Collections;

namespace DB_lez06_task_edicola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Creare un sistema di gestione edicola.
             * In un'edicola sono presenti riviste e giocattoli.
             * Entrambi sono caratterizzati da un codice univoco (assegnato automaticamente all'inserimento nel DB) ed il prezzo.
             * 
             * Un gicattolo è caratterizzato almeno da:
             * - materiale
             * - età minima
             * 
             * La rivista è caratterizzata
             * - titolo
             * - casa editrice
             * 
             * Creare un sistema che si occupi di:
             * 1. Inserire riviste o giocattoli
             * 2. Stampare tutti i prodotti
             * 3. Stampare solo le riviste (con LINQ)
             * 4. Stampare solo i giocattoli (con LINQ)
             * 5. Conta tutti gli elementi (con LINQ)
             * 5. Cercare un elemento e stamparne i dettagli tramite il codice univoco.
             */

            bool insAbi = true;

            while (insAbi)
            {
                Console.WriteLine("Scegli la tua operazione:\n" +
                    "I - Inserire riviste o giocattoli\n" +
                    "S - Stampare tutti i prodotti\n" +
                    "R - Stampa le riviste\n" +
                    "G - Stampa i giocattoli\n" +
                    "Q - Uscita");
                string? inputUtente = Console.ReadLine();

                switch (inputUtente)
                {
                    case "I":
                        Console.WriteLine("Scegli cosa inserire:\n" +
                            "G - Giocattolo\n" +
                            "R - Rivista");
                        string? tipoInserimento = Console.ReadLine();

                        switch (tipoInserimento)
                        {
                            case "G":
                                break;
                            case "R":
                                Console.WriteLine("Dammi il prezzo");
                                double inPrezzo = (double)Convert.ToDecimal(Console.ReadLine());
                                Console.WriteLine("Dammi il titolo");
                                string? insTitolo = Console.ReadLine();
                                Console.WriteLine("Dammi la Casa Ed");
                                string? insCasa = Console.ReadLine();

                                if(insCasa != null && insTitolo != null)
                                {
                                    if (Edicola.GetInstance().InserisciRivista(inPrezzo, insTitolo, insCasa))
                                        Console.Write("STAPPOOOOOOO");
                                    else
                                        Console.Write("Errore");
                                }

                                break;
                            default:
                                Console.WriteLine("Il comando non è giusto");
                                break;
                        }
                        break;
                    case "S":
                        Edicola.GetInstance().RecuperaTutto(); 
                        Edicola.GetInstance().StampaOggetti(); 
                        break;
                    case "R":
                        Edicola.GetInstance().StampaRiviste();
                        break;
                    case "G":
                        Edicola.GetInstance().StampaGiocattoli();
                        break;
                    case "Q":
                        insAbi = false;
                        break;
                    default:
                        Console.WriteLine("Comando non riconosciuto");
                        break;
                }
            }
        }
    }
}

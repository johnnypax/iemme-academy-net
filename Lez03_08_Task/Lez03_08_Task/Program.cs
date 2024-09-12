using Lez03_08_Task.classes;
using System.Drawing;
using System.Text.RegularExpressions;

namespace Lez03_08_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Creare un sistema di gestione veicoli:
             * 
             * All'inserimento di un nuovo veicolo mi sarà permessa la scelta tra:
             * 1. Automobile
             * 2. Moto
             * 
             * Alla fine dell'inserimento delle caratteristiche del veicolo, stampare i suo dettagli.
             * 
             * Libera scelta degli attributi.
             */

            bool insAbi = true;

            while (insAbi)
            {
                Console.WriteLine("Cosa vuoi inserire?\n1 - Automobile\n2 - Moto\nQ - QUIT");
                string? inputUtente = Console.ReadLine();

                switch(inputUtente)
                {
                    case "1":
                        try
                        {
                            Console.WriteLine("Taga:");
                            string? varTarga = Console.ReadLine();
                            Console.WriteLine("Colore:");
                            string? varColore = Console.ReadLine();
                            Console.WriteLine("Marca:");
                            string? varMarca = Console.ReadLine();
                            Console.WriteLine("Modello:");
                            string? varModello = Console.ReadLine();
                            Console.WriteLine("Porte:");
                            int varPorte = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Posti:");
                            int varPosti = Convert.ToInt32(Console.ReadLine());

                            Automobile auto = new Automobile()
                            {
                                Targa = varTarga,
                                Colore = varColore,
                                Marca = varMarca,
                                Modello = varModello,
                                Posti = varPosti
                            };

                            auto.StampaDettaglio();
                        }
                        catch {
                            Console.WriteLine("ERRORE DI INSERIMENTO, CONTROLLA INPUT");
                        }
                        break;
                    case "2":
                        Console.WriteLine("Taga:");
                        string? varTargaM = Console.ReadLine();
                        Console.WriteLine("Colore:");
                        string? varColoreM = Console.ReadLine();
                        Console.WriteLine("Marca:");
                        string? varMarcaM = Console.ReadLine();
                        Console.WriteLine("Modello:");
                        string? varModelloM = Console.ReadLine();

                        Console.WriteLine("Ha il sidecar? Y/N");
                        string? varSidecar = Console.ReadLine();
                        bool valoreSidecar = false;
                        if (varSidecar is not null && varSidecar.Equals("Y"))
                            valoreSidecar = true;

                        Console.WriteLine("Ha il bauletto? Y/N");
                        string? varBauletto = Console.ReadLine();
                        bool valoreBauletto = false;
                        if (varBauletto is not null && varBauletto.Equals("Y"))
                            valoreBauletto = true;

                        Moto mot = new Moto()
                        {
                            Targa = varTargaM,
                            Colore = varColoreM,
                            Marca = varMarcaM,
                            Modello = varModelloM,
                            HasSidecar = valoreSidecar,
                            HasBauletto = valoreBauletto
                        };

                        mot.StampaDettaglio();

                        break;
                    case "Q":
                        insAbi = !insAbi;
                        break;
                    default:
                        Console.WriteLine("ERRORE: Comando non riconosciuto");
                        break;
                }
            }
        }
    }
}

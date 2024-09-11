namespace Lez02_03_ContenitoriDinamici
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //List<string> lista = new List<string>();
            //lista.Add("Giovanni");
            //lista.Add("Valeria");
            //lista.Add("Mario");

            //for(int i = 0; i < lista.Count; i++)
            //{
            //    Console.WriteLine(lista[i]);
            //}

            //.............................................

            /*
             * Creare un sistema di input che mi permetta di aggiungere invitati ad una lista, che abbia una funzione di stampa della lista e che mi permetta di interrompere il programma digitando Q
             */

            bool insAbi = true;
            List<string> elenco = new List<string>();

            while (insAbi)
            {
                Console.WriteLine("Cosa vuoi fare?\n" +
                    "I - Inserimento\n" +
                    "S - Stampa\n" +
                    "Q - Uscita");
                string? inputUtente = Console.ReadLine();

                switch (inputUtente)
                {
                    case "I":
                        Console.Write("Dammi il nome:");
                        string? varNome = Console.ReadLine();

                        if (varNome is not null && !varNome.Trim().Equals(""))
                        {
                            elenco.Add(varNome);
                            Console.WriteLine("STAPPOOOOOOOOOO!");
                        }                            
                        else
                            Console.WriteLine("Non ammetto valori vuoti!");
                        break;
                    case "S":
                        for(int i=0; i<elenco.Count; i++)
                        {
                            Console.WriteLine(elenco[i]);
                        }
                        break;
                    case "Q":
                        insAbi = !insAbi;
                        break;
                    default:
                        Console.WriteLine("ERRORE, comando non riconosciuto");
                        break;
                }
            }

        }
    }
}

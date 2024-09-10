namespace Lez01_08_ControlliComplessi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dato in input una sigla per la provincia, voglio sapere il nome per esteso

            //string provincia = "BO";

            //if (provincia.Equals("AQ"))
            //{
            //    Console.WriteLine("L'Aquila");
            //}
            //else
            //{
            //    if (provincia.Equals("PE"))
            //    {
            //        Console.WriteLine("Pescara");
            //    }
            //    else
            //    {
            //        if (provincia.Equals("BO"))
            //        {
            //            Console.WriteLine("Bologna");
            //        }
            //        else
            //        {
            //            Console.WriteLine("NON TROVATO");
            //        }
            //    }
            //}

            //----------------------------------------------

            //string provincia = "BO";

            //if (provincia.Equals("AQ"))
            //    Console.WriteLine("L'Aquila");
            //else if (provincia.Equals("PE"))
            //    Console.WriteLine("Pescara");
            //else if (provincia.Equals("BO"))
            //    Console.WriteLine("Bologna");
            //else
            //    Console.WriteLine("NON TROVATO");

            //------------------------------------------

            string provincia = "BO";

            switch (provincia)
            {
                case "AQ":
                    Console.WriteLine("L'Aquila");
                    break;
                case "PE":
                    Console.WriteLine("Pescara");
                    break;
                case "BO":
                    Console.WriteLine("Bologna");
                    break;
                default:
                    Console.WriteLine("NON TROVATO");
                    break;
            }
        }
    }
}

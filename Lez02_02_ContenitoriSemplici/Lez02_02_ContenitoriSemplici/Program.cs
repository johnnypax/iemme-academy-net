namespace Lez02_02_ContenitoriSemplici
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] elenco = { 23, 43, 98, 78 };
            //elenco[2] = 777;
            //Console.WriteLine(elenco[2]);

            //-------------------------------------------

            //int[] elencoDue = new int[5];
            //elencoDue[0] = 23;
            //elencoDue[1] = 5;
            //elencoDue[2] = 265;
            //elencoDue[3] = 2;
            //elencoDue[4] = 2333;
            ////elencoDue[5] = 888;           //NO BUONO

            ////Console.WriteLine(elencoDue.Length);

            //int i = 0;

            //while (i < elencoDue.Length)
            //{
            //    Console.WriteLine(elencoDue[i]);
            //    i++;
            //}

            //-------------------------------------------------

            //string[] elencoAuto = { "BMW", "Maserati", "Lamborghini", "FIAT" };
            //int i = 0;

            //while (i < elencoAuto.Length)
            //{
            //    Console.WriteLine(elencoAuto[i]);
            //    i++;
            //}

            //--------------------------------------------------

            //string[] elencoAuto = { 
            //    "BMW", "Maserati", "Lamborghini", "FIAT", "Lamborghini" };

            //int i = 0;
            //int contatore = 0;

            //while(i < elencoAuto.Length)
            //{
            //    if (elencoAuto[i].Equals("Lamborghini"))
            //        contatore++;

            //    i++;
            //}

            //Console.WriteLine(contatore);

            //--------------------------------------------------

            //string[] garage = {
            //    "BMW", "Maserati", "Lamborghini", "FIAT", "Lamborghini" };

            //Array.Sort(garage);

            //foreach(string auto in garage)
            //{
            //    Console.WriteLine(auto);
            //}

            //-------------------------------------------------

            //string invitati = "Giovanni,Mario,Marika,Valeria";

            //string[] arrayInvitati = invitati.Split(',');

            //foreach (string persona in arrayInvitati)
            //{
            //    Console.WriteLine(persona[0]);
            //}

            //-------------------------------------------------

            //string nominativo = "Giovanni";

            //Console.WriteLine(nominativo[nominativo.Length - 1]);

            //-------------------------------------------------

            //string invitati = "Giovanni,Mario,Marika,Valeria";
            //string[] invitatiArray = invitati.Split(",");

            //int i = 0;

            //while(i < invitatiArray.Length)
            //{
            //    Console.WriteLine(invitatiArray[i][0]);
            //    i++;
            //}

            //-------------------------------------------------

            string[] garage = {
                "BMW", "Maserati", "Lamborghini", "FIAT", "Lamborghini" };

            
            for(int i = 0;i < garage.Length; i++){
                Console.WriteLine(garage[i]);
            }

        }
    }
}

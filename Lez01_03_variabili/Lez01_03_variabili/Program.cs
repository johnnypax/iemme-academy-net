namespace Lez01_03_variabili
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int eta = 37;
            //Console.WriteLine(eta);

            //int eta_due;        //Dichiarazione
            //eta_due = 38;       //Assegnazione

            //Console.WriteLine(eta_due);

            //-----------------------------------------

            //string nome = "Giovanni";
            //Console.WriteLine(nome);

            //string cognome;
            //cognome = "Pace";
            //Console.WriteLine(cognome);

            //string? secondo_nome = null;
            //secondo_nome = "Carmine";
            //Console.WriteLine(secondo_nome);    

            //string? frase = "Ciao Giovanni";
            //frase = "Ciao Mario";
            //Console.WriteLine(frase);

            //frase = null;

            //-----------------------------------------

            //OPERAZIONI

            //Console.WriteLine(2 + 5);

            /*
             * +
             * -
             * *
             * /
             * %
             * >
             * <
             * >=
             * <=
             * ==
             * !=
             */

            //Console.WriteLine(6 == 5);

            //-------------------------------------
            // AltGR + Maiuscolo + [ -> {

            /*
             * if(condizione){
             *      //Codice in caso positivo
             * }
             * else{
             *      //Codice in caso negativo
             * }
             */

            //if(false)
            //{
            //    Console.WriteLine("Sono nel ramo positivo");
            //}
            //else
            //{
            //    Console.WriteLine("Sono nel ramo negativo");
            //}

            //int eta = 19;

            //if(eta >= 18)
            //{
            //    Console.WriteLine("Maggiorenne");
            //}
            //else
            //{
            //    Console.WriteLine("Minorenne");
            //}

            //-------------------------------------------------------

            //int eta = 15;

            //if(eta < 120)
            //{

            //    if (eta >= 0)
            //    {
            //        if (eta >= 18)
            //        {
            //            Console.WriteLine("Maggiorenne");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Minorenne");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("ERRORE età troppo bassa");
            //    }
            //} 
            //else
            //{
            //    Console.WriteLine("ERRORE età troppo alta");
            //}

            //----------------- LOGICA BOOLEANA

            //int eta = -3000;
            //  FALSE   &&  TRUE        =   FALSE
            //  0       x       1       =   0

            //int eta = 3000;
            //  TRUE    &&  FALSE       =   FALSE
            //  1       x       0       =   0

            //int eta = 15;
            //  TRUE    &&  TRUE        =   TRUE
            //      1   *       1       =   1

            //if (eta >= 0 && eta < 120)
            //{
            //    Console.WriteLine("Verifica maggiorenne");
            //}
            //else
            //{
            //    Console.WriteLine("Errore");
            //}

            //-------------------------------------------

            //int eta = -3000;
            //  TRUE    ||  FALSE   =   TRUE
            //  1       +   0       =   1

            //int eta = 3000;
            //  TRUE    ||  FALSE       =   TRUE
            //  1       +       0       =   1

            //int eta = 15;
            //  FALSE   ||  FALSE       =   FALSE
            //  0       +       0       =   0

            //if (eta < 0 || eta >= 120)
            //{
            //    Console.WriteLine("ERRORE");
            //}
            //else
            //{
            //    Console.WriteLine("vERIFICA MAGGIORENNE");
            //}

            bool hasPelo = false;
            Console.WriteLine(!hasPelo);











        }
    }
}

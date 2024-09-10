namespace Lez01_04_Variabili
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int? eta = null;
            //Console.WriteLine(eta);

            //int numero_intero = 2147483647;
            //Console.WriteLine(numero_intero + 2);

            //int numero_intero = 2;

            //float numero_float = 15.7f;
            //Console.WriteLine(numero_float);

            //double numero_double = 85.7d;
            //Console.WriteLine(numero_double);

            //double prova_db = numero_float;
            //Console.WriteLine(prova_db);

            //float prova_fl = numero_intero;
            //Console.WriteLine(prova_fl);

            //--------------------------------------

            //int valoreUno = 8;                          //1 
            //int valoreDue = 5;                          //1

            //Console.WriteLine(valoreUno + valoreDue);   //1
            //Console.WriteLine(valoreUno + valoreDue);   //1
            //Console.WriteLine(valoreUno + valoreDue);   //1
            //Console.WriteLine(valoreUno + valoreDue);   //1

            //----

            //int valareUno = 8;                          //1
            //int valareDue = 5;                          //1
            //int somma = valareUno + valareDue;          //2

            //Console.WriteLine(somma);
            //Console.WriteLine(somma);
            //Console.WriteLine(somma);
            //Console.WriteLine(somma);

            //----------------------------------------

            //Console.WriteLine(15 + 12.8f + 96.78d);             //Attenzione al rumore

            //----------------------------------------

            //int numero = 15;
            //numero = numero + 1;
            //numero = numero - 3;
            //Console.WriteLine(numero);

            //int numero = 15;
            //numero += 1;
            //numero -= 3;

            //numero++;
            //numero--;

            //Console.WriteLine(numero);

            //-------------------------------------

            int valoreUno = 15;
            float valoreDue = 2.0f;

            float rapporto = valoreUno / valoreDue;

            int risultato = (int)rapporto;

            Console.WriteLine(risultato);



        }
    }
}

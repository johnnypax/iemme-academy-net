using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez05_01_CorrezioneEsercizioUno.classes
{
    internal class Calcolatrice
    {
        private Calcolatrice() { }

        public static double Somma(double varA, double varB)
        {
            return varA + varB;
        }
        public static double Moltiplicazione(double varA, double varB)
        {
            return varA * varB;
        }
        public static double Sottrazione(double varA, double varB)
        {
            return varA - varB;
        }
        public static double? Divisione(double varA, double varB)
        {
            if(varB != 0)
                return varA / varB;
            else
                if(varA == 0)
                {
                    Console.WriteLine("Risultato indefinito");
                }
                else
                {
                    Console.Write("Operazione non possibile");
                }


            return null;
        }



    }
}

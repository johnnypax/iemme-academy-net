using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_lez05_calcolatrice_singleton.classes
{
    internal class Calcolatrice
    {
        private static Calcolatrice? instance;

        public static Calcolatrice GetInstance()
        {
            if (instance == null)
                instance = new Calcolatrice();

            return instance;
        }

        private Calcolatrice() {
            Console.WriteLine("Ho invocato il costruttore");
        }  

        public float Somma(float a, float b)
        {
            return a + b;
        }
        public float Sottrazione(float a, float b)
        {
            return a - b;
        }
        public float Moltiplicazione(float a, float b)
        {
            return a * b;
        }
        public float Divisione(float a, float b)
        {
            return a / b;
        }
    }
}

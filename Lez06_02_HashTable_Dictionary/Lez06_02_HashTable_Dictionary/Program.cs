using System;
using System.Collections;

namespace Lez06_02_HashTable_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();

            // ht.add(Object, Object)
            //ht.Add(0, "Giovanni");
            //ht.Add(1, "Mario");
            //ht.Add("pippo", "Valeria");
            //ht.Add(0.4f, "Mario");
            //ht.Add("Mario", 0.5d);
            //ht.Add("lista", new List<string>() { "maserati", "Lamborghini" });
            //ht.Add("oggetto", new { Nome = "Giov", Cognome = "Pace" });
            //ht.Add(new { Nome = "Giov", Cognome = "Pace" }, new { Nome = "Giov", Cognome = "Pace" });

            ////Console.WriteLine(ht["oggetto"]);

            ////if(ht.ContainsKey("pippo")) {
            ////    Console.WriteLine(ht["pippo"]);
            ////}

            //foreach (DictionaryEntry item in ht)
            //{
            //    Console.WriteLine(item);
            //}

            // -----------------------------------------------------------------

            //Dictionary<int, string> combinazione = new Dictionary<int, string>();
            //combinazione.Add(8, "Giovanni");
            //combinazione.Add(4, "Valeria");

            //foreach(KeyValuePair<int, string> o in combinazione) { 
            //    Console.WriteLine(o.Value);
            //}

            //foreach (int k in combinazione.Keys)
            //{
            //    Console.WriteLine(k);
            //}

            //Dictionary<string, string> combinazioneDue = new Dictionary<string, string>();
            //combinazioneDue.Add("nome", "Giovanni");
            //combinazioneDue.Add("cognome", "Pace");

            //Dictionary<string, Object> combinazioneTre = new Dictionary<string, Object>();
            //combinazioneTre.Add("nome", "GIovanni");
            //combinazioneTre.Add("animale", new { Nome = "Bu", Tipologia = "Gatto" });

            //Dictionary<Object, Object> combinazioneQuat = new Dictionary<Object, Object>();

            // ---------------------------------------------------------------------------------------

            Hashtable gatto = new Hashtable();
            gatto.Add("razza", "europeo testa di gatto");
            gatto.Add("nome", "Bu");

            Hashtable per = new Hashtable();
            per.Add("nome", "Giovanni");
            per.Add("cognome", "Pace");
            per.Add("eta", 37);
            per.Add("animale", gatto);

            foreach(DictionaryEntry dett in per) {

                if(dett.Value is not null && dett.Value.GetType() == typeof(Hashtable))
                {
                    foreach(DictionaryEntry d in (Hashtable)dett.Value)
                    {
                        Console.WriteLine($"Nella chiave {d.Key} c'è il valore: {d.Value}");
                    }
                }
                else
                {
                    Console.WriteLine($"Nella chiave {dett.Key} c'è il valore: {dett.Value}");
                }
            }




        }
    }
}

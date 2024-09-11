namespace Lez02_04_ContenitoriComplessi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] gio = { "Giovanni", "Pace", "AB1234", "37" };
            string[] val = { "Valeria", "Verdi Verdoni", "AB1235", "37" };
            string[] mar = { "Mario", "Rossi", "AB1236", "37" };

            List<string[]> elenco = new List<string[]>();
            elenco.Add(gio);
            elenco.Add(val);
            elenco.Add(mar);

            //for(int i = 0;i<elenco.Count;i++)
            //{
            //    Console.WriteLine($"{elenco[i][0]} {elenco[i][1]} {elenco[i][2]}");
            //}

            for (int i = 0; i < elenco.Count; i++)
            {
                for(int k = 0; k < elenco[i].Length; k++)
                {
                    Console.WriteLine(elenco[i][k]);
                }
            }

        }
    }
}

namespace Lez07_01_io
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Scrittura su file
            //string path = "C:\\Users\\ACADEMY\\Desktop\\provaprova.txt";
            ////string? path = Path.GetDirectoryName(typeof(Program).Assembly.Location);
            //Console.WriteLine(path);

            //string contenuto = "Ciao sono Giovanni Pace";

            //try
            //{
            //    if(path is not null)
            //        using(StreamWriter sw = new StreamWriter(path))
            //        {
            //            sw.WriteLine(contenuto);

            //            sw.WriteLine("CIAOCIAO");

            //            sw.Close();
            //        }

            //    Console.WriteLine("STAPPOOOOOOO");

            //} catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);   
            #endregion


            string path = "C:\\Users\\ACADEMY\\Desktop\\provaprova.txt";
            try
            {
                using(StreamReader sr = new StreamReader(path))
                {
                    string? line;

                    while((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}

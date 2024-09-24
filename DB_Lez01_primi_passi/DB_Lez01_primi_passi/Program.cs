using DB_Lez01_primi_passi.classes;
using System.Data.SqlClient;

namespace DB_Lez01_primi_passi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string credenziali = "Server=BOOK-N57JVKH6HJ\\SQLEXPRESS;Database=db_lez01_azienda;User Id=academy;Password=academy!;MultipleActiveResultSets=true;Encrypt=false;TrustServerCertificate=false";

            List<Dipendente> elenco = new List<Dipendente>();


            using (SqlConnection connessione = new SqlConnection(credenziali))
            {
                string query = "SELECT dipententeID, nome, cognome, dipartimento, identificativo, salario FROM Dipendente;";

                SqlCommand cmd = new SqlCommand(query, connessione);

                try
                {
                    connessione.Open();

                    SqlDataReader dati = cmd.ExecuteReader();
                    while (dati.Read())
                    {
                        //Console.WriteLine($"{dati[0]} {dati[1]}");

                        Dipendente dip = new Dipendente()
                        {
                            Id = dati.GetInt32(0),
                            Nome = dati.GetString(1),
                            Cogn = dati.GetString(2),
                            Dipa = dati.GetString(3),
                            Iden = dati.GetString(4),
                            Sala = dati.GetInt32(5)
                        };

                        elenco.Add(dip);
                    }

                    connessione.Close();
                } catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            }


            foreach (Dipendente dip in elenco)
            {
                Console.WriteLine(dip);
            }

            Console.WriteLine("FINE DEL PROGRAMMA");

        }
    }
}

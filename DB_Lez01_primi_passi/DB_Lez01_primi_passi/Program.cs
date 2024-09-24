using DB_Lez01_primi_passi.classes;
using System.Data.SqlClient;

namespace DB_Lez01_primi_passi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string credenziali = "Server=BOOK-N57JVKH6HJ\\SQLEXPRESS;Database=db_lez01_azienda;User Id=academy;Password=academy!;MultipleActiveResultSets=true;Encrypt=false;TrustServerCertificate=false";

            #region cRud
            //List<Dipendente> elenco = new List<Dipendente>();

            //using (SqlConnection connessione = new SqlConnection(credenziali))
            //{
            //    string query = "SELECT dipententeID, nome, cognome, dipartimento, identificativo, salario FROM Dipendente;";

            //    SqlCommand cmd = new SqlCommand(query, connessione);

            //    try
            //    {
            //        connessione.Open();

            //        SqlDataReader dati = cmd.ExecuteReader();
            //        while (dati.Read())
            //        {
            //            //Console.WriteLine($"{dati[0]} {dati[1]}");

            //            Dipendente dip = new Dipendente()
            //            {
            //                Id = dati.GetInt32(0),
            //                Nome = dati.GetString(1),
            //                Cogn = dati.GetString(2),
            //                Dipa = dati.GetString(3),
            //                Iden = dati.GetString(4),
            //                Sala = dati.GetInt32(5)
            //            };

            //            elenco.Add(dip);
            //        }

            //        connessione.Close();
            //    } catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }

            //}


            //foreach (Dipendente dip in elenco)
            //{
            //    Console.WriteLine(dip);
            //}

            //Console.WriteLine("FINE DEL PROGRAMMA");
            #endregion

            #region Crud

            //Dipendente gio = new Dipendente()
            //{
            //    Nome = "Giovanni",
            //    Cogn = "Pace",
            //    Dipa = "IT",
            //    Sala = 100000
            //};

            //using(SqlConnection conn = new SqlConnection(credenziali))
            //{
            //    SqlCommand cmd = new SqlCommand();
            //    cmd.Connection = conn;

            //    cmd.CommandText = "INSERT INTO Dipendente (nome, cognome, dipartimento, salario) VALUES " +
            //        "(@varNome, @varCognome, @varDipartimento, @varSalario);";
            //    cmd.Parameters.AddWithValue("@varNome", gio.Nome);
            //    cmd.Parameters.AddWithValue("@varCognome", gio.Cogn);
            //    cmd.Parameters.AddWithValue("@varDipartimento", gio.Dipa);
            //    cmd.Parameters.AddWithValue("@varSalario", gio.Sala);

            //    try
            //    {
            //        conn.Open();

            //        int affRows = cmd.ExecuteNonQuery();
            //        if (affRows > 0)
            //            Console.WriteLine("STAPPOOOOOOOO");
            //        else
            //            Console.WriteLine("ERRORE");

            //        conn.Close();
            //    } catch(Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            //}

            #endregion

            #region cruD

            //int idDaEliminare = 5;

            //using (SqlConnection conn = new SqlConnection(credenziali))
            //{
            //    SqlCommand cmd = new SqlCommand();
            //    cmd.Connection = conn;

            //    cmd.CommandText = "DELETE FROM Dipendente WHERE dipententeID = @varId";
            //    cmd.Parameters.AddWithValue("@varID", idDaEliminare);

            //    try
            //    {
            //        conn.Open();

            //        int affRows = cmd.ExecuteNonQuery();
            //        if (affRows > 0)
            //            Console.WriteLine("STAPPOOOOOOOO");
            //        else
            //            Console.WriteLine("ERRORE");

            //        conn.Close();
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            //}

            #endregion

            #region crUd

            Dipendente gio = new Dipendente()
            {
                Id = 10,
                Nome = "Giovanna",
                Cogn = "Paci",
                Dipa = "Management",
                Sala = 120000
            };

            using (SqlConnection conn = new SqlConnection(credenziali))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "UPDATE Dipendente SET " +
                    "nome = @varNome, " +
                    "cognome = @varCognome, " +
                    "dipartimento = @varDipartimento, " +
                    "salario = @varSalario " +
                    "WHERE dipententeID = @varId";

                cmd.Parameters.AddWithValue("@varNome", gio.Nome);
                cmd.Parameters.AddWithValue("@varCognome", gio.Cogn);
                cmd.Parameters.AddWithValue("@varDipartimento", gio.Dipa);
                cmd.Parameters.AddWithValue("@varSalario", gio.Sala);
                cmd.Parameters.AddWithValue("@varId", gio.Id);

                try
                {
                    conn.Open();

                    int affRows = cmd.ExecuteNonQuery();
                    if (affRows > 0)
                        Console.WriteLine("STAPPOOOOOOOO");
                    else
                        Console.WriteLine("ERRORE");

                    conn.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }



            #endregion
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_lez02_refactor.classes
{
    internal class DipendenteDAO
    {
        private string credenziali = "Server=BOOK-N57JVKH6HJ\\SQLEXPRESS;Database=db_lez01_azienda;User Id=academy;Password=academy!;MultipleActiveResultSets=true;Encrypt=false;TrustServerCertificate=false";

        public List<Dipendente> FindAll()
        {
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
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                return elenco;
            }
        }

        public Dipendente? FindById(int varId)
        {
            Dipendente? risultato = null;

            using (SqlConnection con = new SqlConnection(credenziali))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "SELECT dipententeID, nome, cognome, dipartimento, identificativo, salario FROM Dipendente WHERE dipententeID = @varId";
                cmd.Parameters.AddWithValue("@varId", varId);

                try
                {
                    con.Open();

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        risultato = new Dipendente()
                        {
                            Id = reader.GetInt32(0),
                            Nome = reader.GetString(1),
                            Cogn = reader.GetString(2),
                            Dipa = reader.GetString(3),
                            Iden = reader.GetString(4),
                            Sala = reader.GetInt32(5)
                        };
                    }

                    con.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return risultato;
        }

        public bool Insert(Dipendente objDipe)
        {
            bool risultato = false;

            using (SqlConnection conn = new SqlConnection(credenziali))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "INSERT INTO Dipendente (nome, cognome, dipartimento, salario) VALUES " +
                    "(@varNome, @varCognome, @varDipartimento, @varSalario);";
                cmd.Parameters.AddWithValue("@varNome", objDipe.Nome);
                cmd.Parameters.AddWithValue("@varCognome", objDipe.Cogn);
                cmd.Parameters.AddWithValue("@varDipartimento", objDipe.Dipa);
                cmd.Parameters.AddWithValue("@varSalario", objDipe.Sala);

                try
                {
                    conn.Open();

                    int affRows = cmd.ExecuteNonQuery();
                    if (affRows > 0)
                        risultato = true;

                    conn.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return risultato;
        }

        public bool Delete(int varId)
        {
            bool risultato = false;

            using (SqlConnection conn = new SqlConnection(credenziali))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "DELETE FROM Dipendente WHERE dipententeID = @varId";
                cmd.Parameters.AddWithValue("@varID", varId);

                try
                {
                    conn.Open();

                    int affRows = cmd.ExecuteNonQuery();
                    if (affRows > 0)
                        risultato = true;

                    conn.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return risultato;
        }

        public bool Update(Dipendente objDip)
        {
            bool risultato = false;

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

                cmd.Parameters.AddWithValue("@varNome", objDip.Nome);
                cmd.Parameters.AddWithValue("@varCognome", objDip.Cogn);
                cmd.Parameters.AddWithValue("@varDipartimento", objDip.Dipa);
                cmd.Parameters.AddWithValue("@varSalario", objDip.Sala);
                cmd.Parameters.AddWithValue("@varId", objDip.Id);

                try
                {
                    conn.Open();

                    int affRows = cmd.ExecuteNonQuery();
                    if (affRows > 0)
                        risultato=true;

                    conn.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return risultato;
        }
    }
}

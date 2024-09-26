using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_lez06_task_edicola.Models.DAL
{
    internal class RivistaDAO : IDaoLettura<Rivista>, IDaoScrittura<Rivista>
    {
        private static RivistaDAO? instance;

        public static RivistaDAO GetInstance()
        {
            if(instance is null)
                instance = new RivistaDAO();

            return instance;
        }
        private RivistaDAO()
        {

        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Rivista> GetAll()
        {
            List<Rivista> risultato = new List<Rivista>();

            using (SqlConnection conn = new SqlConnection(Config.credenziali))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT rivistaID,codice,prezzo,titolo,casaed FROM Rivista";

                try
                {
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Rivista temp = new Rivista()
                        {
                            Id = reader.GetInt32(0),
                            Codice = reader.GetString(1),
                            Prezzo = (double)reader.GetDecimal(2),
                            Titolo = reader.GetString(3),
                            CasaEd = reader.GetString(4)
                        };

                        risultato.Add(temp);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"CHIAMANTE: RivistaDAO, Messaggio: {ex.Message}");
                }
                finally
                {
                    conn.Close();
                }
            }

            return risultato;
        }

        public Rivista GetByCodice(string cod)
        {
            throw new NotImplementedException();
        }

        public Rivista GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Rivista t)
        {
            bool risultato = false;

            using(SqlConnection conn = new SqlConnection(Config.credenziali))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO Rivista (prezzo,titolo,casaed) VALUES (@pre, @tit, @cas)";
                cmd.Parameters.AddWithValue("@pre", t.Prezzo);
                cmd.Parameters.AddWithValue("@tit", t.Titolo);
                cmd.Parameters.AddWithValue("@cas", t.CasaEd);

                try
                {
                    conn.Open();
                    int affRows = cmd.ExecuteNonQuery();

                    if (affRows > 0)
                        risultato = true;
                } catch (Exception ex)
                {
                    Console.WriteLine($"CHIAMANTE: RivistaDAO, Messaggio: {ex.Message}");
                } finally
                {
                    conn.Close();
                }
            }                                           
                                                        
            return risultato;                           
        }

        public bool Update(Rivista t)
        {
            throw new NotImplementedException();
        }
    }
}

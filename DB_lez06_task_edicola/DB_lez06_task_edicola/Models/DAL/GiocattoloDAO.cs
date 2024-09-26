using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_lez06_task_edicola.Models.DAL
{
    internal class GiocattoloDAO : IDaoLettura<Giocattolo>, IDaoScrittura<Giocattolo>
    {
        private static GiocattoloDAO? instance;

        public static GiocattoloDAO GetInstance()
        {
            if (instance is null)
                instance = new GiocattoloDAO();

            return instance;
        }
        private GiocattoloDAO()
        {

        }
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Giocattolo> GetAll()
        {
            List<Giocattolo> risultato = new List<Giocattolo>();

            using (SqlConnection conn = new SqlConnection(Config.credenziali))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT giocattoloID,codice,prezzo,materi,etamin FROM Giocattolo";

                try
                {
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Giocattolo temp = new Giocattolo()
                        {
                            Id = reader.GetInt32(0),
                            Codice = reader.GetString(1),
                            Prezzo = (double)reader.GetDecimal(2),
                            Materiale = reader.GetString(3),
                            EtaMin = reader.GetInt32(4)
                        };

                        risultato.Add(temp);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"CHIAMANTE: GiocattoloDAO, Messaggio: {ex.Message}");
                }
                finally
                {
                    conn.Close();
                }
            }

            return risultato;
        }

        public Giocattolo GetByCodice(string cod)
        {
            throw new NotImplementedException();
        }

        public Giocattolo GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Giocattolo t)
        {
            throw new NotImplementedException();
        }

        public bool Update(Giocattolo t)
        {
            throw new NotImplementedException();
        }
    }
}

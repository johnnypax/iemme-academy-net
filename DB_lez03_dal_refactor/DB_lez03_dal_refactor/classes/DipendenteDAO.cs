using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DB_lez03_dal_refactor.classes
{
    internal class DipendenteDAO : IDao<Dipendente>
    {
        private static DipendenteDAO? instance;

        public static DipendenteDAO GetInstance()
        {
            if(instance == null)
                instance = new DipendenteDAO();

            return instance;
        }

        private DipendenteDAO() { }


        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Dipendente> FindAll()
        {
            throw new NotImplementedException();
        }

        public Dipendente? FindById(int id)
        {
            Dipendente? risultato = null;

            using (SqlConnection con = new SqlConnection(Config.credenziali))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "SELECT dipententeID, nome, cognome, dipartimento, identificativo, salario FROM Dipendente WHERE dipententeID = @varId";
                cmd.Parameters.AddWithValue("@varId", id);

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

        public bool Insert(Dipendente obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(Dipendente obj)
        {
            throw new NotImplementedException();
        }
    }
}

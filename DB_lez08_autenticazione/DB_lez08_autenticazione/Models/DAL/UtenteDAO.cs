using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_lez08_autenticazione.Models.DAL
{
    internal class UtenteDAO : IDaoLettura<Utente>
    {
        private static UtenteDAO? instance;

        public static UtenteDAO GetInstance()
        {
            if (instance == null)
                instance = new UtenteDAO();

            return instance;
        }

        private UtenteDAO() { }


        public List<Utente> GetAll()
        {
            throw new NotImplementedException();
        }

        public Utente GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void GetByCredenziali(string varUser, string varPass)
        {
            using (SqlConnection conn = new SqlConnection(Config.credenziali)) {

                // string query = $"SELECT utenteID, usern, passw, ruolo FROM Utente WHERE usern = '{varUser}' AND passw = '{varPass}'";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                //cmd.CommandText = query;
                cmd.CommandText = "SELECT utenteID, usern, passw, ruolo FROM Utente WHERE usern = @us AND passw = @pw";
                cmd.Parameters.AddWithValue("@us", varUser);
                cmd.Parameters.AddWithValue("@pw", varPass);

                try
                {
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Utente temp = new Utente()
                        {
                            Id = reader.GetInt32(0),
                            Username = reader.GetString(1),
                            Password = reader.GetString(2),
                            Ruolo = reader.GetString(3)
                        };

                        Console.WriteLine(temp);
                    }

                } catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                } finally
                {
                    conn.Close();
                }

            }
        }
    }
}

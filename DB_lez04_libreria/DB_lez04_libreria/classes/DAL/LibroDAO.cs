using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_lez04_libreria.classes.DAL
{
    internal class LibroDAO : IDao<Libro>
    {
        #region Trasformazione in singleton
        private static LibroDAO? instance;

        public static LibroDAO GetInstance()
        {
            if (instance == null)
                instance = new LibroDAO();

            return instance;
        }

        private LibroDAO() {
            Console.WriteLine("Ho appena creato l'oggetto LibroDAO");
        }
        #endregion

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Libro> GetAll()
        {
            List<Libro> risultato = new List<Libro>();

            using (SqlConnection conn = new SqlConnection(Config.credenziali))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT libroID, titolo, autore, pagine, editore, isbn FROM Libro";

                try
                {
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();
                    while(reader.Read())
                    {
                        Libro libro = new Libro() { 
                            Id = reader.GetInt32(0),
                            Titolo = reader.GetString(1),
                            Autore = reader.GetString(2),
                            Pagine = reader.GetInt32(3),
                            Editore = reader.GetString(4),
                            Isbn = reader.GetString(5)
                        };

                        risultato.Add(libro);
                    }

                    //conn.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    conn.Close();
                }

            }

            return risultato;
        }

        public Libro? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Libro obj)
        {
            bool risultato = false;

            using(SqlConnection conn = new SqlConnection(Config.credenziali)) {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "INSERT INTO Libro(titolo, autore, pagine, editore, isbn) VALUES (@tit, @aut, @pag, @edi, @isb)";
                cmd.Parameters.AddWithValue("@tit", obj.Titolo);
                cmd.Parameters.AddWithValue("@aut", obj.Autore);
                cmd.Parameters.AddWithValue("@pag", obj.Pagine);
                cmd.Parameters.AddWithValue("@edi", obj.Editore);
                cmd.Parameters.AddWithValue("@isb", obj.Isbn);

                try
                {
                    conn.Open();
                    
                    int affRows = cmd.ExecuteNonQuery();
                    if (affRows > 0)
                        risultato = true;

                    conn.Close();
                } catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return risultato;
        }

        public bool Update(Libro obj)
        {
            throw new NotImplementedException();
        }
    }
}

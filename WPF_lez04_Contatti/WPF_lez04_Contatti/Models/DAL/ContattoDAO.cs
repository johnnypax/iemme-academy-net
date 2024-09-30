using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_lez04_Contatti.Models.DAL
{
    internal class ContattoDAO : IDao<Contatto>
    {
        private static ContattoDAO? instance;

        public static ContattoDAO GetInstance()
        {
            if (instance == null)
                instance = new ContattoDAO();

            return instance;
        }

        private ContattoDAO() { }   

        public List<Contatto> GetAll()
        {
            List<Contatto> elenco = new List<Contatto>();

            using (var ctx = new ALez03RubricaContext())
            {
                elenco = ctx.Contattos.ToList();
            }

            return elenco;
        }

        public Contatto? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Contatto t)
        {
            bool risultato = false;

            using(var ctx = new ALez03RubricaContext())
            {
                try
                {
                    ctx.Contattos.Add(t);
                    ctx.SaveChanges();

                    risultato = true;
                } catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return risultato;
        }
    }
}

using esercizio_01_officina.Context;
using esercizio_01_officina.Models;
using System.Linq;

namespace esercizio_01_officina.Repositories
{
    public class ClienteRepo : IRepoLettura<Cliente>, IRepoScrittura<Cliente>
    {
        private readonly OfficinaContext _context;
        public ClienteRepo(OfficinaContext context) {
            _context = context;
        }

        public bool Create(Cliente entity)
        {
            bool risultato = false;

            try
            {
                _context.Clienti.Add(entity);
                _context.SaveChanges();

                risultato = true;
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return risultato;
        }

        public IEnumerable<Cliente> GetAll()
        {
            return _context.Clienti.ToList();
        }

        public Cliente? GetById(int id)
        {
            return _context.Clienti.Find(id);
        }
        public Cliente? GetByCodice(string cod)
        {
            return _context.Clienti.FirstOrDefault(c => c.Codice == cod);
        }

        public bool Update(Cliente entity)
        {
            bool risultato = false;

            try
            {
                _context.Clienti.Update(entity);
                _context.SaveChanges();

                risultato = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return risultato;
        }
        public bool Delete(int id)
        {
            bool risultato = false;
            try
            {
                Cliente cli = _context.Clienti.Single(c => c.ClienteID == id);
                _context.Clienti.Remove(cli);
                _context.SaveChanges();

                risultato = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return risultato;
        }
    }
}

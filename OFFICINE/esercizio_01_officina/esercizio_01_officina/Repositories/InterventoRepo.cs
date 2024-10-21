using esercizio_01_officina.Context;
using esercizio_01_officina.Models;

namespace esercizio_01_officina.Repositories
{
    public class InterventoRepo : IRepoLettura<Intervento>, IRepoScrittura<Intervento>
    {
        private OfficinaContext _context;

        public InterventoRepo(OfficinaContext context)
        {
            _context = context;
        }

        public bool Create(Intervento entity)
        {
            bool risultato = false;

            try
            {
                _context.Interventi.Add(entity);
                _context.SaveChanges();

                risultato = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return risultato;
        }

        public IEnumerable<Intervento> GetAll()
        {
            return _context.Interventi.ToList();
        }

        public Intervento? GetById(int id)
        {
            return _context.Interventi.Find(id);
        }
        public Intervento? GetByCode(string cod)
        {
            return _context.Interventi.FirstOrDefault(i => i.Codice == cod);
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Intervento entity)
        {
            throw new NotImplementedException();
        }
    }
}

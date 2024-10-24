using ASP_WEB_05_Esercizio_Corsi.Context;
using ASP_WEB_05_Esercizio_Corsi.Models;

namespace ASP_WEB_05_Esercizio_Corsi.Repos
{
    public class CorsoRepo : IRepo<Corso>
    {
        private readonly PoloFormativoContext _context;

        public CorsoRepo(PoloFormativoContext context)
        {
            _context = context;
        }

        public bool Create(Corso t)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Corso? Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Corso> GetAll()
        {
            return _context.Corsi.ToList();
        }

        public bool Update(Corso t)
        {
            throw new NotImplementedException();
        }
    }
}

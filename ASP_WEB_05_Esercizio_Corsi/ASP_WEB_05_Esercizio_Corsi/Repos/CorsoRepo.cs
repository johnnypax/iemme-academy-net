using ASP_WEB_05_Esercizio_Corsi.Context;
using ASP_WEB_05_Esercizio_Corsi.Models;

namespace ASP_WEB_05_Esercizio_Corsi.Repos
{
    public class CorsoRepo : IRepo<Corso>
    {
        private readonly PoloFormativoContext _context;
        private readonly ILogger<CorsoRepo> _logger;

        public CorsoRepo(PoloFormativoContext context, ILogger<CorsoRepo> logger)
        {
            _context = context;
            _logger = logger;
        }

        public bool Create(Corso t)
        {
            bool risultato = false;

            try
            {
                _context.Corsi.Add(t);
                _context.SaveChanges();

                risultato = true;
            }
            catch (Exception ex)
            {
                _logger.LogCritical(ex.Message);
            }

            return risultato;
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

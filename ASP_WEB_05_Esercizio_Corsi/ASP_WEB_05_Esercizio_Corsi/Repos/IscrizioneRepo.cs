using ASP_WEB_05_Esercizio_Corsi.Context;
using ASP_WEB_05_Esercizio_Corsi.Models;

namespace ASP_WEB_05_Esercizio_Corsi.Repos
{
    public class IscrizioneRepo : IRepo<Iscrizione>
    {
        private readonly PoloFormativoContext _context;
        private readonly ILogger<IscrizioneRepo> _logger;

        public IscrizioneRepo(PoloFormativoContext context, ILogger<IscrizioneRepo> logger)
        {
            _context = context;
            _logger = logger;
        }

        public bool Create(Iscrizione t)
        {
            bool risultato = false;

            try
            {
                _context.Iscrizioni.Add(t);
                _context.SaveChanges();

                risultato = true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }

            return risultato;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Iscrizione? Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Iscrizione> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(Iscrizione t)
        {
            throw new NotImplementedException();
        }
    }
}

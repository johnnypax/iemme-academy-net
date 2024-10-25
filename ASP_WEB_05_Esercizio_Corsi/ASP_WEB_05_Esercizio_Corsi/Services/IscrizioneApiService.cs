using ASP_WEB_05_Esercizio_Corsi.Models;
using ASP_WEB_05_Esercizio_Corsi.Repos;

namespace ASP_WEB_05_Esercizio_Corsi.Services
{
    public class IscrizioneApiService : IServiceScrittura<IscrizioneDTO>
    {
        private readonly IscrizioneRepo _repo;
        private readonly CorsoService _corsoService;
        private readonly ILogger<IscrizioneApiService> _logger;

        public IscrizioneApiService(IscrizioneRepo repo, CorsoService corsoService, ILogger<IscrizioneApiService> logger)
        {
            _repo = repo;
            _corsoService = corsoService;
            _logger = logger;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(IscrizioneDTO t)
        {
            if (t.CorsoIscr is null || t.CorsoIscr.Cod is null)
            {
                _logger.LogError("Le informazioni sul corso di destinazione sono incomplete");
                return false;
            }

            int? cRif = _corsoService.GetIdByCode(t.CorsoIscr.Cod);

            if (cRif is null)
            {
                _logger.LogError("Non è stato trovato l'ID del corso");
                return false;
            }


            Iscrizione iscr = new Iscrizione()
            {
                Codice = Guid.NewGuid().ToString().ToUpper(),
                Nome = t.Nome,
                Cognome = t.Cognome,
                Email = t.Email,
                DataIscr = DateTime.Now,
                CodiceDis = Guid.NewGuid().ToString().ToUpper(),
                CorsoRIF = (int)cRif
            };

            t.CodiceDis = iscr.CodiceDis;

            return _repo.Create(iscr); 
        }

        public bool Update(IscrizioneDTO t)
        {
            throw new NotImplementedException();
        }
    }
}

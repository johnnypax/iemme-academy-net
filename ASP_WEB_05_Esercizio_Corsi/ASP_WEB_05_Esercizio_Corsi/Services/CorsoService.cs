using ASP_WEB_05_Esercizio_Corsi.Models;
using ASP_WEB_05_Esercizio_Corsi.Repos;

namespace ASP_WEB_05_Esercizio_Corsi.Services
{
    public class CorsoService : IServiceLettura<Corso>, IServiceScrittura<CorsoDTO>
    {
        private readonly CorsoRepo _repo;

        public CorsoService(CorsoRepo repo)
        {
            _repo = repo;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Corso? Details(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(CorsoDTO t)
        {
            Corso cor = new Corso()
            {
                CodCorso = Guid.NewGuid().ToString().ToUpper(),
                Nome = t.Nom!,
                Descrizione = t.Des,
                MaxPartecipanti = t.Par,
                Prezzo = t.Pre,
                DataCorso = t.Dat
            };

            return _repo.Create(cor);
        }

        public IEnumerable<Corso> List()
        {
            return _repo.GetAll();
        }

        public bool Update(CorsoDTO t)
        {
            throw new NotImplementedException();
        }
    }
}

using ASP_WEB_05_Esercizio_Corsi.Models;
using ASP_WEB_05_Esercizio_Corsi.Repos;

namespace ASP_WEB_05_Esercizio_Corsi.Services
{
    public class CorsoService : IService<Corso>
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

        public bool Insert(Corso t)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Corso> List()
        {
            return _repo.GetAll();
        }

        public bool Update(Corso t)
        {
            throw new NotImplementedException();
        }
    }
}

using REST_EF_06_Migrazioni.Models;
using REST_EF_06_Migrazioni.Repos;

namespace REST_EF_06_Migrazioni.Services
{
    public class FilmService : IServices<FilmDTO>
    {
        private readonly FilmRepo _repo;

        public FilmService(FilmRepo repo)
        {
            _repo = repo;
        }

        public bool Aggiorna(FilmDTO entity)
        {
            throw new NotImplementedException();
        }

        public FilmDTO? CercaPerCodice(string codice)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<FilmDTO> CercaTutti()
        {
            throw new NotImplementedException();
        }

        public bool Elimina(string codice)
        {
            throw new NotImplementedException();
        }

        public bool Inserisci(FilmDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}

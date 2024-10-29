using REST_EF_06_Migrazioni.Models;
using REST_EF_06_Migrazioni.Repos;

namespace REST_EF_06_Migrazioni.Services
{
    public class CategoriaService : IServices<CategoriaDTO>
    {
        private readonly FilmRepo _repo;

        public CategoriaService(FilmRepo repo)
        {
            _repo = repo;
        }

        public bool Aggiorna(CategoriaDTO entity)
        {
            throw new NotImplementedException();
        }

        public CategoriaDTO? CercaPerCodice(string codice)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CategoriaDTO> CercaTutti()
        {
            throw new NotImplementedException();
        }

        public bool Elimina(string codice)
        {
            throw new NotImplementedException();
        }

        public bool Inserisci(CategoriaDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}

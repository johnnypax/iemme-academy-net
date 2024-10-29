using REST_EF_06_Migrazioni.Models;
using REST_EF_06_Migrazioni.Repos;

namespace REST_EF_06_Migrazioni.Services
{
    public class CategoriaService : IServices<CategoriaDTO>
    {
        private readonly CategoriaRepo _repo;

        public CategoriaService(CategoriaRepo repo)
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

        public CategoriaDTO? CercaPerId(int id)
        {
            CategoriaDTO? categoriaDTO = null;

            Categoria? ris = _repo.GetById(id);
            if(ris is not null) {
                categoriaDTO = new CategoriaDTO()
                {
                    Codice = ris.Codice,
                    Nome = ris.Nome,
                };
            }

            return categoriaDTO;
        }
    }
}

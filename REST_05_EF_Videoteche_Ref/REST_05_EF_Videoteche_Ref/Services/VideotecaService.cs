using REST_05_EF_Videoteche_Ref.Models;
using REST_05_EF_Videoteche_Ref.Repos;

namespace REST_05_EF_Videoteche_Ref.Services
{
    public class VideotecaService : IService<VideotecaDTO>
    {
        private readonly VideotecaRepo _repository;

        public VideotecaService(VideotecaRepo repository)
        {
            _repository = repository;
        }

        public VideotecaDTO? Cerca(string varCod)
        {
            VideotecaDTO? risultato = null;

            Videoteca? videoteca = _repository.GetByCodice(varCod);
            if (videoteca is not null)
            {
                risultato = new VideotecaDTO()
                {
                    Cod = videoteca.Codice,
                    Ind = videoteca.Indirizzo,
                    Nom = videoteca.Nome
                };
            }

            return risultato;
        }

        public IEnumerable<VideotecaDTO> Lista()
        {
            throw new NotImplementedException();
        }
    }
}

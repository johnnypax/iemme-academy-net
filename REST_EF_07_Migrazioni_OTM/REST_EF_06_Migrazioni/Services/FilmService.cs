using REST_EF_06_Migrazioni.Models;
using REST_EF_06_Migrazioni.Repos;

namespace REST_EF_06_Migrazioni.Services
{
    public class FilmService : IServices<FilmDTO>
    {
        private readonly FilmRepo _repo;
        private readonly FilmCategoriaService _filmCatSer;

        public FilmService(FilmRepo repo, FilmCategoriaService filmCategoriaService)
        {
            _repo = repo;
            _filmCatSer = filmCategoriaService;
        }

        public bool Aggiorna(FilmDTO entity)
        {
            throw new NotImplementedException();
        }

        public FilmDTO? CercaPerCodice(string codice)
        {
            FilmDTO? risultato = null;

            Film? fil = _repo.GetByCodice(codice);
            if(fil is not null)
            {
                risultato = new FilmDTO()
                {
                    Ann = fil.Anno,
                    Aut = fil.Autore,
                    Cod = fil.Codice,
                    Des = fil.Descrizione,
                    Dis = fil.Distribuzione,
                    Tit = fil.Titolo,
                    Cat = _filmCatSer.CercaCategoriePerFilmRif(fil.FilmID)
                };
            }

            return risultato;
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

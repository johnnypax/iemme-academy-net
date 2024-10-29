using REST_EF_06_Migrazioni.Models;
using REST_EF_06_Migrazioni.Repos;

namespace REST_EF_06_Migrazioni.Services
{
    public class FilmCategoriaService
    {
        private readonly FilmCategoriaRepo _repo;
        private readonly CategoriaService _serviceCat;

        public FilmCategoriaService(FilmCategoriaRepo repo, CategoriaService categoriaService)
        {
            _repo = repo;
            _serviceCat = categoriaService;
        }

        public IEnumerable<CategoriaDTO> CercaCategoriePerFilmRif(int idFilm)
        {
            List<CategoriaDTO> risultato = new List<CategoriaDTO>();

            IEnumerable<Film_Categoria> fc = _repo.GetCategorieByFilmRif(idFilm);
            foreach(Film_Categoria filcat in fc)
            {
                CategoriaDTO? cate = _serviceCat.CercaPerId(filcat.CategoriaRIF);
                if(cate != null)
                    risultato.Add(cate);
            }

            return risultato;
        }

    }
}

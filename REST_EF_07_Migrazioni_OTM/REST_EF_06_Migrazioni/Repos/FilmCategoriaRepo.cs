using REST_EF_06_Migrazioni.Context;
using REST_EF_06_Migrazioni.Models;

namespace REST_EF_06_Migrazioni.Repos
{
    public class FilmCategoriaRepo
    {
        private readonly CinemaContext _context;
        public FilmCategoriaRepo(CinemaContext context)
        {
            _context = context;
        }

        public IEnumerable<Film_Categoria> GetCategorieByFilmRif(int id)
        {
            return _context.Film_Categorie.Where(fc => fc.FilmRIF == id).ToList();
        } 
    }
}

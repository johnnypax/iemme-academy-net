using REST_EF_06_Migrazioni.Context;
using REST_EF_06_Migrazioni.Models;

namespace REST_EF_06_Migrazioni.Repos
{
    public class FilmRepo : IRepoLettura<Film>, IRepoScrittura<Film>
    {
        private readonly CinemaContext _context;
        public FilmRepo(CinemaContext context)
        {
            _context = context;
        }

        public bool Create(Film entity)
        {
            bool risultato = false;

            try
            {
                _context.Pellicole.Add(entity);
                _context.SaveChanges();

                risultato = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return risultato;
        }

        public IEnumerable<Film> GetAll()
        {
            return _context.Pellicole.ToList();
        }

        public Film? GetById(int id)
        {
            return _context.Pellicole.Find(id);
        }

        public Film? GetByCodice(string cod)
        {
            return _context.Pellicole.FirstOrDefault(c => c.Codice == cod);
        }

        public bool Update(Film entity)
        {
            bool risultato = false;

            try
            {
                _context.Pellicole.Update(entity);
                _context.SaveChanges();

                risultato = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return risultato;
        }
        public bool Delete(int id)
        {
            bool risultato = false;
            try
            {
                Film cli = _context.Pellicole.Single(c => c.FilmID == id);
                _context.Pellicole.Remove(cli);
                _context.SaveChanges();

                risultato = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return risultato;
        }
    }
}

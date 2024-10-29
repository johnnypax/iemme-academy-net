using REST_EF_06_Migrazioni.Context;
using REST_EF_06_Migrazioni.Models;

namespace REST_EF_06_Migrazioni.Repos
{
    public class CategoriaRepo : IRepoLettura<Categoria>, IRepoScrittura<Categoria>
    {
        private readonly CinemaContext _context;
        public CategoriaRepo(CinemaContext context)
        {
            _context = context;
        }

        public bool Create(Categoria entity)
        {
            bool risultato = false;

            try
            {
                _context.Categorie.Add(entity);
                _context.SaveChanges();

                risultato = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return risultato;
        }

        public IEnumerable<Categoria> GetAll()
        {
            return _context.Categorie.ToList();
        }

        public Categoria? GetById(int id)
        {
            return _context.Categorie.Find(id);
        }

        public Categoria? GetByCodice(string cod)
        {
            return _context.Categorie.FirstOrDefault(c => c.Codice == cod);
        }

        public bool Update(Categoria entity)
        {
            bool risultato = false;

            try
            {
                _context.Categorie.Update(entity);
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
                Categoria cli = _context.Categorie.Single(c => c.CategoriaID == id);
                _context.Categorie.Remove(cli);
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

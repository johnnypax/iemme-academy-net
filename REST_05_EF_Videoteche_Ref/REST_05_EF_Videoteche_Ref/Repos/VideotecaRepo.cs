using REST_05_EF_Videoteche_Ref.Models;

namespace REST_05_EF_Videoteche_Ref.Repos
{
    public class VideotecaRepo : IRepo<Videoteca>
    {
        private readonly BlockbusterContext _context;

        public VideotecaRepo(BlockbusterContext context)
        {
            _context = context;
        }

        public bool Create(Videoteca entity)
        {
            bool risultato = false;
            try
            {
                _context.Videoteche.Add(entity);
                _context.SaveChanges();

                risultato = true;
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return risultato;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Videoteca? Get(int id)
        {
            return _context.Videoteche.Find(id);
        }

        public Videoteca? GetByCodice(string cod)
        {
            return _context.Videoteche.FirstOrDefault(v => v.Codice == cod);
        }

        public IEnumerable<Videoteca> GetAll()
        {
            return _context.Videoteche.ToList();
        }

        public bool Update(Videoteca entity)
        {
            throw new NotImplementedException();
        }
    }
}

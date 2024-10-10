using REST_05_EF_Videoteche_Ref.Models;

namespace REST_05_EF_Videoteche_Ref.Repos
{
    public class SupportoRepo : IRepo<Supporto>
    {
        private readonly BlockbusterContext _context;

        public SupportoRepo(BlockbusterContext context)
        {
            _context = context;
        }

        public bool Create(Supporto entity)
        {
            bool risultato = false;
            try
            {
                _context.Supporti.Add(entity);
                _context.SaveChanges();

                risultato = true;
            } catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return risultato;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Supporto? Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Supporto> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(Supporto entity)
        {
            throw new NotImplementedException();
        }
    }
}

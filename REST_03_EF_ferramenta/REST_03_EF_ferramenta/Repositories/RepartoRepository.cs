using REST_03_EF_ferramenta.Models;

namespace REST_03_EF_ferramenta.Repositories
{
    public class RepartoRepository : IRepository<Reparto>
    {
        private static RepartoRepository? instance;

        public static RepartoRepository GetInstance()
        {
            if (instance == null)
                instance = new RepartoRepository();

            return instance;
        }
        private RepartoRepository() { }

        public bool Delete(int id)
        {
            bool risultato = false;

            using (var ctx = new EfLez03FerramentaContext())
            {
                try
                {
                    Reparto lib = ctx.Repartos.Single(l => l.RepartoId == id);
                    ctx.Repartos.Remove(lib);
                    ctx.SaveChanges();

                    risultato = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return risultato;
        }

        public List<Reparto> GetAll()
        {
            List<Reparto> elenco = new List<Reparto>();

            using (var ctx = new EfLez03FerramentaContext())
                elenco = ctx.Repartos.ToList();

            return elenco;
        }

        public Reparto? GetById(int id)
        {
            Reparto? risultato = null;

            using (var ctx = new EfLez03FerramentaContext())
                risultato = ctx.Repartos.FirstOrDefault(l => l.RepartoId == id);

            return risultato;
        }

        public Reparto? GetByCodice(string varCodice)
        {
            Reparto? risultato = null;

            using (var ctx = new EfLez03FerramentaContext())
                risultato = ctx.Repartos.FirstOrDefault(l => l.RepartoCod == varCodice);

            return risultato;
        }

        public bool Insert(Reparto t)
        {
            bool risultato = false;

            using (var ctx = new EfLez03FerramentaContext())
            {
                try
                {
                    ctx.Repartos.Add(t);
                    ctx.SaveChanges();

                    risultato = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return risultato;
        }

        public bool Update(Reparto t)
        {
            throw new NotImplementedException();
        }
    }
}

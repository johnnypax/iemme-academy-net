using REST_03_EF_ferramenta.Models;

namespace REST_03_EF_ferramenta.Repositories
{
    public class ProdottoRepository : IRepository<Prodotto>
    {
        private static ProdottoRepository? instance;

        public static ProdottoRepository GetInstance()
        {
            if (instance == null)
                instance = new ProdottoRepository();

            return instance;
        }
        private ProdottoRepository() { }

        public bool Delete(int id)
        {
            bool risultato = false;

            using (var ctx = new EfLez03FerramentaContext())
            {
                try
                {
                    Prodotto lib = ctx.Prodottos.Single(l => l.ProdottoId == id);
                    ctx.Prodottos.Remove(lib);
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

        public List<Prodotto> GetAll()
        {
            List<Prodotto> elenco = new List<Prodotto>();

            using (var ctx = new EfLez03FerramentaContext())
                elenco = ctx.Prodottos.ToList();

            return elenco;
        }

        public Prodotto? GetById(int id)
        {
            Prodotto? risultato = null;

            using (var ctx = new EfLez03FerramentaContext())
                risultato = ctx.Prodottos.FirstOrDefault(l => l.ProdottoId == id);

            return risultato;
        }

        public Prodotto? GetByCodiceBarre(string varCodice)
        {
            Prodotto? risultato = null;

            using (var ctx = new EfLez03FerramentaContext())
                risultato = ctx.Prodottos.FirstOrDefault(l => l.CodiceBarre == varCodice);

            return risultato;
        }

        public bool Insert(Prodotto t)
        {
            bool risultato = false;

            using (var ctx = new EfLez03FerramentaContext())
            {
                try
                {
                    ctx.Prodottos.Add(t);
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

        public bool Update(Prodotto t)
        {
            throw new NotImplementedException();
        }
    }
}

using REST_04_EF_Videoteche.Models;

namespace REST_04_EF_Videoteche.Repos
{
    public class VideotecaRepo : IRepo<Videoteca>
    {
        private static VideotecaRepo? instance;

        public static VideotecaRepo GetInstance()
        {
            if (instance == null)
                instance = new VideotecaRepo();

            return instance;
        }
        private VideotecaRepo() { }

        public bool Delete(int id)
        {
            bool risultato = false;

            using (var ctx = new AEfLez04VideotecheContext())
            {
                try
                {
                    Videoteca lib = ctx.Videotecas.Single(l => l.VideotecaId == id);
                    ctx.Videotecas.Remove(lib);
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

        public List<Videoteca> GetAll()
        {
            List<Videoteca> elenco = new List<Videoteca>();

            using (var ctx = new AEfLez04VideotecheContext())
                elenco = ctx.Videotecas.ToList();

            return elenco;
        }

        public Videoteca? GetById(int id)
        {
            Videoteca? risultato = null;

            using (var ctx = new AEfLez04VideotecheContext())
                risultato = ctx.Videotecas.FirstOrDefault(l => l.VideotecaId == id);

            return risultato;
        }

        public Videoteca? GetByCodice(string varCodice)
        {
            Videoteca? risultato = null;

            using (var ctx = new AEfLez04VideotecheContext())
                risultato = ctx.Videotecas.FirstOrDefault(l => l.Codice == varCodice);

            return risultato;
        }

        public bool Insert(Videoteca t)
        {
            bool risultato = false;

            using (var ctx = new AEfLez04VideotecheContext())
            {
                try
                {
                    ctx.Videotecas.Add(t);
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

        public bool Update(Videoteca t)
        {
            throw new NotImplementedException();
        }
    }
}

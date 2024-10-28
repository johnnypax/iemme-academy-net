using MongoDB.Driver;
using REST_08_Mongo.Models;
using SharpCompress.Common;

namespace REST_08_Mongo.Repos
{
    public class ImpiegatoRepo : IRepoLettura<Impiegato>, IRepoScrittura<Impiegato>
    {
        private readonly ILogger<ImpiegatoRepo> _logger;
        private IMongoCollection<Impiegato> impiegati;

        public ImpiegatoRepo(ILogger<ImpiegatoRepo> logger, IConfiguration configuration) { 
            _logger = logger;

            string? connessione = configuration.GetValue<string>("MongoDBConnessione:DbLocale");
            string? database = configuration.GetValue<string>("MongoDBConnessione:NomeDatabase");

            MongoClient conn = new MongoClient(connessione);
            IMongoDatabase db = conn.GetDatabase(database);

            this.impiegati = db.GetCollection<Impiegato>("Impiegatos");
        }

        public bool Create(Impiegato entity)
        {
            bool risultato = false;

            try
            {
                if (impiegati.Find(i => i.Matricola == entity.Matricola).ToList().Count > 0)
                {
                    _logger.LogError("Attenzione, tentativo inserimento matricola duplicata");
                    return false;
                }

                this.impiegati.InsertOne(entity);
                risultato = true;
            } catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }

            return risultato;
        }

        public bool Delete(string varId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Impiegato> GetAll()
        {
            return impiegati.Find(i => true).ToList();
        }

        public Impiegato? GetById(string varId)
        {
            throw new NotImplementedException();
        }

        public bool Update(Impiegato entity)
        {
            throw new NotImplementedException();
        }

        public Impiegato? GetByMatricola(string matricola)
        {
            Impiegato? risultato = null;

            try
            {
                risultato = this.impiegati.Find(i => i.Matricola == matricola).FirstOrDefault();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }

            return risultato;
        }
    }
}

using REST_08_Mongo.Models;
using REST_08_Mongo.Repos;

namespace REST_08_Mongo.Services
{
    public class ImpiegatoService
    {
        private readonly ImpiegatoRepo _repo;

        public ImpiegatoService(ImpiegatoRepo repo) { 
            _repo = repo;
        }

        public bool Inserisci(ImpiegatoDTO impDto) {
            Impiegato imp = new Impiegato()
            {
                Dipartimento = impDto.Dip,
                Matricola = impDto.Mat,
                DataAssu = impDto.Dat,
                Nominativo = impDto.Nom,
            };

            return _repo.Create(imp);
        }

        public IEnumerable<ImpiegatoDTO> CercaTutti()
        {
            List<ImpiegatoDTO> risultato = new List<ImpiegatoDTO>();

            foreach(Impiegato imp in _repo.GetAll())
            {
                risultato.Add(new ImpiegatoDTO()
                {
                    Dat = (DateTime)imp.DataAssu,
                    Dip = imp.Dipartimento,
                    Mat = imp.Matricola,
                    Nom = imp.Nominativo
                });
            }

            return risultato;
        }

        public ImpiegatoDTO? CercaPerMatricola(string matricola)
        {
            ImpiegatoDTO? risultato = null;
            Impiegato? imp = _repo.GetByMatricola(matricola);

            if(imp is not null)
            {
                risultato = new ImpiegatoDTO()
                {
                    Dat = (DateTime)imp.DataAssu,
                    Dip = imp.Dipartimento,
                    Mat = imp.Matricola,
                    Nom = imp.Nominativo
                };
            }

            return risultato;
        }
    }
}

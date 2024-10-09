using REST_03_EF_ferramenta.Models;
using REST_03_EF_ferramenta.Repositories;

namespace REST_03_EF_ferramenta.Services
{
    public class RepartoService
    {
        private static RepartoService? instance;

        public static RepartoService GetInstance()
        {
            if (instance == null)
                instance = new RepartoService();

            return instance;
        }
        private RepartoService() { }

        public RepartoDTO? CercaRepartoPerId(int id)
        {
            RepartoDTO? risultato = null;
            Reparto? reparto = RepartoRepository.GetInstance().GetById(id);

            if (reparto is not null) {
                risultato = new RepartoDTO()
                {
                    Cod = reparto.RepartoCod,
                    Fil = reparto.Fila,
                    Nom = reparto.Nome
                };
            }

            return risultato;
        }

        public RepartoDTO? CercaRepartoPerCodice(string varCod)
        {
            RepartoDTO? risultato = null;

            Reparto? repa = RepartoRepository.GetInstance().GetByCodice(varCod);
            if (repa is not null)
            {
                risultato = new RepartoDTO()
                {
                    Cod = repa.RepartoCod,
                    Fil = repa.Fila,
                    Nom = repa.Nome,
                    Ele = ProdottoService.GetInstance().CercaProdottiPerRepartoId(repa.RepartoId)
                };
            }

            return risultato;
        }

        public bool InserisciReparto(RepartoDTO repaDto) 
        {

            Reparto reparto = new Reparto()
            {
                Fila = repaDto.Fil,
                RepartoCod = repaDto.Cod is not null ? repaDto.Cod : Guid.NewGuid().ToString(),
                Nome = repaDto.Nom,
            };

            return RepartoRepository.GetInstance().Insert(reparto);

        }
    }
}

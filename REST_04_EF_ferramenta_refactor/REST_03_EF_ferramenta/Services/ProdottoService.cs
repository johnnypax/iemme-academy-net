using REST_03_EF_ferramenta.Models;
using REST_03_EF_ferramenta.Repositories;

namespace REST_03_EF_ferramenta.Services
{
    public class ProdottoService
    {
        private static ProdottoService? instance;

        public static ProdottoService GetInstance()
        {
            if (instance == null)
                instance = new ProdottoService();

            return instance;
        }
        private ProdottoService() { }

        public ProdottoDTO? CercaProdotto(string varCodi)
        {
            ProdottoDTO? risultato = null;

            Prodotto? prod = ProdottoRepository.GetInstance().GetByCodiceBarre(varCodi);
            if(prod is not null)
            {
                risultato = new ProdottoDTO()
                {
                    Cod = prod.CodiceBarre,
                    Des = prod.Descrizione,
                    Nom = prod.Nome,
                    Pre = prod.Prezzo,
                    Qua = prod.Quantita,
                    Rep = RepartoService.GetInstance().CercaRepartoPerId(prod.RepartoRif)
                };
            }

            return risultato;
        }

        public List<ProdottoDTO> CercaProdottiPerRepartoId(int id)
        {
            List<ProdottoDTO> risultato = new List<ProdottoDTO>();

            List<Prodotto> prodotti = ProdottoRepository.GetInstance().GetByRepartoRif(id);
            foreach(Prodotto pro in prodotti)
            {
                ProdottoDTO temp = new ProdottoDTO()
                {
                    Cod = pro.CodiceBarre,
                    Des = pro.Descrizione,
                    Nom = pro.Nome,
                    Pre = pro.Prezzo,
                    Qua = pro.Quantita
                };

                risultato.Add(temp);    
            }

            return risultato;
        }
    }
}

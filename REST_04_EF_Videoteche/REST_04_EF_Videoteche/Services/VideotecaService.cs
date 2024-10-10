using REST_04_EF_Videoteche.Controllers;
using REST_04_EF_Videoteche.Models;
using REST_04_EF_Videoteche.Repos;

namespace REST_04_EF_Videoteche.Services
{
    public class VideotecaService
    {
        private static VideotecaService? instance;

        public static VideotecaService GetInstance()
        {
            if (instance == null)
                instance = new VideotecaService();

            return instance;
        }
        private VideotecaService() { }

        public VideotecaDTO? CercaVideoteca(string codice)
        {
            VideotecaDTO? risultato = null;

            Videoteca? vidt = VideotecaRepo.GetInstance().GetByCodice(codice);
            if (vidt is not null)
            {
                risultato = new VideotecaDTO()
                {
                    Cod = vidt.Codice,
                    Ind = vidt.Indirizzo,
                    Nom = vidt.Nome
                };
            }

            return risultato;
        }

        public List<VideotecaDTO> CercaTutteVideoteche()
        {
            List<VideotecaDTO> videotecaDTOs = new List<VideotecaDTO>();

            List<Videoteca> elenco = VideotecaRepo.GetInstance().GetAll();
            foreach(Videoteca v in elenco)
            {
                VideotecaDTO temp = new VideotecaDTO()
                {
                    Cod = v.Codice,
                    Ind = v.Indirizzo,
                    Nom = v.Nome
                };

                videotecaDTOs.Add(temp);
            }

            return videotecaDTOs;
        }

        public bool InserisciVideoteca(VideotecaDTO vidDto)
        {
            Videoteca video = new Videoteca()
            {
                Codice = vidDto.Cod is not null ? vidDto.Cod : Guid.NewGuid().ToString().ToUpper(),
                Indirizzo = vidDto.Ind,
                Nome = vidDto.Nom
            };

            return VideotecaRepo.GetInstance().Insert(video);
        }

        public bool EliminaVideoteca(string varCod)
        {
            bool risultato = false;

            Videoteca? videoteca = VideotecaRepo.GetInstance().GetByCodice(varCod);
            if(videoteca is not null)
                risultato = VideotecaRepo.GetInstance().Delete(videoteca.VideotecaId);

            return risultato;
        }
    }
}

using ASP_WEB_05_Esercizio_Corsi.Models;
using ASP_WEB_05_Esercizio_Corsi.Repos;

namespace ASP_WEB_05_Esercizio_Corsi.Services
{
    public class AdminService
    {
        private readonly AdminRepo _repo;

        public AdminService(AdminRepo repo)
        {
            _repo = repo;
        }

        public bool VerificaUsernamePassword(AdminDTO adDto)
        {
            bool risultato = false;

            if(adDto.User is not null && adDto.Pass is not null)
            {
                Admin? adm = _repo.GetByUsernamePassword(adDto.User, adDto.Pass);
                if (adm is not null)
                    risultato = true;
            }

            return risultato;
        }
    }
}

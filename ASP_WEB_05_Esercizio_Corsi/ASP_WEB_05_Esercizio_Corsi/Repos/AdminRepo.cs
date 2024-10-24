using ASP_WEB_05_Esercizio_Corsi.Context;
using ASP_WEB_05_Esercizio_Corsi.Models;

namespace ASP_WEB_05_Esercizio_Corsi.Repos
{
    public class AdminRepo
    {
        private readonly PoloFormativoContext _context;

        public AdminRepo(PoloFormativoContext context)
        {
            _context = context;
        }

        public Admin? GetByUsernamePassword(string user, string pass)
        {
            return _context.Amministratori.FirstOrDefault(a => a.User == user && a.Pass == pass);
        }
    }
}

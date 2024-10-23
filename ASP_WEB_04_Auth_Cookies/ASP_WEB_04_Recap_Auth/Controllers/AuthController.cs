using ASP_WEB_04_Recap_Auth.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP_WEB_04_Recap_Auth.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult VerificaCredenziali(Utente utente) {

            if (string.IsNullOrWhiteSpace(utente.Password) || string.IsNullOrWhiteSpace(utente.Username))
                return Redirect("/Auth/Login");

            if (utente.Username == "giovanni" && utente.Password == "1234")      //CHECK SUL DB
            {
                HttpContext.Response.Cookies.Append("utenteLoggato", "ADMIN");
                return Redirect("/Admin/Dashboard");
            }

            if (utente.Username == "valeria" && utente.Password == "4321")      //CHECK SUL DB
            {
                HttpContext.Response.Cookies.Append("utenteLoggato", "USER");
                return Redirect("/User/Elenco");
            }

            return Redirect("/Auth/Login");
        }
    }
}

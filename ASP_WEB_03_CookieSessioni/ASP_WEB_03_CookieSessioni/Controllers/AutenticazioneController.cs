using ASP_WEB_03_CookieSessioni.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP_WEB_03_CookieSessioni.Controllers
{
    public class AutenticazioneController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult VerificaCredenziali(Utente objUte)
        {
            if (string.IsNullOrWhiteSpace(objUte.Username) || string.IsNullOrWhiteSpace(objUte.Password))
                return Redirect("/Autenticazione/Login");

            if(objUte.Username == "giovanni" && objUte.Password == "pace")
            {
                HttpContext.Response.Cookies.Append("utenteLoggato", "ADMIN");
                return Redirect("/Autenticazione/Profiloamministratore");
            }

            if (objUte.Username == "valeria" && objUte.Password == "verdi")
            {
                HttpContext.Response.Cookies.Append("utenteLoggato", "USER");
                return Redirect("/Autenticazione/Profiloutente");
            }

            return Redirect("/Autenticazione/Login");
        }

        public IActionResult Profiloamministratore()
        {
            string? valoreCookie = HttpContext.Request.Cookies["utenteLoggato"];

            if(valoreCookie != null && valoreCookie == "ADMIN")
                return View();

            return Redirect("/Autenticazione/Login");
        }

        public IActionResult Profiloutente()
        {
            string? valoreCookie = HttpContext.Request.Cookies["utenteLoggato"];

            if (valoreCookie != null && valoreCookie == "USER")
                return View();

            return Redirect("/Autenticazione/Login");
        }
    }
}

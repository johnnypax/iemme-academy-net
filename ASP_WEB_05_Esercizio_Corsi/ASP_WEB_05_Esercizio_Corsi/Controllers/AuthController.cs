using ASP_WEB_05_Esercizio_Corsi.Models;
using ASP_WEB_05_Esercizio_Corsi.Services;
using Microsoft.AspNetCore.Mvc;

namespace ASP_WEB_05_Esercizio_Corsi.Controllers
{
    public class AuthController : Controller
    {
        private readonly AdminService _service;

        public AuthController(AdminService service)
        {
            _service = service;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Verifica(AdminDTO adDto) {

            if (string.IsNullOrWhiteSpace(adDto.User) || string.IsNullOrWhiteSpace(adDto.Pass))
                return Redirect("/Auth/Login");

            if (_service.VerificaUsernamePassword(adDto))
            {
                HttpContext.Session.SetString("userLogged", "ADMIN");
                return Redirect("/Corso/Lista");
            }

            return Redirect("/Auth/Login");
        }

    }
}

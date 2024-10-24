using ASP_WEB_05_Esercizio_Corsi.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP_WEB_05_Esercizio_Corsi.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Verifica(AdminDTO adDto) {
            return Ok();
        }

    }
}

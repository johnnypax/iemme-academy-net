using ASP_WEB_05_Esercizio_Corsi.Models;
using ASP_WEB_05_Esercizio_Corsi.Services;
using Microsoft.AspNetCore.Mvc;

namespace ASP_WEB_05_Esercizio_Corsi.Controllers
{
    public class CorsoController : Controller
    {
        private readonly CorsoService _service;

        public CorsoController(CorsoService service)
        {
            _service = service;
        }

        public IActionResult Lista()
        {
            string? risultatoSess = HttpContext.Session.GetString("userLogged");
            if (risultatoSess is null && risultatoSess != "ADMIN")
                return Redirect("/Auth/Login");

            IEnumerable<Corso> elenco = _service.List();

            return View(elenco);
        }
    }
}

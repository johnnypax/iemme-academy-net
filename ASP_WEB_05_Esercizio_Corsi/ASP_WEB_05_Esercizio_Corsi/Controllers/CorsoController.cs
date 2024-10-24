using ASP_WEB_05_Esercizio_Corsi.Models;
using ASP_WEB_05_Esercizio_Corsi.Services;
using Microsoft.AspNetCore.Mvc;

namespace ASP_WEB_05_Esercizio_Corsi.Controllers
{
    public class CorsoController : Controller
    {
        private readonly CorsoService _service;
        private readonly ILogger<CorsoController> _logger;

        public CorsoController(CorsoService service, ILogger<CorsoController> logger)
        {
            _service = service;
            _logger = logger;
        }

        private bool IsAutorizzato()
        {
            string? risultatoSess = HttpContext.Session.GetString("userLogged");
            if (risultatoSess is null && risultatoSess != "ADMIN")
                return false;

            return true;
        }

        public IActionResult Lista()
        {
            if (!IsAutorizzato())
            {
                _logger.LogError("Errore, utente non autorizzato sull'endpoint Corso/Lista");
                return Redirect("/Auth/Login");
            }


            _logger.LogInformation("Utente autorizzato a vedere Lista");
            IEnumerable<Corso> elenco = _service.List();

            return View(elenco);
        }

        public IActionResult Inserisci()
        {
            if (!IsAutorizzato())
                return Redirect("/Auth/Login");

            return View();
        }

        [HttpPost]
        public IActionResult Salva(CorsoDTO corDto)
        {
            if (!IsAutorizzato())
            {
                _logger.LogError("Errore, utente non autorizzato sull'endpoint Corso/Salva");
                return Redirect("/Auth/Login");
            }

            if(corDto.Nom is null)
            {
                HttpContext.Session.SetString("errore", "Attenzione il nome non può essere vuoto");
                return Redirect("/Error/Generic");
            }

            if (_service.Insert(corDto))
                return Redirect("/Corso/Lista");

            HttpContext.Session.SetString("errore", "Errore di inserimento del corso");
            return Redirect("/Error/Generic");
        }
    }
}

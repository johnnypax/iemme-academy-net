using esercizio_01_officina.Models;
using esercizio_01_officina.Services;
using Microsoft.AspNetCore.Mvc;

namespace esercizio_01_officina.Controllers
{
    [ApiController]
    [Route("api/interventi")]
    public class InterventoController : Controller
    {
        private readonly InterventoService _service;

        public InterventoController(InterventoService service)
        {
            _service = service;
        }

        [HttpGet("{varCodice}")]
        public ActionResult<InterventoDTO?> VisualizzaIntervento(string varCodice)
        {
            if (string.IsNullOrWhiteSpace(varCodice))
                return BadRequest();

            InterventoDTO? ris = _service.CercaPerCodice(varCodice);
            if(ris is not null)
                return Ok(ris);

            return NotFound();
        }

        [HttpPost]
        public IActionResult InserisciIntervento(InterventoDTO intDto)
        {
            //TODO: Filtri

            if (_service.Inserisci(intDto))
                return Ok();

            return BadRequest();
        }
    }
}

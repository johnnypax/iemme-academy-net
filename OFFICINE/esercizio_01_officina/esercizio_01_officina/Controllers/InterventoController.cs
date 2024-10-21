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
        public ActionResult<InterventoDTO> CercaIntervento(string varCodice) {
            if(string.IsNullOrWhiteSpace(varCodice))
                return BadRequest();

            InterventoDTO? intDto = _service.CercaPerCodice(varCodice);
            if(intDto is not null)
                return Ok(intDto);

            return NotFound();
        }

        [HttpGet]
        public ActionResult<IEnumerable<InterventoDTO>> ListaInterventi()
        {
            return Ok(_service.CercaTutti());
        }

        [HttpPost]
        public IActionResult InserisciIntervento(InterventoDTO intDto)
        {
            if(intDto.CliRif is not null && string.IsNullOrWhiteSpace(intDto.CliRif.Cod))
                return BadRequest();

            if (_service.Inserisci(intDto))
                return Ok();

            return BadRequest();
        }
    }
}

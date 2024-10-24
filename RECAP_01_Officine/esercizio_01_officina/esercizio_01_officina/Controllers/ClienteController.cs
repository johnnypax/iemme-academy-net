using esercizio_01_officina.Models;
using esercizio_01_officina.Services;
using Microsoft.AspNetCore.Mvc;

namespace esercizio_01_officina.Controllers
{
    [ApiController]
    [Route("api/clienti")]
    public class ClienteController : Controller
    {
        private readonly ClienteService _service;

        public ClienteController(ClienteService service)
        {
            _service = service;
        }

        [HttpGet("{varCodice}")]
        public ActionResult<ClienteDTO?> VisualizzaCliente(string varCodice) {

            if (string.IsNullOrWhiteSpace(varCodice))
                return BadRequest();
        
            ClienteDTO? risultato = _service.CercaPerCodice(varCodice);
            if(risultato is not null)
                return Ok(risultato);

            return NotFound();
        }

        [HttpGet]
        public ActionResult<IEnumerable<ClienteDTO>> ListaClienti() {
            return Ok(_service.CercaTutti());
        }

        [HttpPost]
        public IActionResult InserisciCliente(ClienteDTO cliDto)
        {
            if(string.IsNullOrWhiteSpace(cliDto.Nom) || string.IsNullOrWhiteSpace(cliDto.Cog))
                return BadRequest();

            if (_service.Inserisci(cliDto))
                return Ok();

            return BadRequest();
        }

        [HttpDelete("{varCodice}")]
        public IActionResult EliminaCliente(string varCodice)
        {
            if (string.IsNullOrWhiteSpace(varCodice))
                return BadRequest();

            if (_service.Elimina(varCodice))
                return Ok();

            return BadRequest();
        }

        [HttpPut("{varCodice}")]
        public IActionResult AggiornaCliente(string varCodice, ClienteDTO cliDto)
        {
            if (string.IsNullOrWhiteSpace(varCodice) || 
                string.IsNullOrWhiteSpace(cliDto.Nom) || 
                string.IsNullOrWhiteSpace(cliDto.Cog))
                    return BadRequest();

            cliDto.Cod = varCodice;

            if (_service.Aggiorna(cliDto))
                return Ok();

            return BadRequest();
        }
    }
}

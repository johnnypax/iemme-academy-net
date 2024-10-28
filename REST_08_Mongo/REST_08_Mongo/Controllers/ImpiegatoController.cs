using Microsoft.AspNetCore.Mvc;
using REST_08_Mongo.Models;
using REST_08_Mongo.Services;

namespace REST_08_Mongo.Controllers
{
    [ApiController]
    [Route("api/impiegati")]
    public class ImpiegatoController : Controller
    {
        private readonly ImpiegatoService _service;

        public ImpiegatoController(ImpiegatoService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult Inserisci(ImpiegatoDTO objDto)
        {
            if(ModelState.IsValid)
            {
                if (_service.Inserisci(objDto))
                    return Ok(new Risposta() { Status = "SUCCESS" });
            }

            return BadRequest();
        }

        [HttpGet]
        public ActionResult<Risposta> Lista()
        {
            return Ok(new Risposta()
            {
                Status = "SUCCESS",
                Data = _service.CercaTutti()
            });
        }

        [HttpGet("{varMatr}")]
        public ActionResult<Risposta> CercaPerCodice(string varMatr)
        {
            ImpiegatoDTO? impDto = _service.CercaPerMatricola(varMatr);

            if (impDto is null)
                return NotFound(new Risposta()
                {
                    Status = "ERROR",
                    Data = "Matricola non trovata"
                });

            return Ok(new Risposta()
            {
                Status = "SUCCESS",
                Data = impDto
            });
        }
    }
}

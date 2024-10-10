using Microsoft.AspNetCore.Mvc;
using REST_05_EF_Videoteche_Ref.Models;
using REST_05_EF_Videoteche_Ref.Services;

namespace REST_05_EF_Videoteche_Ref.Controllers
{
    [ApiController]
    [Route("api/videoteche")]
    public class VideotecaController : Controller
    {
        private readonly VideotecaService _service;

        public VideotecaController(VideotecaService service)
        {
            _service = service;
        }

        [HttpGet("{varCodice}")]
        public ActionResult<VideotecaDTO?> CercaPerCodice(string varCodice) {
            if (string.IsNullOrWhiteSpace(varCodice))
                return BadRequest();
            
            VideotecaDTO? risultato = _service.Cerca(varCodice);
            if(risultato is not null)
                return Ok(risultato);

            return NotFound();
        }
    }
}

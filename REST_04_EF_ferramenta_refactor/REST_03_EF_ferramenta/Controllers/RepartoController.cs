using Microsoft.AspNetCore.Mvc;
using REST_03_EF_ferramenta.Models;
using REST_03_EF_ferramenta.Services;

namespace REST_03_EF_ferramenta.Controllers
{
    [ApiController]
    [Route("api/reparto")]
    public class RepartoController : Controller
    {
        [HttpPost]
        public IActionResult InserisciReparto(RepartoDTO objDto)
        {
            if(string.IsNullOrWhiteSpace(objDto.Nom) || string.IsNullOrWhiteSpace(objDto.Fil))
                return BadRequest();

            bool risultato = RepartoService.GetInstance().InserisciReparto(objDto);

            if (risultato)
                return Ok();

            return BadRequest();
        }

        [HttpGet("{varCodice}")]
        public ActionResult<RepartoDTO?> CercaReparto(string varCodice)
        {
            RepartoDTO? risultato = RepartoService.GetInstance().CercaRepartoPerCodice(varCodice);
            if (risultato is not null)
                return Ok(risultato);

            return NotFound();
        }
    }
}

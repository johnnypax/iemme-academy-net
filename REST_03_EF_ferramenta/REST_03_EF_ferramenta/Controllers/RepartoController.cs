using Microsoft.AspNetCore.Mvc;
using REST_03_EF_ferramenta.Models;
using REST_03_EF_ferramenta.Repositories;

namespace REST_03_EF_ferramenta.Controllers
{
    [ApiController]
    [Route("api/reparto")]
    public class RepartoController : Controller
    {
        [HttpGet]
        public ActionResult<List<Reparto>> ElencoReparti()
        {
            return Ok(RepartoRepository.GetInstance().GetAll());
        }

        [HttpGet("{varCodi}")]
        public ActionResult<Reparto?> CercaRepartoPerCodice(string varCodi)
        {
            Reparto? risu = RepartoRepository.GetInstance().GetByCodice(varCodi);

            if (risu is not null)
                return Ok(risu);

            return NotFound();
        }

        [HttpPost]
        public IActionResult InserisciReparto(Reparto objLib)
        {
            if (RepartoRepository.GetInstance().Insert(objLib))
                return Ok();

            return BadRequest();
        }

        [HttpDelete("{varCodice}")]
        public IActionResult EliminaReparto(string varCodice)
        {
            Reparto? lib = RepartoRepository.GetInstance().GetByCodice(varCodice);
            if (lib is not null)
            {
                if (RepartoRepository.GetInstance().Delete(lib.RepartoId))
                    return Ok();
            }

            return BadRequest();
        }

        [HttpPut]
        public IActionResult ModificaReparto(Reparto objLib)
        {
            if (RepartoRepository.GetInstance().Update(objLib))
                return Ok();

            return BadRequest();
        }
    }
}

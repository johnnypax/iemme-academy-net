using Microsoft.AspNetCore.Mvc;
using REST_03_EF_ferramenta.Models;
using REST_03_EF_ferramenta.Repositories;

namespace REST_03_EF_ferramenta.Controllers
{
    [ApiController]
    [Route("api/prodotto")]
    public class ProdottoController : Controller
    {
        [HttpGet]
        public ActionResult<List<Prodotto>> ElencoProdotti()
        {
            return Ok(ProdottoRepository.GetInstance().GetAll());
        }

        [HttpGet("{varCodi}")]
        public ActionResult<Prodotto?> CercaProdottoPerCodice(string varCodi)
        {
            Prodotto? risu = ProdottoRepository.GetInstance().GetByCodiceBarre(varCodi);

            if (risu is not null)
                return Ok(risu);

            return NotFound();
        }

        [HttpPost]
        public IActionResult InserisciProdotto(Prodotto objLib)
        {
            if (ProdottoRepository.GetInstance().Insert(objLib))
                return Ok();

            return BadRequest();
        }

        [HttpDelete("{varCodice}")]
        public IActionResult EliminaProdotto(string varCodice)
        {
            Prodotto? lib = ProdottoRepository.GetInstance().GetByCodiceBarre(varCodice);
            if (lib is not null)
            {
                if (ProdottoRepository.GetInstance().Delete(lib.ProdottoId))
                    return Ok();
            }

            return BadRequest();
        }

        [HttpPut]
        public IActionResult ModificaProdotto(Prodotto objLib)
        {
            if (ProdottoRepository.GetInstance().Update(objLib))
                return Ok();

            return BadRequest();
        }
    }
}

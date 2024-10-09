using Microsoft.AspNetCore.Mvc;
using REST_03_EF_ferramenta.Models;
using REST_03_EF_ferramenta.Services;

namespace REST_03_EF_ferramenta.Controllers
{
    [ApiController]
    [Route("api/prodotto")]
    public class ProdottoController : Controller
    {
        [HttpGet("{varCodice}")]
        public ActionResult<ProdottoDTO?> Cerca(string varCodice)
        {
            if (string.IsNullOrWhiteSpace(varCodice))
                return BadRequest();

            ProdottoDTO? prod = ProdottoService.GetInstance().CercaProdotto(varCodice);
            if(prod is not null)
                return Ok(prod);

            return NotFound();
        }


    }
}

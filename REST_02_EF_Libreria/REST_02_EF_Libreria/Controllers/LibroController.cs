using Microsoft.AspNetCore.Mvc;
using REST_02_EF_Libreria.Models;
using REST_02_EF_Libreria.Repositories;

namespace REST_02_EF_Libreria.Controllers
{
    [ApiController]
    [Route("api/libri")]
    public class LibroController : Controller
    {
        [HttpGet]
        public ActionResult<List<Libro>> ElencoLibri()
        {
            List<Libro> elenco = LibroRepo.GetInstance().GetAll();
            return Ok(elenco);
        }

        [HttpGet("{varCodi}")]
        public ActionResult<Libro?> CercaLibroPerCodice(string varCodi)
        {
            Libro? risu = LibroRepo.GetInstance().GetByCodice(varCodi);

            if(risu is not null)
                return Ok(risu);

            return NotFound();
        }

        [HttpPost]
        public IActionResult InserisciLibro(Libro objLib)
        {
            if (LibroRepo.GetInstance().Insert(objLib))
                return Ok();

            return BadRequest();
        }

        [HttpDelete("{varCodice}")]
        public IActionResult EliminaLibro(string varCodice)
        {
            Libro? lib = LibroRepo.GetInstance().GetByCodice(varCodice);
            if(lib is not null)
            {
                if (LibroRepo.GetInstance().Delete(lib.LibroId))
                    return Ok();
            }

            return BadRequest();
        }

        [HttpPut]
        public IActionResult ModificaLibro(Libro objLib)
        {
            if (LibroRepo.GetInstance().Update(objLib))
                return Ok();

            return BadRequest();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using REST_04_EF_Videoteche.Models;
using REST_04_EF_Videoteche.Services;

namespace REST_04_EF_Videoteche.Controllers
{
    [ApiController]
    [Route("api/videoteche")]
    public class VideotecaController : Controller
    {
        /// <summary>
        /// Metodo GET per il recupero dei dettagli di una singola Videoteca
        /// </summary>
        /// <param name="varCodice">Codice univoco con formato GUID che identifica una videoteca</param>
        /// <returns></returns>
        [HttpGet("{varCodice}")]
        public ActionResult<VideotecaDTO?> VisualizzaVideoteca(string varCodice)
        {
            if (string.IsNullOrWhiteSpace(varCodice))
                return BadRequest();

            VideotecaDTO? risultato = VideotecaService.GetInstance().CercaVideoteca(varCodice);
            if(risultato is not null)
                return Ok(risultato);

            return NotFound();
        }

        [HttpGet]
        public ActionResult<List<VideotecaDTO>> ElencoVideoteche()
        {
            return Ok(VideotecaService.GetInstance().CercaTutteVideoteche());
        }
    }
}

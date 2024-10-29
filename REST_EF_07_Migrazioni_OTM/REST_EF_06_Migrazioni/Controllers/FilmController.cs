using Microsoft.AspNetCore.Mvc;
using REST_EF_06_Migrazioni.Models;
using REST_EF_06_Migrazioni.Services;

namespace REST_EF_06_Migrazioni.Controllers
{
    [ApiController]
    [Route("api/film")]
    public class FilmController : Controller
    {
        private readonly FilmService _service;

        public FilmController (FilmService service) {
                _service = service;
        }

        [HttpGet("{varCodice}")]
        public ActionResult<Risposta> Cerca(string varCodice)
        {
            return Ok(new Risposta()
            {
                Status = "SUCCESS",
                Data = _service.CercaPerCodice(varCodice)
            });
        }
    }
}

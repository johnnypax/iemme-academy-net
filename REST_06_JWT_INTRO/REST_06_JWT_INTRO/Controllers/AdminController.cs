using Microsoft.AspNetCore.Mvc;
using REST_06_JWT_INTRO.Filters;

namespace REST_06_JWT_INTRO.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdminController : Controller
    {
        [HttpGet("profilo")]
        [AutorizzaUtentePerTipo("ADMIN")]
        public IActionResult Profilo()
        {
            return Ok(new {
                status = "SUCCESS",
                dati = "Profilo dell'amministratore"
            });
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using REST_06_JWT_INTRO.Filters;

namespace REST_06_JWT_INTRO.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        [HttpGet("profilo")]
        [AutorizzaUtentePerTipo("USER")]
        public IActionResult Profilo()
        {
            return Ok(new
            {
                status = "SUCCESS",
                dati = "Profilo dell'utente"
            });
        }
    }
}

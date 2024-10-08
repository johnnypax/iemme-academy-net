using Microsoft.AspNetCore.Mvc;

namespace REST_01_Introduzione.Controllers
{
    [ApiController]
    [Route("api/hello")]
    public class HelloController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok("Ciao, il metodo Index");
        }

        [HttpGet("ciao")]
        public IActionResult Saluta()
        {
            return Ok("Ciao GIovanni");
        }

        [HttpGet("saluta/{varNome}")]
        public IActionResult SalutaPersonalizzato(string varNome)
        {
            return Ok($"Ciao {varNome}");
        }

        [HttpGet("saluta/{varNome}/{varCognome}")]
        public IActionResult SalutaPersonalizzato(string varNome, string varCognome)
        {
            return Ok($"Ciao {varNome} {varCognome}");
        }

        [HttpGet("test")]
        public IActionResult TestGet()
        {
            return Ok("Test di GET");
        }

        [HttpPost("test")]
        public IActionResult TestPost()
        {
            return Ok("Test di POST");
        }
    }
}

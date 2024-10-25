using ASP_WEB_05_Esercizio_Corsi.Models;
using ASP_WEB_05_Esercizio_Corsi.Services;
using Microsoft.AspNetCore.Mvc;

namespace ASP_WEB_05_Esercizio_Corsi.Controllers
{
    [ApiController]
    [Route("api/iscrizione")]
    public class IscrizioneApiController : Controller
    {
        private readonly IscrizioneApiService _service;
        public IscrizioneApiController(IscrizioneApiService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult Inserisci(IscrizioneDTO iscDto)
        {
            if (
                string.IsNullOrWhiteSpace(iscDto.Nome) || 
                string.IsNullOrWhiteSpace(iscDto.Cognome) || 
                string.IsNullOrWhiteSpace(iscDto.Email))
                return BadRequest();

            if (_service.Insert(iscDto))
                return Ok(
                    new { Disiscrizione = iscDto.CodiceDis }
                    );

            return BadRequest();
        }
    }
}

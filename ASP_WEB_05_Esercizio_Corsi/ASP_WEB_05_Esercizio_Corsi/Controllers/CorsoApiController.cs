using ASP_WEB_05_Esercizio_Corsi.Models;
using ASP_WEB_05_Esercizio_Corsi.Services;
using Microsoft.AspNetCore.Mvc;

namespace ASP_WEB_05_Esercizio_Corsi.Controllers
{
    [ApiController]
    [Route("api/corso")]
    public class CorsoApiController : Controller
    {
        private readonly CorsoApiService _service;

        public CorsoApiController(CorsoApiService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<CorsoDTO>> Lista()
        {
            return Ok(_service.List());
        }
    }
}

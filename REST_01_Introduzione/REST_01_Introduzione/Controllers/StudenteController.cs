using Microsoft.AspNetCore.Mvc;
using REST_01_Introduzione.Models;

namespace REST_01_Introduzione.Controllers
{
    [ApiController]
    [Route("api/studente")]
    public class StudenteController : Controller
    {
        [HttpGet("dettaglio")]
        public ActionResult<Studente?> DettaglioStudente()
        {
            Studente stu = new Studente()
            {
                Id = 1,
                Nome = "Giovanni",
                Cognome = "Pace",
                Matricola = "AB1234"
            };

            return Ok(stu);
        }

        [HttpGet("lista")]
        public ActionResult<List<Studente>> ElencoStudenti()
        {
            List<Studente> elenco = new List<Studente>()
            {
                new Studente() {Id = 1, Nome = "Giovanni", Cognome = "Pace", Matricola = "AB1234"},
                new Studente() {Id = 2, Nome = "Valeria", Cognome = "Verdi", Matricola = "AB1235"},
                new Studente() {Id = 3, Nome = "Marika", Cognome = "Mariko", Matricola = "AB1236"},
            };

            return Ok(elenco);
        }
    }
}

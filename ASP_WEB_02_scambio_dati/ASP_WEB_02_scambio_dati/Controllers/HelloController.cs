using ASP_WEB_02_scambio_dati.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP_WEB_02_scambio_dati.Controllers
{
    public class HelloController : Controller
    {
        private string SalutaGenerico()
        {
            return "Ciao sono Giovanni";
        }

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Titolo = "Sono la pagina Index";
            ViewBag.Sottotitolo = "Sono il sottotitolo";
            ViewBag.Numero = 37;
            ViewBag.Saluta = SalutaGenerico();

            Persona val = new Persona()
            {
                Nominativo = "Valeria Verdi",
                CodFis = "VLRVRD"
            };

            return View(val);
        }

        [HttpGet]
        public IActionResult Lista()
        {
            List<Persona> elenco = new List<Persona>()
            {
                new Persona() { Nominativo = "Giovanni Pace", CodFis = "PCAGNN" },
                new Persona() { Nominativo = "Valeria Verdi", CodFis = "VLRVRD" },
                new Persona() { Nominativo = "Mario Rossi", CodFis = "MRRRSS" }
            };

            return View(elenco);
        }
    }
}

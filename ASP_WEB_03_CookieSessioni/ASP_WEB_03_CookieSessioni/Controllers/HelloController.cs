using ASP_WEB_03_CookieSessioni.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ASP_WEB_03_CookieSessioni.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Emissione()
        {
            HttpContext.Response.Cookies.Append("lingua", "ITA");
            HttpContext.Response.Cookies.Append("dimensioneFont", "32px");

            Persona per = new Persona()
            {
                Nome = "Giovanni",
                Cognome = "Pace"
            };

            HttpContext.Response.Cookies.Append("utente", JsonConvert.SerializeObject(per) );

            return View();
        }

        public IActionResult Lettura()
        {
            ViewBag.lingua = HttpContext.Request.Cookies["lingua"];
            ViewBag.dimensione = HttpContext.Request.Cookies["dimensioneFont"];

            string? persona = HttpContext.Request.Cookies["utente"];
            if (persona is not null)
                ViewBag.utente = JsonConvert.DeserializeObject<Persona>(persona);

            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace ASP_WEB_05_Esercizio_Corsi.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Generic()
        {
            ViewBag.errore = HttpContext.Session.GetString("errore");
            HttpContext.Session.Remove("errore");


            return View();
        }
    }
}

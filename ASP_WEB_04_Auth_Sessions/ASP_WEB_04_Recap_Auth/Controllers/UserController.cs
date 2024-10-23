using Microsoft.AspNetCore.Mvc;

namespace ASP_WEB_04_Recap_Auth.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Elenco()
        {
            string? valSessione = HttpContext.Session.GetString("utenteLoggato");

            if (valSessione is not null && valSessione == "USER")
            {
                ViewBag.userSelected = "USER";
                return View();
            }

            return Redirect("/Auth/Login");
        }
    }
}

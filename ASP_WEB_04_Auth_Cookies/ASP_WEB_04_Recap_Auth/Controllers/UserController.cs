using Microsoft.AspNetCore.Mvc;

namespace ASP_WEB_04_Recap_Auth.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Elenco()
        {
            string? valCookie = HttpContext.Request.Cookies["utenteLoggato"];

            if (valCookie is not null && valCookie == "USER")
                return View();

            return Redirect("/Auth/Login");
        }
    }
}

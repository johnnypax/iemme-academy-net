using Microsoft.AspNetCore.Mvc;

namespace ASP_WEB_04_Recap_Auth.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Dashboard()
        {
            string? valCookie = HttpContext.Request.Cookies["utenteLoggato"];

            if (valCookie is not null && valCookie == "ADMIN")
                return View();

            return Redirect("/Auth/Login");
        }
    }
}

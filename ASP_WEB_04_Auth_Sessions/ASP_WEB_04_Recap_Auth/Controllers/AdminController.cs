using Microsoft.AspNetCore.Mvc;

namespace ASP_WEB_04_Recap_Auth.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Dashboard()
        {
            string? valSessione = HttpContext.Session.GetString("utenteLoggato");

            if (valSessione is not null && valSessione == "ADMIN")
            {
                ViewBag.userSelected = "ADMIN";
                return View();

            }

            return Redirect("/Auth/Login");
        }
    }
}

using ASP_WEB_01_Introduzione.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASP_WEB_01_Introduzione.Controllers
{
    public class PippoController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Test()
        {
            return View();
        }
    }
}

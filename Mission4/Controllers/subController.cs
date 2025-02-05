using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission4.Models;

namespace Mission4.Controllers
{
    public class subController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult secondpage()
        {
            return View();
        }

    }
}

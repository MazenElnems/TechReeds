using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TechReeds.Models;

namespace TechReeds.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

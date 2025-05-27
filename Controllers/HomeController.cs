using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
<<<<<<< HEAD
using SolidOrderProcessing.Models;

namespace SolidOrderProcessing.Controllers
=======
using TaskManager.Models;

namespace TaskManager.Controllers
>>>>>>> 0b32b568913dd742e9ab80fc8b6efe6b0c7d873e
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

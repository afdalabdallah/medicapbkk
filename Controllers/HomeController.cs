using Microsoft.AspNetCore.Mvc;
using QUIS_1.Models;
using System.Diagnostics;

namespace QUIS_1.Controllers
{
    public class Q1Controller : Controller
    {
        private readonly ILogger<Q1Controller> _logger;

        public Q1Controller(ILogger<Q1Controller> logger)
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
        public IActionResult profile()
        {
            return View();
        }
        public IActionResult service()
        {
            return View();
        }
        public IActionResult collaboration()
        {
            return View();
        }
        public IActionResult company()
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
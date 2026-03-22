using System.Diagnostics;
using LeaveMnagementSystem.web.Models;
using Microsoft.AspNetCore.Mvc;

namespace LeaveMnagementSystem.web.Controllers
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

        public IActionResult About()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

        // This Action is shared among multiple screens, becuase of that it is in the shared folder not in the home.
        public IActionResult Error()
        {
            var mdoel = new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            };
            return View(mdoel);
        }
    }
}

using LeaveMnagementSystem.web.Models;
using Microsoft.AspNetCore.Mvc;

namespace LeaveMnagementSystem.web.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            var name = new TestViewModel
            {
                Name = "Test",
                DateOfBirth = new DateTime(1999,11,08)
            };
            return View(name); 
        }
    }
}

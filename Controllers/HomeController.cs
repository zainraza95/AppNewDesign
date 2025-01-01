using Microsoft.AspNetCore.Mvc;
using NewApp.Models;
using System.Diagnostics;

namespace NewApp.Controllers
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
            var viewModel = new UserDashboardViewModel
            {
                UserName = "Zain Raza",
                AccountNumber = "12345678",
                CurrentDate = DateTime.Now
            };
            return View(viewModel);
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

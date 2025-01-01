using Microsoft.AspNetCore.Mvc;

namespace NewApp.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Test()
        {
            return View();
        }
    }
}

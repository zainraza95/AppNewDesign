using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace YourNamespace.Controllers
{
    public class CacheController : Controller
    {
        [HttpPost]
        public IActionResult Clear()
        {
            // Add headers to clear cache
            Response.Headers["Cache-Control"] = "no-cache, no-store, must-revalidate";
            Response.Headers["Pragma"] = "no-cache";
            Response.Headers["Expires"] = "0";

            // Optional: Perform additional cache clearing logic if necessary
            HttpContext.Response.Cookies.Delete("YourCookieName"); // If cookies are involved

            return Ok(new { message = "Cache cleared" });
        }
    }
}

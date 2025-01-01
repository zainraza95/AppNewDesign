using Microsoft.AspNetCore.Mvc;

public class ExchangeRateController : Controller
{
    public IActionResult Index()
    {
        var viewModel = new ExchangeRateViewModel();
        return View(viewModel);
    }

    [HttpPost]
    public IActionResult Calculate([FromBody] ExchangeRateViewModel model)
    {
        return Json(new { 
            gmdAmount = model.GmdAmount,
            pkrAmount = model.PkrAmount
        });
    }
}


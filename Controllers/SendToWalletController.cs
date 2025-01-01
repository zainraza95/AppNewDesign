using Microsoft.AspNetCore.Mvc;

public class SendToWalletController : Controller
{
    public IActionResult Index()
    {
        var viewModel = new SendToWalletViewModel
        {
            Amount = 45.00m,
            SendingAmount = 39.0000m,
            ReceiverAmount = 39.0000m,
            TotalDeduction = 45.00m,
            BeneficiaryId = "2203224564",
            BeneficiaryName = "GMD Zain Ewallet2"
        };
        return View(viewModel);
    }

    [HttpPost]
    public IActionResult Index(SendToWalletViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }
        
        // Process the wallet transfer
        return RedirectToAction("Confirmation");
    }
}


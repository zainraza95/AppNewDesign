using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

public class ElectricityController : Controller
{
    public IActionResult Index()
    {
        var viewModel = new ElectricityTopUpViewModel
        {
            Beneficiaries = new List<SelectListItem>
            {
                new SelectListItem { Value = "pak-bene", Text = "Pak Bene" },
                new SelectListItem { Value = "other", Text = "Other Beneficiary" }
            },
            BillerAccounts = new List<string>
            {
                "SNGPL - 125474",
                "SNGPL - 8574555"
            },
            PaymentMethod = "bill-payment"
        };
        return View(viewModel);
    }

    [HttpPost]
    public IActionResult Process(ElectricityTopUpViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return View("SendMoney", model);
        }
        
        // Process the electricity payment
        return RedirectToAction("Confirmation");
    }
}


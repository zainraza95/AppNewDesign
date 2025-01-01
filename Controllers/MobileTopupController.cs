using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

public class MobileTopupController : Controller
{
    public IActionResult Index()
    {
        var viewModel = new MobileTopupViewModel
        {
            Beneficiaries = new List<SelectListItem>
            {
                new SelectListItem { Value = "pak-bene", Text = "Pak Bene" },
                new SelectListItem { Value = "other", Text = "Other Beneficiary" }
            },
            Amount = 100.00m
        };
        return View(viewModel);
    }

    [HttpPost]
    public IActionResult Process(MobileTopupViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return View("SendMoney", model);
        }
        
        // Process the mobile top-up
        return RedirectToAction("Confirmation");
    }
}


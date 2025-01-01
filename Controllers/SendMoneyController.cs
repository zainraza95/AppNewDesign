using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

public class SendMoneyController : Controller
{
    public IActionResult Index()
    {
        var viewModel = new SendMoneyViewModel
        {
            Beneficiaries = new List<SelectListItem>
            {
                new SelectListItem { Value = "cp-bene", Text = "Select Beneficiary" },
                new SelectListItem { Value = "other", Text = "Test Bene" }
            }
        };
        return View(viewModel);
    }
}


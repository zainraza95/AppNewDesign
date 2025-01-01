using Microsoft.AspNetCore.Mvc.Rendering;

public class SendMoneyViewModel
{
    public string SelectedBeneficiary { get; set; }
    public string ReceiveMethod { get; set; }
    public List<SelectListItem> Beneficiaries { get; set; }
}


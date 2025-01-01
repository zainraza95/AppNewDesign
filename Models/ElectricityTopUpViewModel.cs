using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

public class ElectricityTopUpViewModel
{
    [Display(Name = "Beneficiary")]
    public string SelectedBeneficiary { get; set; }
    public List<SelectListItem> Beneficiaries { get; set; }
    
    [Display(Name = "How beneficiary will receive?")]
    public string PaymentMethod { get; set; }
    
    [Display(Name = "Biller Account")]
    public string BillerAccount { get; set; }
    public List<string> BillerAccounts { get; set; }
}


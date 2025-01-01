using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

public class MobileTopupViewModel
{
    public string SelectedBeneficiary { get; set; }
    public List<SelectListItem> Beneficiaries { get; set; }
    
    [Display(Name = "Phone No")]
    [Required(ErrorMessage = "Phone number is required")]
    [RegularExpression(@"^\d{11}$", ErrorMessage = "Please enter a valid 11-digit phone number")]
    public string PhoneNumber { get; set; }
    
    [Required(ErrorMessage = "Amount is required")]
    [Range(1, 10000, ErrorMessage = "Amount must be between 1 and 10000")]
    public decimal Amount { get; set; }
    
    public bool IncludesFees { get; set; }
}


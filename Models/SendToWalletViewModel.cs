using System.ComponentModel.DataAnnotations;

public class SendToWalletViewModel
{
    [Required(ErrorMessage = "Beneficiary ID is required")]
    [Display(Name = "Beneficiary")]
    public string BeneficiaryId { get; set; }

    public string BeneficiaryName { get; set; }

    [Required]
    [Range(0.01, double.MaxValue, ErrorMessage = "Amount must be greater than 0")]
    public decimal Amount { get; set; }

    public decimal ExchangeRate { get; set; } = 1.0m;
    
    public decimal SendingAmount { get; set; }
    public decimal ServiceCharges { get; set; } = 3.0m;
    public decimal HandlingFee { get; set; } = 3.0m;
    public decimal PaymentMethodFee { get; set; } = 0.0m;
    public decimal ReceiverAmount { get; set; }
    public decimal TotalDeduction { get; set; }
    
    public string DiscountCoupon { get; set; }
    
    [Required(ErrorMessage = "You must agree to the terms and conditions")]
    public bool AgreeToTerms { get; set; }
}


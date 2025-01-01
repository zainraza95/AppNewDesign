public class ExchangeRateViewModel
{
    public decimal UsdAmount { get; set; } = 45.00m;
    
    public decimal GmdRate { get; set; } = 70.0000m;
    public decimal GmdAmount => UsdAmount * GmdRate;
    
    public decimal PkrRate { get; set; } = 250.0000m;
    public decimal PkrAmount => UsdAmount * PkrRate;
}


using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

public class TransactionHistoryViewModel
{
    public int Year { get; set; }
    public List<Transaction> Transactions { get; set; }
}

public class Transaction
{
    public string Beneficiary { get; set; }
    public string Amount { get; set; }
    public string ReferenceNumber { get; set; }
    public DateTime TransactionDate { get; set; }
    public string UsdAmount { get; set; }
    public string Year { get; internal set; }
}
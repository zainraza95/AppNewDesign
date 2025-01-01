using Microsoft.AspNetCore.Mvc;

public class TransactionHistoryController : Controller
{
    public IActionResult Index()
    {
        TransactionHistoryViewModel TransactionHistoryObjMain = new TransactionHistoryViewModel();
        TransactionHistoryObjMain.Transactions = new List<Transaction>();
        Transaction TransactionHistoryObjChild = new Transaction();

        TransactionHistoryObjChild.Beneficiary = "CP Bene";
        TransactionHistoryObjChild.Amount = "1100.00";
        TransactionHistoryObjChild.ReferenceNumber = "RA24000014";
        TransactionHistoryObjChild.TransactionDate = new DateTime(2024, 6, 28);
        TransactionHistoryObjChild.UsdAmount = "11.00";

        TransactionHistoryObjMain.Year = 2024;
        TransactionHistoryObjMain.Transactions.Add(TransactionHistoryObjChild);

    //    var viewModel = new TransactionHistory  /*View Model Type*/
    //    {
    //        Year = 2024,
    //        Transactions = new List<Transaction>
    //        {
    //            new Transaction
    //            {
    //                Beneficiary = "CP Bene",
    //                Amount = 1958.00,
    //                ReferenceNumber = "RA24000014",
    //                TransactionDate = new DateTime(2024, 6, 28),
    //                UsdAmount = 11.00
    //            }
    //            // Add more transactions as needed
    //        }
    //    };
       return View(TransactionHistoryObjMain);
    }
}


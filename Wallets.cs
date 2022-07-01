using System.ComponentModel.DataAnnotations;

namespace SQLAPPLICATION.Tables;

public class Wallet
{

    [Key] public int WalletId { set; get; }
    public string CardNumber { set; get; }
    public string Description { set; get; }

    public Wallet(string cardNumber, string description)
    {
        CardNumber = cardNumber;
        Description = description;
    }
}
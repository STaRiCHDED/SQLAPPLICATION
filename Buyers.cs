using System.ComponentModel.DataAnnotations;

namespace SQLAPPLICATION.Tables;

public class Buyer
{
    [Key] public int BuyerId { set; get; }
    public string Name { set; get; }
    public string LastName { set; get; }
    public string Patronimyc { set; get; }
    
    public int WalletId { set; get; }

    public Buyer(string name, string lastName, string patronimyc,int walletId)
    {
        Name = name;
        LastName = lastName;
        Patronimyc = patronimyc;
        WalletId = walletId;
    }
}
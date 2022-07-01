using System.ComponentModel.DataAnnotations;

namespace SQLAPPLICATION.Tables;

public class Sale
{
    [Key] public int SaleId { set; get; }
    public int ProductId { set; get; }
    public int BuyerId { set; get; }
    public DateTime Date { set; get; }

    public Sale(int productId,int buyerId,DateTime date)
    {
        ProductId = productId;
        BuyerId = buyerId;
        Date = date;
    }
}
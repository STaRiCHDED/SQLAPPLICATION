using System.ComponentModel.DataAnnotations;

namespace SQLAPPLICATION.Tables;

public class Product
{
    [Key] public int ProductId { set; get; }
    public string Name { set; get; }
    public int Cost { set; get; }
    public string Description { set; get; }

    public Product(string name, int cost, string description)
    {
        Name = name;
        Cost = cost;
        Description = description;
    }
}
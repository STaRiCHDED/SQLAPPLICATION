using SQLAPPLICATION.Tables;

Console.WriteLine("Hello, World!");

var dataBase = new ApplicationContext();
/*
var buyers = new List<Buyer>()
{
    new Buyer("Иван","Иванов","Иванович",1),
    new Buyer("Федор","Фёдоров","Фёдорович",1),
    new Buyer("Арсений","Арсеньев","Арсеньевич",2),
    new Buyer("Петр","Петров","Петрович",3),
    new Buyer("Ярослав","Фёдоров","Никитич",4),
    new Buyer("Иван","Шварц","Вольфганович",5)
};
var products = new List<Product>()
{
    new Product("Тостер",1000,"БУ"),
    new Product("Чайник",5000,"Новый"),
    new Product("Столешница",10000,"Новый"),
    new Product("Холодильник",50000,"БУ"),
    new Product("Телевизор SUMSUNG",100000,"Новый"),
    new Product("Playstation 5",80000,"БУ"),
};
var sales = new List<Sale>()
{
    new Sale(1,1,new DateTime(2012,8,12)),
    new Sale(2,1,new DateTime(2013,2,15)),
    new Sale(2,5,new DateTime(2013,2,16)),
    new Sale(5,3,new DateTime(2018,1,10)),
    new Sale(6,2,new DateTime(2021,12,30)),
    new Sale(6,6,new DateTime(2019,5,5))
};
var wallets = new List<Wallet>()
{
    new Wallet("0000 0000 0000 0000","Сбербанк"),
    new Wallet("1111 1111 1111 1111","Тинькофф"),
    new Wallet("2222 2222 2222 2222","ВТБ"),
    new Wallet("3333 3333 3333 3333","Сбербанк"),
    new Wallet("4444 4444 4444 4444","МойБанк")
};
dataBase.Buyers.AddRange(buyers);
dataBase.Products.AddRange(products);
dataBase.Sales.AddRange(sales);
dataBase.Wallets.AddRange(wallets);
dataBase.SaveChanges();
*/

Console.WriteLine("\nSelectAll\n");
var sales1 = dataBase.Sales.ToList();
foreach (var sale in sales1)
{
    var product = dataBase.Products.Find(sale.ProductId);
    var buyer = dataBase.Buyers.Find(sale.BuyerId);
    Console.WriteLine($"Product id: {product.Name}, Buyer id: {buyer.Name} {buyer.LastName} {buyer.Patronimyc}, Date: {sale.Date.ToString()}"); 
}
Console.WriteLine("\nSelectOnly < 14.03.2013\n");
var date = new DateTime(2013, 3, 14);
var sales2 = sales1.Where(sale => sale.Date < date).ToList();
foreach (var sale in sales2)
{
    var product = dataBase.Products.Find(sale.ProductId);
    var buyer = dataBase.Buyers.Find(sale.BuyerId);
    Console.WriteLine($"Product id: {product.Name}, Buyer id: {buyer.Name} {buyer.LastName} {buyer.Patronimyc}, Date: {sale.Date.ToString()}"); 
}
Console.WriteLine("\nSelectOnly where wallet is not Сбербанк\n");


var buyers = dataBase.Buyers.ToList();
var buyers1 = buyers.Where(buyer =>
    dataBase.Wallets.Any(wallet => wallet.WalletId == buyer.WalletId && wallet.Description != "Сбербанк"));
foreach (var i in buyers1)
{
    Console.WriteLine($"Buyer id: {i.Name} {i.LastName} {i.Patronimyc}, Card is not Сбербанк"); 
}

Console.WriteLine("\n Вывод всей информации по покупателям \n");
foreach (var i in buyers)
{
    var wal = dataBase.Wallets.Find(i.WalletId);
    Console.WriteLine($"Buyer id: {i.Name} {i.LastName} {i.Patronimyc}, Card {wal.WalletId} {wal.CardNumber}"); 
}

Console.WriteLine("\n Вывод суммы потраченной одним из покупателей \n");
int k = 2;
var sum = dataBase.Products.Where(product => dataBase.Sales.Any(sale => sale.BuyerId == buyers[k].BuyerId && sale.ProductId == product.ProductId)).Sum(product => product.Cost);
Console.WriteLine($"Buyer id {buyers[k].BuyerId}, {buyers[k].Name}, {buyers[k].LastName}, {buyers[k].Patronimyc}: {sum}");
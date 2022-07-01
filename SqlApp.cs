using Microsoft.EntityFrameworkCore;

namespace SQLAPPLICATION.Tables;

public class ApplicationContext : DbContext
{
    public ApplicationContext()
    {
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            @"Server=DESKTOP-9I6MJKT\SQLEXPRESS;Database=DB_Shop;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True");
    }
    
    public DbSet<Buyer> Buyers => Set<Buyer>();
    public DbSet<Product> Products => Set<Product>();
    public DbSet<Sale> Sales => Set<Sale>();
    public DbSet<Wallet> Wallets => Set<Wallet>();
}
using Microsoft.EntityFrameworkCore;

namespace CEInventory.WebUI.Components.Services;

public class ProductContext : DbContext
{
    public ProductContext(DbContextOptions<ProductContext> options)
        : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>().HasData(
            new Product { Id = 1, Name = "Product 1", Price = 10.99m, Stock = 100 },
            new Product { Id = 2, Name = "Product 2", Price = 20.99m, Stock = 200 }
        );
    }
}



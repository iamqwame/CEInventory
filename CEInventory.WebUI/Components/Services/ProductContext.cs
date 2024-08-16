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
        var products = new List<Product>();
        for (int i = 1; i < 100; i++)
        {
               products.Add(new Product { Id = i, Name = "Product "+i, Price = 5.99m*i, Stock = i*3 }); 
        }
        
        modelBuilder.Entity<Product>().HasData(products);
    }
}



using System.ComponentModel.DataAnnotations;

namespace CEInventory.WebUI.Components.Services;

public class Product
{
    public int Id { get; set; }
    
    // [Required(ErrorMessage = "Name is required")]
    public string Name { get; set; }
    // [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than zero")]
    public decimal Price { get; set; }
    // [Range(0, int.MaxValue, ErrorMessage = "Stock must be non-negative")]
    public int Stock { get; set; }
}


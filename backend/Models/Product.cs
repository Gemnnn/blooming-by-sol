using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    public class Product
    {
        // Primary key
        [Key]
        [Display(Name = "Product ID")]
        public int ProductId { get; set; }

        // Name of the product
        [Required(ErrorMessage = "Please, enter the product name")]
        [MaxLength(100, ErrorMessage = "Product name can't be longer than 100 characters")]
        [Display(Name = "Product Name")]
        public string Name { get; set; }

        // Price of the product
        [Required(ErrorMessage = "Please, enter the price")]
        [Range(0, double.MaxValue, ErrorMessage = "Price must be a positive value")]
        [Display(Name = "Price")]
        public decimal Price { get; set; }

        // Description of the product
        [MaxLength(500, ErrorMessage = "Description can't be longer than 500 characters")]
        [Display(Name = "Description")]
        public string Description { get; set; }

        // Stock quantity of the product
        [Required(ErrorMessage = "Please, enter the stock quantity")]
        [Range(0, int.MaxValue, ErrorMessage = "Stock must be a non-negative value")]
        [Display(Name = "Stock")]
        public int Stock { get; set; }

        // SKU of the product
        [Required(ErrorMessage = "Please, enter the SKU")]
        [MaxLength(50, ErrorMessage = "SKU can't be longer than 50 characters")]
        [Display(Name = "SKU")]
        public string SKU { get; set; }

        // Foreign key to Category
        [Required(ErrorMessage = "Please, enter the category ID")]
        [Display(Name = "Category ID")]
        public int CategoryId { get; set; }

        // Image URL of the product
        [Display(Name = "Image URL")]
        public string ImageUrl { get; set; }

        // Discount price of the product
        [Display(Name = "Discount Price")]
        public decimal? DiscountPrice { get; set; }

        // Created date of the product
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [Display(Name = "Created At")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Navigation properties
        [Display(Name = "Category")]
        public Category Category { get; set; }

        [Display(Name = "Reviews")]
        public ICollection<Review> Reviews { get; set; }

        [Display(Name = "Cart Items")]
        public ICollection<CartItem> CartItems { get; set; }

        [Display(Name = "Order Items")]
        public ICollection<OrderItem> OrderItems { get; set; }
    }

}

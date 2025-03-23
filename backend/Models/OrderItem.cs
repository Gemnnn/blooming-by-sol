using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    public class OrderItem
    {
        // Primary key
        [Key]
        [Display(Name = "Order Item ID")]
        public int OrderItemId { get; set; }

        // Foreign key to Order
        [Required(ErrorMessage = "Please, enter the order ID")]
        [Display(Name = "Order ID")]
        public int OrderId { get; set; }

        // Foreign key to Product
        [Required(ErrorMessage = "Please, enter the product ID")]
        [Display(Name = "Product ID")]
        public int ProductId { get; set; }

        // Quantity of the product
        [Required(ErrorMessage = "Please, enter the quantity")]
        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be at least 1")]
        [Display(Name = "Quantity")]
        public int Quantity { get; set; }

        // Price of the product
        [Required(ErrorMessage = "Please, enter the price")]
        [Range(0, double.MaxValue, ErrorMessage = "Price must be a positive value")]
        [Display(Name = "Price")]
        public decimal Price { get; set; }

        // Navigation properties
        [Display(Name = "Order")]
        public Order Order { get; set; }

        [Display(Name = "Product")]
        public Product Product { get; set; }
    }
}

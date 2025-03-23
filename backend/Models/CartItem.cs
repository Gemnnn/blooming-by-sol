using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    public class CartItem
    {
        // Primary key
        [Key]
        [Display(Name = "Cart Item ID")]
        public int CartItemId { get; set; }

        // Foreign key to Cart
        [Required(ErrorMessage = "Please, enter the cart ID")]
        [Display(Name = "Cart ID")]
        public int CartId { get; set; }

        // Foreign key to Product
        [Required(ErrorMessage = "Please, enter the product ID")]
        [Display(Name = "Product ID")]
        public int ProductId { get; set; }

        // Quantity of the product
        [Required(ErrorMessage = "Please, enter the quantity")]
        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be at least 1")]
        [Display(Name = "Quantity")]
        public int Quantity { get; set; }

        // Navigation properties
        [Display(Name = "Cart")]
        public Cart Cart { get; set; }

        [Display(Name = "Product")]
        public Product Product { get; set; }
    }
}

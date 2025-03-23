using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    public class Cart
    {
        // Primary key
        [Key]
        [Display(Name = "Cart ID")]
        public int CartId { get; set; }

        // Foreign key to User
        [Required(ErrorMessage = "Please, enter the user ID")]
        [Display(Name = "User ID")]
        public int UserId { get; set; }

        // Navigation properties
        [Display(Name = "User")]
        public User User { get; set; }

        [Display(Name = "Cart Items")]
        public ICollection<CartItem> CartItems { get; set; }
    }
}

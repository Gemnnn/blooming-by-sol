using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    public class Order
    {
        // Primary key
        [Key]
        [Display(Name = "Order ID")]
        public int OrderId { get; set; }

        // Foreign key to User
        [Required(ErrorMessage = "Please, enter the user ID")]
        [Display(Name = "User ID")]
        public string UserId { get; set; }

        // Order date
        [Required(ErrorMessage = "Please, enter the order date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [Display(Name = "Order Date")]
        public DateTime OrderDate { get; set; }

        // Total amount of the order
        [Required(ErrorMessage = "Please, enter the total amount")]
        [Range(0, double.MaxValue, ErrorMessage = "Total amount must be a positive value")]
        [Display(Name = "Total Amount")]
        public decimal TotalAmount { get; set; }

        // Foreign key to Address for Shipping Address
        [Display(Name = "Shipping Address ID")]
        public int? ShippingAddressId { get; set; }

        // Navigation properties
        [Display(Name = "User")]
        public User User { get; set; }

        [Display(Name = "Shipping Address")]
        public Address ShippingAddress { get; set; }

        [Display(Name = "Order Items")]
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}

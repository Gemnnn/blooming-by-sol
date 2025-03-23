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
        public int UserId { get; set; }

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

        // Shipping address
        [Required(ErrorMessage = "Please, enter the shipping address")]
        [MaxLength(100, ErrorMessage = "Shipping address can't be longer than 100 characters")]
        [Display(Name = "Shipping Address")]
        public string ShippingAddress { get; set; }

        // City
        [Required(ErrorMessage = "Please, enter the city")]
        [MaxLength(50, ErrorMessage = "City can't be longer than 50 characters")]
        [Display(Name = "City")]
        public string City { get; set; }

        // Foreign key to Province
        [Required(ErrorMessage = "Please, Select the province")]
        [Display(Name = "Province ID")]
        public int ProvinceId { get; set; }

        // Zip code
        [Required(ErrorMessage = "Please, enter the zip code")]
        [MaxLength(10, ErrorMessage = "Zip code can't be longer than 10 characters")]
        [Display(Name = "Zip Code")]
        public string ZipCode { get; set; }

        // Foreign key to Country
        [Required(ErrorMessage = "Please, select the country")]
        [Display(Name = "Country ID")]
        public int CountryId { get; set; }

        // Navigation properties
        [Display(Name = "User")]
        public User User { get; set; }

        [Display(Name = "Province")]
        public Province Province { get; set; }

        [Display(Name = "Country")]
        public Country Country { get; set; }

        [Display(Name = "Order Items")]
        public ICollection<OrderItem> OrderItems { get; set; }
    }

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

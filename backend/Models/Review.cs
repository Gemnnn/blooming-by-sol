using System.ComponentModel.DataAnnotations;
namespace backend.Models
{
    public class Review
    {
        // Primary key
        [Key]
        [Display(Name = "Review ID")]
        public int ReviewId { get; set; }

        // Foreign key to Product
        [Required(ErrorMessage = "Please, enter the product ID")]
        [Display(Name = "Product ID")]
        public int ProductId { get; set; }

        // Foreign key to User
        [Required(ErrorMessage = "Please, enter the user ID")]
        [Display(Name = "User ID")]
        public string UserId { get; set; }

        // Comment of the review
        [Required(ErrorMessage = "Please, enter the comment")]
        [MaxLength(500, ErrorMessage = "Comment can't be longer than 500 characters")]
        [Display(Name = "Comment")]
        public string Comment { get; set; }

        // Rating of the review
        [Required(ErrorMessage = "Please, Select the rating")]
        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5")]
        [Display(Name = "Rating")]
        public int Rating { get; set; }

        // Created date of the review
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [Display(Name = "Created At")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Navigation properties
        [Display(Name = "Product")]
        public Product Product { get; set; }

        [Display(Name = "User")]
        public User User { get; set; }
    }
}

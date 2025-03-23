using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        [Required]
        public int Stock { get; set; }

        [Required]
        [MaxLength(50)]
        public string SKU { get; set; }

        [Required]
        public int CategoryId { get; set; }

        public string ImageUrl { get; set; }

        public decimal? DiscountPrice { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public Category Category { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }

    public class Review
    {
        [Key]
        public int ReviewId { get; set; }

        [Required]
        public int ProductId { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        [MaxLength(500)]
        public string Comment { get; set; }

        [Required]
        [Range(1, 5)]
        public int Rating { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public Product Product { get; set; }
        public User User { get; set; }
    }
}

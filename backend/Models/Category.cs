using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    public class Category
    {
        // Primary key
        [Key]
        [Display(Name = "Category ID")]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Please, select the category name")]
        [MaxLength(50, ErrorMessage = "Category name can't be longer than 50 characters")]
        [Display(Name = "Category Name")]
        public string Name { get; set; }

        // Navigation property
        [Display(Name = "Products")]
        public ICollection<Product> Products { get; set; }
    }
}

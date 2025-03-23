using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    public class Country
    {
        // Primary key
        [Key]
        [Display(Name = "Country ID")]
        public int CountryId { get; set; }

        [Required(ErrorMessage = "Please, select the country")]
        [MaxLength(50, ErrorMessage = "Country name can't be longer than 50 characters")]
        [Display(Name = "Country Name")]
        public string Name { get; set; }

        // Navigation property
        [Display(Name = "Provinces")]
        public ICollection<Province> Provinces { get; set; }
    }
}

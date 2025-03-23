using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    public class Province
    {
        // Primary key
        [Key]
        [Display(Name = "Province ID")]
        public int ProvinceId { get; set; }

        // Name of the province
        [Required(ErrorMessage = "Please, select the province")]
        [MaxLength(50, ErrorMessage = "Province name can't be longer than 50 characters")]
        [Display(Name = "Province Name")]
        public string Name { get; set; }

        // Foreign key to Country
        [Required(ErrorMessage = "Please, enter the country ID")]
        [Display(Name = "Country ID")]
        public int CountryId { get; set; }

        // Navigation property
        [Display(Name = "Country")]
        public Country Country { get; set; }
    }
}

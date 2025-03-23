using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    public class Address
    {
        // Primary key
        [Key]
        [Display(Name = "Address ID")]
        public int AddressId { get; set; }

        // Street address
        [Required(ErrorMessage = "Please, enter the street address")]
        [MaxLength(100, ErrorMessage = "Street address can't be longer than 100 characters")]
        [Display(Name = "Street Address")]
        public string StreetAddress { get; set; }

        // City
        [Required(ErrorMessage = "Please, enter the city")]
        [MaxLength(50, ErrorMessage = "City can't be longer than 50 characters")]
        [Display(Name = "City")]
        public string City { get; set; }

        // Foreign key to Province
        [Required(ErrorMessage = "Please, select the province")]
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
        [Display(Name = "Province")]
        public Province Province { get; set; }

        [Display(Name = "Country")]
        public Country Country { get; set; }
    }
}

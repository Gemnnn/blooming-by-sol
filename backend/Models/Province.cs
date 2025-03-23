using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    public class Province
    {
        [Key]
        public int ProvinceId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        public int CountryId { get; set; }

        public Country Country { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    public class Country
    {
        [Key]
        public int CountryId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public ICollection<Province> Provinces { get; set; }
    }
}

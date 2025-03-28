using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    public class User : IdentityUser
    {
        [Required(ErrorMessage = "Please, enter the first name")]
        [MaxLength(50, ErrorMessage = "First name can't be longer than 50 characters")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please, enter the last name")]
        [MaxLength(50, ErrorMessage = "Last name can't be longer than 50 characters")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [Display(Name = "Created At")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [Display(Name = "Mailing Address ID")]
        public int? MailingAddressId { get; set; }

        [Display(Name = "Orders")]
        public ICollection<Order> Orders { get; set; }

        [Display(Name = "Reviews")]
        public ICollection<Review> Reviews { get; set; }

        [Display(Name = "Carts")]
        public ICollection<Cart> Carts { get; set; }

        [Display(Name = "Mailing Address")]
        public Address MailingAddress { get; set; }
    }
}
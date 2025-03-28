﻿using System.ComponentModel.DataAnnotations;

namespace backend.DTOs
{
    public class UpdateUser
    {
        [Required]
        public string Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public int? MailingAddressId { get; set; }
    }
}
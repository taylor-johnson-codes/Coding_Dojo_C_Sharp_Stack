using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bank_Accounts.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "is required")]
        [MinLength(2, ErrorMessage = "must be at least 2 characters")]
        [MaxLength(45, ErrorMessage = "can't be more than 45 characters")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "is required")]
        [MinLength(2, ErrorMessage = "must be at least 2 characters")]
        [MaxLength(45, ErrorMessage = "can't be more than 45 characters")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "is required")]
        [MaxLength(45, ErrorMessage = "can't be more than 45 characters")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "is required")]
        [MaxLength(255, ErrorMessage = "can't be more than 45 characters")]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage="must be at least 8 characters")]
        public string Password { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        [NotMapped]
        [Required(ErrorMessage = "is required")]
        [Compare("Password", ErrorMessage="passwords don't match")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")] 
        public string Confirm { get; set; }

        public List<Transaction> Transactions { get; set; }
    }
}
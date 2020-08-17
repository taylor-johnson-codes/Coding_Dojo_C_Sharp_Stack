using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Login_and_Registration.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "is required")]
        [MinLength(2, ErrorMessage = "must be at least 2 characters")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "is required")]
        [MinLength(2, ErrorMessage = "must be at least 2 characters")]
        [Display(Name = "Last Name")]
        public string LastName {get;set;}

        [Required(ErrorMessage = "is required")]
        [EmailAddress]
        public string Email {get;set;}

        [Required(ErrorMessage = "is required")]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage="must be at least 8 characters")]
        public string Password {get;set;}

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        [NotMapped]
        [Required(ErrorMessage = "is required")]
        [Compare("Password", ErrorMessage="passwords don't match")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")] 
        public string Confirm {get;set;}
    }
}
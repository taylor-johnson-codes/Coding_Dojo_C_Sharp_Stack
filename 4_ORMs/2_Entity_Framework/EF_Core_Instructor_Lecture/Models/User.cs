using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Core_Instructor_Lecture.Models
{
    public class User
    {
        [Key] // the below prop is the primary key, [Key] is not needed if named with pattern: ModelNameId
        public int UserId { get; set; }

        [Required(ErrorMessage = "is required")]
        [MinLength(2, ErrorMessage = "must be at least 2 characters")]
        [Display(Name = "First Name")]  // for the HTML label tag 
        public string FirstName { get; set; }

        [Required(ErrorMessage = "is required")]
        [MinLength(2, ErrorMessage = "must be at least 2 characters")]
        [Display(Name = "Last Name")]  // for the HTML label tag 
        public string LastName {get;set;}

        [Required(ErrorMessage = "is required")]
        [EmailAddress]  // checks if it is a valid email format
        public string Email {get;set;}

        [Required(ErrorMessage = "is required")]
        [DataType(DataType.Password)]  // using this hides the password while the user types it
        [MinLength(8, ErrorMessage="must be at least 8 characters")]
        public string Password {get;set;}

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;


        // adding a [NotMapped] attribute to a Confirm property will tell EF to not attempt to map it

        [NotMapped]
        [Required(ErrorMessage = "is required")]
        [Compare("Password", ErrorMessage="passwords don't match")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]  // for the HTML label tag 
        public string Confirm {get;set;}
    }
}
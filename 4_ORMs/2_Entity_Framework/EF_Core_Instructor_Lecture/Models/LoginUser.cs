using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Core_Instructor_Lecture.Models
{
    [NotMapped]
    public class LoginUser
    {
        [Required(ErrorMessage = "is required")]
        [EmailAddress]  // checks if it is a valid email format
        [Display(Name = "Email")]  // for the HTML label tag 
        public string LoginEmail {get; set;}

        [Required(ErrorMessage = "is required")]
        [MinLength(8, ErrorMessage="must be at least 8 characters")]
        [DataType(DataType.Password)]  // using this hides the password while the user types it
        [Display(Name = "Password")]  // for the HTML label tag 
        public string LoginPassword { get; set; }
    }
}

/*
Not mapped because email and password are already in DB.
*/

/*
Using LoginEmail and LoginPassword so the error messages know where to display.
If login and reg are on the same page and both fields are named Email and Password,
the error message will display on both the login and reg sides.
*/
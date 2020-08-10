using System.ComponentModel.DataAnnotations;

namespace Validating_Form_Submission.Models
{
    public class User
    {
        [Required]
        [MinLength(1)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(30)]
        public string LastName { get; set; }

        // OTHER EXAMPLES:
        // [Required]
        // [EmailAddress]
        // public string Email { get; set; }

        // [Required]
        // [DataType(DataType.Password)]
        // public string Password { get; set; }
    }
}
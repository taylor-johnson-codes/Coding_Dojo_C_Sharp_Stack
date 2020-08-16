using System.ComponentModel.DataAnnotations;

namespace Dojo_Survey_with_Validation.Models
{
    public class Survey
    {
        [Required(ErrorMessage = "A name is required.")]
        [MinLength(2, ErrorMessage = "Name must be more than one character long.")]
        public string Name {get; set;}
        
        [Required]
        public string Location {get; set;}

        [Required]
        public string Language {get; set;}

        [MaxLength(20, ErrorMessage = "Comment must be under 21 characters long.")]
        public string Comment {get; set;}
    }
}
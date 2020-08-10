using System.ComponentModel.DataAnnotations;

namespace Dojo_Survey_with_Validation.Models
{
    public class Survey
    {
        [Required]
        [MinLength(2)]
        public string name {get; set;}
        
        [Required]
        public string location {get; set;}

        [Required]
        public string language {get; set;}

        [MaxLength(20)]
        public string comment {get; set;}
    }
}
using System.ComponentModel.DataAnnotations;

namespace Multiple_Forms_Single_View.Models
{
    public class User
    {
        [Required]
        [MinLength(1)]
        public string UserName { get; set; }

        [Required]
        public int Age { get; set; }
    }
}
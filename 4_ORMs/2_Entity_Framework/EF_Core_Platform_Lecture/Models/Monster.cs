using System.ComponentModel.DataAnnotations;

namespace EF_Core_Platform_Lecture.Models
{
    public class Monster
    {
        [Required(ErrorMessage = "This is required.")]
        [MinLength(1)]
        public string FirstName { get; set; }
    }
}
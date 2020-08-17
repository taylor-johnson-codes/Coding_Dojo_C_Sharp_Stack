using System;
using System.ComponentModel.DataAnnotations;

namespace EF_Core_Platform_Lecture.Models
{
    public class Monster
    {
        [Key]
        public int MonsterId { get; set; }

        [Required(ErrorMessage = "is required")]
        [MinLength(2, ErrorMessage = "must be at least 2 characters")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
using System;
using System.ComponentModel.DataAnnotations;

namespace CRUDelicious.Models
{
    public class Dish
    {
        [Key]
        public int DishId { get; set; }

        [Required(ErrorMessage = "is required")]
        [MaxLength(45, ErrorMessage = "no longer than 45 characters")]
        [Display(Name = "Chef's Name")]
        public string Chef { get; set; }

        [Required(ErrorMessage = "is required")]
        [MaxLength(45, ErrorMessage = "no longer than 45 characters")]
        [Display(Name = "Name of Dish")]
        public string Name { get; set; }

        [Required(ErrorMessage = "is required")]
        [Range(1, 5000, ErrorMessage = "must be greater than 0")]
        [Display(Name = "# of Calories")]
        public int Calories { get; set; }

        [Required(ErrorMessage = "is required")]
        [Range(1, 6, ErrorMessage = "must be from 1 to 5")]
        public int Tastiness { get; set; }

        [Required(ErrorMessage = "is required")]
        [MinLength(1, ErrorMessage = "must be at least 1 character")]
        public string Description { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
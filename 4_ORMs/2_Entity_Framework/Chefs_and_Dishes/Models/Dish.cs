using System;
using System.ComponentModel.DataAnnotations;

namespace Chefs_and_Dishes.Models
{
    public class Dish
    {
        [Key]
        public int DishId {get;set;}

        [Required(ErrorMessage = "is required")]
        [MinLength(2, ErrorMessage = "must be at least 2 characters")]
        [MaxLength(20, ErrorMessage = "no longer than 20 characters")]
        [Display(Name = "Dish Name")]
        public string DishName {get;set;}

        [Required(ErrorMessage = "is required")]
        [Range(1, 5000, ErrorMessage = "must be greater than 0")]
        [Display(Name = "# of Calories")]
        public int Calories {get;set;}

        [Required(ErrorMessage = "is required")]
        [MinLength(3, ErrorMessage = "must be at least 3 characters")]
        [MaxLength(50, ErrorMessage = "no longer than 50 characters")]
        public string Description {get;set;}

        [Required(ErrorMessage = "is required")]
        [Range(1, 6, ErrorMessage = "must be from 1 to 5")]
        public int Tastiness {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        [Required(ErrorMessage = "is required")]
        [Display(Name = "Chef")]
        public int ChefId {get;set;}

        public Chef Creator {get;set;}
    }
}
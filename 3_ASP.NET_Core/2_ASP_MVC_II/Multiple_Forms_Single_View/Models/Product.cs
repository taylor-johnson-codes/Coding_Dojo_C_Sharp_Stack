using System.ComponentModel.DataAnnotations;

namespace Multiple_Forms_Single_View.Models
{
    public class Product
    {
        [Required]
        [MinLength(1)]
        public string ProductName { get; set; }

        [Required]
        public decimal Price { get; set; }
    }
}
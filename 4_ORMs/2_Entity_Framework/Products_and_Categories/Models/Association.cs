using System;
using System.ComponentModel.DataAnnotations;

namespace Products_and_Categories.Models
{
    public class Association
    {
        [Key]
        public int AssociationId { get; set; }
        public int ProductId { get; set; }
        public int CategoryId { get; set; }

        public Product ProductInCategory { get; set; }
        public Category CategoryOfProduct { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
using System.ComponentModel.DataAnnotations;

namespace Dojodachi.Models
{
    public class Pet
    {
        [Required]
        [MinLength(1)]
        public string Name { get; set; }
    }
}
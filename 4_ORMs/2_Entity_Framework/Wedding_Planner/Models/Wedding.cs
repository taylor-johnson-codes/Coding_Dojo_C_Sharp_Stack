using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Wedding_Planner.Models
{
    public class Wedding
    {
        [Key]
        public int WeddingId { get; set; }

        [Required]
        [MinLength(2, ErrorMessage="must be at least 2 characters")]
        [Display(Name="Wedder One")]
        public string WedderOne { get; set; }

        [Required]
        [MinLength(2, ErrorMessage="must be at least 2 characters")]
        [Display(Name="Wedder Two")]
        public string WedderTwo { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Required]
        public string Address { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        // Foreign Key:
        public int UserId { get; set; }
        
        // Navigation Properties:
        public User Creator { get; set; }
        public List<Rsvp> Attendees { get; set; }
    }
}
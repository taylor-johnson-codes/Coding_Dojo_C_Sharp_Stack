using System;
using System.ComponentModel.DataAnnotations;

namespace Wedding_Planner.Models
{
    public class Rsvp
    {
        [Key]
        public int RsvpId { get; set; }

        // Foreign Keys:
        public int UserId { get; set; }
        public int WeddingId { get; set; }

        // Navigation Properties:
        public User Attendee { get; set; }
        public Wedding WeddingToAttend { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
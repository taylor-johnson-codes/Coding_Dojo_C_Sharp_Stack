// Many-to-Many relationship: The User can make many votes; votes on a Post made by many Users

using System;
using System.ComponentModel.DataAnnotations;

namespace EF_Core_Instructor_Lecture.Models
{
    public class Vote
    {
        [Key]
        public int VoteId { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        // Foreign Keys:
        // Many-to-Many between a post and a user
        public int PostId { get; set; }
        public int UserId { get; set; }
        public bool IsUpVote { get; set; }

        // Navigation Properties:
        public User Voter { get; set; }  // will be using something like Vote.Voter in list of votes
        public Post Post { get; set; }  // Vote.Post

        // added this to User and Post model to complete relationship:
        // public List<Vote> Votes { get; set; }

    }
}
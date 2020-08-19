// Many-to-Many relationship: The User can make many votes; votes on a Post made by many Users

using System.ComponentModel.DataAnnotations;

namespace EF_Core_Instructor_Lecture.Models
{
    public class Vote
    {
        [Key]
        public int VoteId { get; set; }

        // Foreign Keys:
        // Many-to-Many between a post and a user
        public int PostId { get; set; }
        public int UserId { get; set; }

        // Navigation Properties:
        public User Voter { get; set; }  // will be using something like Vote.Voter in list of votes
        public Post Post { get; set; }  // Vote.Post

        // added to User and Post model to complete this relationship
    }
}
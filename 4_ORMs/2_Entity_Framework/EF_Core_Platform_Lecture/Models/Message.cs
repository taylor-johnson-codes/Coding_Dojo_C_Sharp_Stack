/*
ONE TO MANY RELATIONSHIP:
User can post many messages; message can only have one user.
*/

using System.ComponentModel.DataAnnotations;

namespace EF_Core_Platform_Lecture.Models
{
    public class Message
    {
        [Key]
        public int MessageId {get;set;}

        [Required]
        public string Content {get;set;}
        
        public int UserId {get;set;}
        /* Inside of the Message model, we included public int UserId to let the database know which user is the 
        creator of the message. When we create a message, this information will be passed along in the form submit 
        just as the rest of the data would.
        */

        // Navigation property for related User object
        public User Creator {get;set;}
    }
}
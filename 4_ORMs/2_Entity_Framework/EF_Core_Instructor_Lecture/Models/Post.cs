// this model represents a user making a post on a forum

using System;
using System.ComponentModel.DataAnnotations;

namespace EF_Core_Instructor_Lecture.Models
{
    public class Post
    {
        [Key]
        public int PostId { get; set; }

        [Required(ErrorMessage = "is required")]
        [MinLength(2, ErrorMessage = "must be at least 2 characters")]
        [MaxLength(45, ErrorMessage = "can't be more than 45 characters")]
        // [Display(Name = "Topic")]
        public string Topic { get; set; }

        [Required(ErrorMessage = "is required")]
        [MinLength(2, ErrorMessage = "must be at least 2 characters")]
        public string Body { get; set; }

        public string ImgURL { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}

/*
After completing the model:
1) Add DbSet to MyContext
2) Migrate
*/
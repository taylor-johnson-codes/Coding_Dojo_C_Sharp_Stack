using System;
using System.ComponentModel.DataAnnotations;

namespace EF_Core_Platform_Lecture.Models
{
    public class Monster
    {
        // [Required(ErrorMessage = "This is required.")]
        // [MinLength(1)]

        [Key]
        public int MonsterId { get; set; }
        public string Name { get; set; }
        public int Height { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}

/*
Important to note: 
Always use a new database name when working with a new project, otherwise your tables from multiple projects 
will exist inside the same database and cause all sorts of confusion. (Especially if, say, you have multiple 
projects that have a "User" table.) 
*/

/*
Model classes such as these, that bear the responsibility of representing an entry in a database table, 
are typically referred to as an "Entity". In this Entity class, we will provide Auto-Implemented Properties 
that will be used by Entity Framework to "map" to Columns in the associated table. 
*/

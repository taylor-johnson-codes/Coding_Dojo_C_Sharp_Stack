// This is what the ORM uses to create the DB tables for us
// No relationships are defined here

using Microsoft.EntityFrameworkCore;

namespace EF_Core_Instructor_Lecture.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) { }

        public DbSet<User> Users { get; set; }  // Users is the table name that's going to be created in the DB

        public DbSet<Post> Posts { get; set; }

        public DbSet<Vote> Votes { get; set; }
    }
}
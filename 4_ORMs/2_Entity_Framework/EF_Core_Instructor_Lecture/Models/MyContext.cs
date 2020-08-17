using Microsoft.EntityFrameworkCore;

namespace EF_Core_Instructor_Lecture.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) { }

        public DbSet<User> Users { get; set; }  // Users is the table name that's going to be created

        public DbSet<Post> Posts { get; set; }

        // NEED TO ADD OTHER CLASSES HERE BEFORE MIGRATING!
        // public DbSet<Widget> Widgets { get; set; }
        // public DbSet<Item> Items { get; set; }
    }
}
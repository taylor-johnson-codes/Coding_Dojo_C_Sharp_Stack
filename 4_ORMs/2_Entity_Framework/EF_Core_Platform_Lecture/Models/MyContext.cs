using Microsoft.EntityFrameworkCore;

namespace EF_Core_Platform_Lecture.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) { }

        public DbSet<Monster> Monsters { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Message> Messages { get; set; }

    }
}

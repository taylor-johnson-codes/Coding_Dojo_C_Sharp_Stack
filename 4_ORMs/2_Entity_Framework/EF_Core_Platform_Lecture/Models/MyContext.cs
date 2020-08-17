using Microsoft.EntityFrameworkCore;

namespace EF_Core_Platform_Lecture.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) { }

        public DbSet<Monster> Users { get; set; }

        // public DbSet<Widget> Widgets { get; set; }

        // public DbSet<Item> Items { get; set; }
    }
}

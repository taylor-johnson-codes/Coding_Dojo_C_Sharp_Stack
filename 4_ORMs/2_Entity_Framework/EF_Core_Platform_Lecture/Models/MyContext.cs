using Microsoft.EntityFrameworkCore;

namespace EF_Core_Platform_Lecture.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) { }

        public DbSet<Monster> Monsters { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Message> Messages { get; set; }

        public DbSet<M2M_Person> M2M_Persons { get; set; }
        public DbSet<M2M_Magazine> M2M_Magazines { get; set; }
        public DbSet<M2M_Subscription> M2M_Subscriptions { get; set; }
    }
}

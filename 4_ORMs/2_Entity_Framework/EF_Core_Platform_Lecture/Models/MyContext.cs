// This allows us to query and save data

using Microsoft.EntityFrameworkCore;

namespace EF_Core_Platform_Lecture.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) { }
        public DbSet<Monster> Monsters { get; set; }
        // public DbSet<User> Users { get; set; } i.e. if we are working with more than one model class
    }
}

/*
The context class is what forms the relationship between our models and the database. Think of it as an object 
that sits between our app and the database and translates our queries for us. Context classes, by convention, 
always have names that end in "Context". Make sure to give your Context an informative name to help associate it 
with the project.
*/
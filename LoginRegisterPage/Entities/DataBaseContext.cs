using Microsoft.EntityFrameworkCore;

namespace MvcBlog.Entities
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; } 
         public DbSet<Blog> Blogs { get; set; }
         public DbSet<Comment> Comments { get; set; }
    }
}

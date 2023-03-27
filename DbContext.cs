using ASPNet_Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace ASPNet_Blog
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public DbSet<PostModel> Posts { get; set; }
    }
}

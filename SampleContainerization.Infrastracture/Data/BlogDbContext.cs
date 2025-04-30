using Microsoft.EntityFrameworkCore;
using SampleContainerization.Domain.Entity;

namespace SampleContainerization.Infrastructure.Data
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> dbContextOptions) : base(dbContextOptions)
        {
        }

        public DbSet<Blog> Blogs { get; set; }
    }
}

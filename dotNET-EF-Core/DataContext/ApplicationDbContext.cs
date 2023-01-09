using Microsoft.EntityFrameworkCore;

namespace dotNET_EF_Core.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        // Your Entities
        public DbSet<CategoryEntity> categories { get; set; }
    }
}

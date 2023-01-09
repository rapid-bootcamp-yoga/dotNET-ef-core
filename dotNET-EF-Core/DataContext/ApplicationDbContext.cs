using Microsoft.EntityFrameworkCore;

namespace dotNET_EF_Core.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        //public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        //{

        //}

        // Your Entities
        public DbSet<CategoryEntity> categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost:3306;database=ef_db;uid=root;pwd=1234;");
        }
    }
}

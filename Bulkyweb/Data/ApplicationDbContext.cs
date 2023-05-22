using Bulkyweb.Models;
using Microsoft.EntityFrameworkCore;
//using System.Data.Entity;

namespace Bulkyweb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Category> Categories  { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Umar",
                    DisplayOrder = 1,
                },  
                new Category
                {
                    Id = 2,
                    Name = "Khan",
                    DisplayOrder = 2,
                },
                new Category
                {
                    Id = 3,
                    Name = "Muhammad",
                    DisplayOrder = 3,
                }

                );
        }
    }
}

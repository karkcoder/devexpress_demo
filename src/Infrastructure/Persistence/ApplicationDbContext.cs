using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<Product> Products => Set<Product>();


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .ToTable("Products");

            modelBuilder.Entity<Product>()
                .HasData(
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Apple",
                        Description = "Fruit"
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Orange",
                        Description = "Fruit"
                    }
                );
        }
    }
}

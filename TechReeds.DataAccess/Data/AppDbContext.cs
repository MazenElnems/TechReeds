using Microsoft.EntityFrameworkCore;
using TechReeds.DataAccess.Entities;

namespace TechReeds.DataAccess.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) 
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Categories");

                entity.HasKey(c => c.Id);

                entity.Property(c => c.Name).HasColumnType("VARCHAR(max)");

                entity.HasData(DataSeed.LoadCategories());
            });
        }
    }
}

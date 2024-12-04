using ApiSolution.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace ApiSolution.Persistance.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() {}

        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Detail> Details { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            //modelBuilder.Entity<Product>(entity =>
            //{
            //    entity.Property(p => p.Price)
            //    .HasPrecision(18, 2);

            //    entity.Property(p=>p.Discount)
            //    .HasPrecision(18, 2);
            //});
        }
    }
}

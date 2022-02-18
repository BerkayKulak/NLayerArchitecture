using System.Reflection;
using Microsoft.EntityFrameworkCore;
using NLayerArchitecture.Core;
using NLayerArchitecture.Core.Model;

namespace NLayerArchitecture.Repository
{
    public class AppDbContext : DbContext
    {
        // DbContextOptions dememizin sebebi yolu startup tarafında vereceğim
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductFeature> ProductFeatures { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<ProductFeature>().HasData(new ProductFeature()
            {
                Id = 1,
                Color = "Kırmızı",
                Height = 100,
                Width = 200,
                ProductId = 1
            },
                new ProductFeature()
                {
                    Id = 2,
                    Color = "Mavi",
                    Height = 300,
                    Width = 200,
                    ProductId = 2
                }

            );

            base.OnModelCreating(modelBuilder);
        }
    }
}

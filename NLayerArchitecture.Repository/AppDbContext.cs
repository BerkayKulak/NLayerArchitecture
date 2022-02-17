using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NLayerArchitecture.Core;

namespace NLayerArchitecture.Repository
{
    public class AppDbContext:DbContext
    {
        // DbContextOptions dememizin sebebi yolu startup tarafında vereceğim
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductFeature> ProductFeatures { get; set; }
    }
}

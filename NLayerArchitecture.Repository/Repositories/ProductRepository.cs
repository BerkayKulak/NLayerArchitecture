using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NLayerArchitecture.Core.Model;
using NLayerArchitecture.Core.Repositories;

namespace NLayerArchitecture.Repository.Repositories
{
    public class ProductRepository:GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<List<Product>> GetProductsWithCategory()
        {
            //Eager Loading yaptık
            return await _context.Products.Include(x => x.Category).ToListAsync();
        }
    }
}

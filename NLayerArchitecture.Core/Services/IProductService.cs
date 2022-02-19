using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLayerArchitecture.Core.DTOs;
using NLayerArchitecture.Core.Model;

namespace NLayerArchitecture.Core.Services
{
    public interface IProductService:IService<Product>
    {
        //// FOR API
        //Task<CustomResponseDto<List<ProductWithCategoryDto>>> GetProductsWithCategory();

        // FOR WEB
        Task<List<ProductWithCategoryDto>> GetProductsWithCategory();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLayerArchitecture.Core.DTOs;
using NLayerArchitecture.Core.Model;

namespace NLayerArchitecture.Core.Services
{
    public interface ICategoryService:IService<Category>
    {
        Task<CustomResponseDto<CategoryWithProductsDto>> GetSingleCategoryByIdWithProductsAsync(int categoryId);
    }
}

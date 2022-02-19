using Microsoft.AspNetCore.Mvc;
using NLayerArchitecture.Core.Services;

namespace NLayerArchitecture.Web.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _services;

        public ProductsController(IProductService services)
        {
            _services = services;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _services.GetProductsWithCategory());
        }
    }
}

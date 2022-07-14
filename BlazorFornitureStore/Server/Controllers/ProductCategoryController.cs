using BlazorFornitureStore.Repositories.Repository;
using BlazorFornitureStore.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorFornitureStore.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductCategoryController : ControllerBase
    {
        private readonly IProductCategoryRepository _productCategoryRepository;

        public ProductCategoryController(IProductCategoryRepository productCategoryRepository)
        {
            _productCategoryRepository = productCategoryRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<ProductCategories>> Get()
        {
            var lstProdCategories = await _productCategoryRepository.GetAll();

            return lstProdCategories;
        }
    }
}

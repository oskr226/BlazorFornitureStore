using BlazorFornitureStore.Shared.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorFornitureStore.Client.Services
{
    public class ProductCategoryService : IProductCategoryService
    {
        private readonly HttpClient _httpClient;

        public ProductCategoryService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<ProductCategories>> GetProductCategories()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<ProductCategories>>("api/productcategory");
        }
    }
}

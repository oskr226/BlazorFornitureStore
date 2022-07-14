using BlazorFornitureStore.Shared.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorFornitureStore.Client.Services
{
    public interface IProductCategoryService
    {
        Task<IEnumerable<ProductCategories>> GetProductCategories();
    }
}

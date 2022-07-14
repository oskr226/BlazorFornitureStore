using BlazorFornitureStore.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorFornitureStore.Repositories.Repository
{
    public interface IProductCategoryRepository
    {
        Task<IEnumerable<ProductCategories>> GetAll();
    }
}

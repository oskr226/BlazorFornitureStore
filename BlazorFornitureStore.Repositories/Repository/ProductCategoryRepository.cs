using BlazorFornitureStore.Shared.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorFornitureStore.Repositories.Repository
{
    public class ProductCategoryRepository : IProductCategoryRepository
    {
        private readonly IDbConnection _dbConnection;

        public ProductCategoryRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public Task<IEnumerable<ProductCategories>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}

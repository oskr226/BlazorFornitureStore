using BlazorFornitureStore.Shared.Models;
using Dapper;
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

        public async Task<IEnumerable<ProductCategories>> GetAll()
        {
            var sql = "SELECT Id As Id, Name As Name FROM ProductCategories";

            return await _dbConnection.QueryAsync<ProductCategories>(sql, new {});
        }
    }
}

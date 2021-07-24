using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MarketProj.DAL.Queries.ProductAgregate
{
    public class ProductQuery : IProductQuery
    {
        private readonly string _connectionString = string.Empty;

        public ProductQuery(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<IEnumerable<ProductOutDTOs>> GetAllProductsAsync()
        {
            using (var sqlconnection = new SqlConnection(_connectionString))
            {
                await sqlconnection.OpenAsync();
                var products = await sqlconnection.QueryAsync<ProductOutDTOs>(
                    @"select * from ProductListItems"
                    );
                return products;
            }
        }

        public async Task<IEnumerable<ProductOutDTOs>> GetAllPaged(int pageSize,int pageNumber)
        {
            using (var sqlconnection = new SqlConnection(_connectionString))
            {
                await sqlconnection.OpenAsync();
                var dynamicParameters = new DynamicParameters();
                var skipCount = pageSize * (pageNumber - 1);
                dynamicParameters.Add("skipCount", skipCount);
                dynamicParameters.Add("pageSize", pageSize);

                var products = await sqlconnection.QueryAsync<ProductOutDTOs>(
                    @"select * from ProductListItems
                      ORDER BY CURRENT_TIMESTAMP
                      OFFSET     @skipCount ROWS      
                      FETCH NEXT @pageSize ROWS ONLY", dynamicParameters
                    );
                return products;
            }
        }
    }
}

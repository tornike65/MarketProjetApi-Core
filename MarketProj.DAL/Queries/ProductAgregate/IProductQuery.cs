using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MarketProj.DAL.Queries.ProductAgregate
{
    public interface IProductQuery
    {
        Task<IEnumerable<ProductOutDTOs>> GetAllProductsAsync();
        Task<IEnumerable<ProductOutDTOs>> GetAllPaged(int pageSize, int pageNumber);
    }
}

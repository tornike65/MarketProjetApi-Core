using MarketProj.DAL.Repositories.Abstract.Base;
using MarketProj.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MarketProj.DAL.Repositories.Abstract
{
    public interface IProductListItemRepository : IBaseRepository<ProductListItem>
    {
        Task<bool> AddProductListItemAsync(ProductListItem productListItem);
    }
}

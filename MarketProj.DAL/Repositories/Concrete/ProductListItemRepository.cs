using MarketProj.DAL.Database;
using MarketProj.DAL.Repositories.Abstract;
using MarketProj.DAL.Repositories.Abstract.Base;
using MarketProj.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MarketProj.DAL.Repositories.Concrete
{
    public class ProductListItemRepository : BaseRepository<ProductListItem>, IProductListItemRepository
    {
        private readonly MarketDB _marketDB;

        public ProductListItemRepository(MarketDB marketDB) : base(marketDB)
        {
            _marketDB = marketDB;
        }

        public async Task<bool> AddProductListItemAsync(ProductListItem productListItem)
        {
            if (productListItem == null)
                return false;
            await AddAsync(productListItem);
            return true;
        }
    }
}

using MarketProj.DAL.Repositories.Abstract;
using MarketProj.Models.Models;
using MarketProj.Services.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MarketProj.Services.Services.Concrete
{
    public class ProductItemListService : IProductItemListService
    {
        private readonly IProductListItemRepository _productListItemRepository;

        public ProductItemListService(IProductListItemRepository productListItemRepository)
        {
            _productListItemRepository = productListItemRepository;
        }

        public async Task<bool> AddProductItemListAsync(ProductListItem productListItem)
        {
            return await _productListItemRepository.AddProductListItemAsync(productListItem);
        }
    }
}

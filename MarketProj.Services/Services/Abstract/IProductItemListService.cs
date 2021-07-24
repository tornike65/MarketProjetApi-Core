using MarketProj.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MarketProj.Services.Services.Abstract
{
    public interface IProductItemListService
    {
        Task<bool> AddProductItemListAsync(ProductListItem productListItem);
    }
}

using MarketProj.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MarketProj.Services.Services.Abstract
{
    public interface IProductService
    {
        Task<bool> AddProductAsync(Product product);
        Task<bool> RemoveProductAsync(Guid id);
        Task<bool> UpdateProductAsync(Product product,Guid id);
        Task<IEnumerable<Product>> GetProductsAsync();
        Task<Product> GetProductByIdAsync(Guid id);
        Task<IEnumerable<Product>> GetShoesAsync();
        Task<IEnumerable<Product>> GetLowerAsync();
        Task<IEnumerable<Product>> GetUpperAsync();
        Task<IEnumerable<Product>> GetOtherAsync();
        Task<bool> AddUserProductAsync(UserProducts userProducts);
        Task<IEnumerable<Product>> GetUserProductsAsync(Guid userId);
        Task<bool> RemoveUserProductByIdAsync(Guid userId, Guid productId);
    }
}

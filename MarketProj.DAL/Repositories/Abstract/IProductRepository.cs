using MarketProj.DAL.Repositories.Abstract.Base;
using MarketProj.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketProj.DAL.Repositories.Abstract
{
    public interface IProductRepository: IBaseRepository<Product>
    {
        Task<IEnumerable<Product>> GetAllProductsAsync();
        Task<Product> GetProductByIdAsync(Guid Id);
        Task<IEnumerable<Product>> GetProductsWhereAsync(Func<Product,bool> func);
        Task<bool> AddProductAsync(Product product);
        Task<bool> UpdateProductAsync(Product product);
        Task<bool> DeleteProductAsync(Guid Id);
        Task<bool> AddUserProductAsync(Guid userId, Guid productId);
        Task<IEnumerable<Product>> GetUserProductsAsync(Guid userId);
        Task<bool> RemoveUserProductByIdAsync(Guid id);
        public Task<IQueryable<UserProducts>> GetAllUserProductsAsync();
    }
}

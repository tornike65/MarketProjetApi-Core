using MarketProj.DAL.Database;
using MarketProj.DAL.Repositories.Abstract;
using MarketProj.DAL.Repositories.Abstract.Base;
using MarketProj.Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MarketProj.DAL.Repositories.Concrete
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        private readonly MarketDB _marketDB;
        public ProductRepository(MarketDB marketDB) : base(marketDB)
        {
            _marketDB = marketDB;
        }

        public async Task<bool> AddProductAsync(Product product)
        {
            if (product == null)
                return false;

            await AddAsync(product);
            return true;
        }

        public async Task<bool> AddUserProductAsync(Guid userId, Guid productId)
        {
            _marketDB.UserProducts.Add(new UserProducts(userId, productId));

            var numb = await SaveAsync();

            return numb > 0;
        }

        public async Task<bool> DeleteProductAsync(Guid Id)
        {
            var product = await GetByIdAsync(Id);
            if (product == null)
                return false;

            await DeleteAsync(Id);
            return true;
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            return await (await Query()).Include("Assets").ToListAsync();
        }

        public async Task<Product> GetProductByIdAsync(Guid Id)
        {
            return await GetByIdAsync(Id);
        }

        public async Task<IEnumerable<Product>> GetProductsWhereAsync(Func<Product, bool> func)
        {
            return await Task.Run(async () => (await Query()).Include("Assets").Where(func));
        }

        public async Task<IEnumerable<Product>> GetUserProductsAsync(Guid userId)
        {
            var cartProducts = new List<Product>();

            var userProducts = await _marketDB.UserProducts.Where(x => x.UserId == userId).ToListAsync();

            await Task.Run(() =>
             {
                 var products = _marketDB.Products.Select(x => x);
                 userProducts.ForEach(x =>
                 {
                     if (products.FirstOrDefault(p => p.Id == x.ProductId) != null)
                     {
                         cartProducts.Add(products.FirstOrDefault(p => p.Id == x.ProductId));
                     }
                 });
             });

            return cartProducts;
        }

        public async Task<bool> RemoveUserProductByIdAsync(Guid id)
        {
            _marketDB.UserProducts.Remove(await _marketDB.UserProducts.FindAsync(id));
            return await SaveAsync() > 0;
        }

        public async Task<IQueryable<UserProducts>> GetAllUserProductsAsync()
        {
            return await Task.Run(()=> _marketDB.UserProducts);
        }

        public async Task<bool> UpdateProductAsync(Product product)
        {
            if (product?.Id == default)
                return false;

            await UpdateAsync(product);
            return true;
        }
    }
}

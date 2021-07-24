using MarketProj.DAL.Repositories.Abstract;
using MarketProj.Infrastructure.Enums;
using MarketProj.Models.Models;
using MarketProj.Services.Services.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketProj.Services.Services.Concrete
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<bool> AddProductAsync(Product product)
        {
            product.Date = DateTime.Now;
            return await _productRepository.AddProductAsync(product);
        }


        public async Task<bool> AddUserProductAsync(UserProducts userProducts)
        {
            return await _productRepository.AddUserProductAsync(userProducts.UserId, userProducts.ProductId);
        }

        public async Task<IEnumerable<Product>> GetLowerAsync()
        {
            return await _productRepository.GetProductsWhereAsync(o => o.Clothes == Clothes.Lower);
        }

        public async Task<IEnumerable<Product>> GetOtherAsync()
        {
            return await _productRepository.GetProductsWhereAsync(o => o.Clothes == Clothes.Other);
        }

        public async Task<Product> GetProductByIdAsync(Guid id)
        {
            return await _productRepository.GetProductByIdAsync(id);
        }

        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            return await _productRepository.GetAllProductsAsync();
        }

        public async Task<IEnumerable<Product>> GetShoesAsync()
        {
            return await _productRepository.GetProductsWhereAsync(o => o.Clothes == Clothes.Shoes);
        }

        public async Task<IEnumerable<Product>> GetUpperAsync()
        {
            return await _productRepository.GetProductsWhereAsync(o => o.Clothes == Clothes.Upper);
        }

        public async Task<IEnumerable<Product>> GetUserProductsAsync(Guid userId)
        {
            return await _productRepository.GetUserProductsAsync(userId);
        }

        public async Task<bool> RemoveProductAsync(Guid id)
        {
            return await _productRepository.DeleteProductAsync(id);
        }

        public async Task<bool> RemoveUserProductByIdAsync(Guid userId, Guid productId)
        {
            var userProduct = await (await _productRepository.GetAllUserProductsAsync()).FirstOrDefaultAsync(x => x.ProductId == productId && x.UserId == userId);

            return await _productRepository.RemoveUserProductByIdAsync(userProduct.Id);
        }

        public async Task<bool> UpdateProductAsync(Product product, Guid id)
        {
            product.Id = id;
            return await _productRepository.UpdateProductAsync(product);
        }
    }
}

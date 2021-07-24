using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MarketProj.Models.Models;
using MarketProj.Services.Services.Abstract;
using MarketProj.Models.DTOs.InputDTOs;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using MarketProj.Models.Constants;
using System.Linq;
using MarketProj.DAL.Queries.ProductAgregate;
using MediatR;
using MarketProj.DomainEvents;
using MarketProj.DAL.Queries.Common;

namespace MarketProj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IProductQuery _productQuery;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public ProductsController(IProductService productService,
            IMapper mapper,
            IProductQuery productQuery,
            IMediator mediator)
        {
            _productService = productService;
            _mapper = mapper;
            _productQuery = productQuery;
            _mediator = mediator;
        }

        [HttpGet("temporary")]
        public async Task<IActionResult> Temporary()
        {
            var products = await _productService.GetProductsAsync();

            foreach (var newProduct in products)
            {
                await _mediator.Publish(new ProductAddedDomainEvent(
                newProduct.Name,
                newProduct.Color,
                newProduct.Size,
                newProduct.Id,
                newProduct.Price,
                newProduct.Assets.FirstOrDefault()?.Url
                ));
            }

            return Ok();
        }

        [HttpGet("get-all-products-lists-item")]
        public async Task<IActionResult> GetAllProductListItems()
        {
            return Ok(await _productQuery.GetAllProductsAsync());
        }

        [HttpPost("get-page-products-lists-item")]
        public async Task<IActionResult> GetPageProductListItems(PagedInputDto pagedInputDto)
        {
            return  Ok(await _productQuery.GetAllPaged(pagedInputDto.PageSize, pagedInputDto.PageNumber));
        }

        [Authorize(Roles = Role.Admin)]
        [HttpPost("/add-product")]
        public async Task<IActionResult> AddProduct(ProductInputDTO productInputDTO)
        {
            if (productInputDTO == null)
                return BadRequest();

            var newProduct = _mapper.Map<Product>(productInputDTO);

            var isAdd = await _productService.AddProductAsync(newProduct);
            if (isAdd)
                await _mediator.Publish(new ProductAddedDomainEvent(
                    newProduct.Name,
                    newProduct.Color,
                    newProduct.Size,
                    newProduct.Id,
                    newProduct.Price,
                    newProduct.Assets.FirstOrDefault()?.Url
                    ));

            return Ok(isAdd);
        }

        [Authorize(Roles = Role.Admin)]
        [HttpPut("/edit-product")]
        public async Task<IActionResult> EditProduct(ProductInputDTO productInputDTO, Guid id)
        {
            if (productInputDTO == null)
                return BadRequest();

            var newProduct = _mapper.Map<Product>(productInputDTO);
            var editingProduct = newProduct;
            editingProduct.Id = id;

            var isEdited = await _productService.UpdateProductAsync(editingProduct, id);

            if (isEdited)
            {
                var product = await _productService.GetProductByIdAsync(id);
                var productOutDTO = _mapper.Map<ProductOutDTOs>(product);
                return Ok(productOutDTO);
            }

            return BadRequest();
        }


        [HttpGet("/get-products")]
        public async Task<ActionResult<IEnumerable<ProductOutDTOs>>> GetProducts()
        {
            //var products = await _productService.GetProductsAsync();
            //var productsOutDtos = _mapper.Map<List<ProductOutDTOs>>(products.ToList());

            var productsOutDtos = await _productQuery.GetAllProductsAsync();

            return Ok(productsOutDtos);
        }

        [HttpGet("/get-product/{id}")]
        public async Task<ActionResult<ProductOutDTOs>> GetProductById(Guid id)
        {
            var product = await _productService.GetProductByIdAsync(id);
            var productsOutDto = _mapper.Map<ProductOutDTOs>(product);

            return Ok(productsOutDto);
        }

        [HttpGet("/get-products-shoes")]
        public async Task<ActionResult<IEnumerable<ProductOutDTOs>>> GetProductShoes()
        {
            var products = await _productService.GetShoesAsync();
            var productsOutDtos = _mapper.Map<List<ProductOutDTOs>>(products.ToList());
            return Ok(productsOutDtos);
        }

        [HttpGet("/get-products-upper")]
        public async Task<ActionResult<IEnumerable<ProductOutDTOs>>> GetProductUpper()
        {
            var products = await _productService.GetUpperAsync();
            var productsOutDtos = _mapper.Map<List<ProductOutDTOs>>(products.ToList());
            return Ok(productsOutDtos);
        }

        [HttpGet("/get-products-lower")]
        public async Task<ActionResult<IEnumerable<ProductOutDTOs>>> GetProductLower()
        {
            var products = await _productService.GetLowerAsync();
            var productsOutDtos = _mapper.Map<List<ProductOutDTOs>>(products.ToList());
            return Ok(productsOutDtos);
        }

        [HttpGet("/get-products-accessories")]
        public async Task<ActionResult<IEnumerable<ProductOutDTOs>>> GetProductOther()
        {
            var products = await _productService.GetOtherAsync();
            var productsOutDtos = _mapper.Map<List<ProductOutDTOs>>(products.ToList());
            return Ok(productsOutDtos);
        }

        [Authorize(Roles = Role.Admin)]
        [HttpDelete("/delete-product/{id}")]
        public async Task<IActionResult> DeleteProduct(Guid id)
        {
            var isDeleted = await _productService.RemoveProductAsync(id);
            if (isDeleted)
                return Ok();

            return BadRequest();
        }

        [Authorize(Roles = Role.User)]
        [HttpGet("/get-carts/{userId}")]
        public async Task<ActionResult<IEnumerable<ProductOutDTOs>>> GetCartProducts(Guid userId)
        {
            var cartProducts = await _productService.GetUserProductsAsync(userId);
            var productOutDtos = _mapper.Map<List<ProductOutDTOs>>(cartProducts.ToList());

            return Ok(productOutDtos);
        }

        [Authorize(Roles = Role.User)]
        [HttpPost("add-carts")]
        public async Task<IActionResult> AddCartProduct(Guid userId, Guid productId)
        {
            var result = await _productService.AddUserProductAsync(new UserProducts(userId, productId));
            return Ok(result);
        }

        [Authorize(Roles = Role.User)]
        [HttpDelete("delete-carts")]
        public async Task<IActionResult> DeleteCart(Guid userId, Guid productId)
        {

            var isRemove = await _productService.RemoveUserProductByIdAsync(userId, productId);

            if (isRemove)
                return Ok();

            return BadRequest();
        }
    }
}

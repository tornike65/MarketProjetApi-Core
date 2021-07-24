using MarketProj.DomainEvents;
using MarketProj.Models.Models;
using MarketProj.Services.Services.Abstract;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MarketProj.DomainEventsHandler
{
    public class ProductAddedDomainEventHandler : INotificationHandler<ProductAddedDomainEvent>
    {
        private readonly IProductItemListService _productItemListService;


        public ProductAddedDomainEventHandler(IProductItemListService productItemListService)
        {
            _productItemListService = productItemListService;
        }

        public async Task Handle(ProductAddedDomainEvent notification, CancellationToken cancellationToken)
        {
            await _productItemListService.AddProductItemListAsync(new ProductListItem(notification.ProductName,notification.ProductPrice,notification.ProductColor,notification.ProductImgUrl,notification.ProductId));  
        }
    }
}

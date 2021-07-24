using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarketProj.DomainEvents
{
    public class ProductAddedDomainEvent : INotification
    {
        public ProductAddedDomainEvent(string productName, string productColor, string productSize, Guid productId, double productPrice,string productImgUrl)
        {
            ProductName = productName;
            ProductColor = productColor;
            ProductSize = productSize;
            ProductId = productId;
            ProductPrice = productPrice;
            ProductImgUrl = productImgUrl;
        }

        public string ProductName { get; set; }
        public string ProductColor { get; set; }
        public string ProductSize { get; set; }
        public string ProductImgUrl { get; set; }
        public Guid ProductId { get; set; }
        public double ProductPrice { get; set; }
        
    }
}

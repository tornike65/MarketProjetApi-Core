using MarketProj.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarketProj.Models.Models
{
    public class ProductListItem : Entity
    {
        public ProductListItem(string name, double price, string color, string mainImgUrl, Guid productId)
        {
            Name = name;
            Price = price;
            Color = color;
            MainImgUrl = mainImgUrl;
            ProductId = productId;
        }

        public string Name { get; set; }
        public double Price { get; set; }
        public string Color { get; set; }
        public string MainImgUrl { get; set; }
        public Guid ProductId { get; set; }

    }
}

using MarketProj.Infrastructure.Enums;
using MarketProj.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarketProj.Models.Models
{
    public class Assets : Entity
    {
        public Assets(string url, AssetsType assetsType, Guid productId)
        {
            Url = url;
            AssetsType = assetsType;
            ProductId = productId;
        }

        public string Url { get; set; }
        public AssetsType AssetsType { get; set; }
        public Guid ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}

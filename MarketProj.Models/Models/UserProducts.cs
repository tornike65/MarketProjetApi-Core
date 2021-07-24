using MarketProj.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarketProj.Models.Models
{
    public class UserProducts : Entity
    {
        public UserProducts(Guid userId, Guid productId)
        {
            UserId = userId;
            ProductId = productId;
        }

        public Guid UserId { get; set; }
        public Guid ProductId { get; set; }

    }
}

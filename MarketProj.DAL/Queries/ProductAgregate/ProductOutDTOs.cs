using MarketProj.Infrastructure.Enums;
using MarketProj.Models.DTOs.OutDTOs;
using MarketProj.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarketProj.DAL.Queries.ProductAgregate
{
    public class ProductOutDTOs
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Color { get; set; }
        public string MainImgUrl { get; set; }
        public Guid ProductId { get; set; }

    }
}

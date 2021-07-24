using MarketProj.Infrastructure.Enums;
using MarketProj.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarketProj.DAL.Queries.ProductAgregate
{
    public class AssetsOutDTOs
    {
        public Guid Id { get; set; }
        public string Url { get; set; }
        public AssetsType AssetsType { get; set; }
        public Guid ProductId { get; set; }
    }
}

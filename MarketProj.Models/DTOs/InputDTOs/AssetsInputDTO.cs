using MarketProj.Infrastructure.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarketProj.Models.DTOs.InputDTOs
{
    public class AssetsInputDTO
    {
        public string Url { get; set; }
        public AssetsType AssetsType { get; set; }
        public Guid ProductId { get; set; }
    }
}

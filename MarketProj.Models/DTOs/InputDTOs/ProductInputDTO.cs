using MarketProj.Infrastructure.Enums;
using MarketProj.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarketProj.Models.DTOs.InputDTOs
{
    public class ProductInputDTO
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }
        public string Color { get; set; }
        public double Size { get; set; }
        public double DiscountPrice { get; set; }
        public double DiscountPercent { get; set; }
        public virtual ICollection<AssetsInputDTO> Assets { get; set; }
        public Gender Gender { get; set; }
        public Clothes Clothes { get; set; }
        public DateTime Date { get; set; }
    }
}

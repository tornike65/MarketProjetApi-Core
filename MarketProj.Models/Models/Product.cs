using MarketProj.Infrastructure.Enums;
using MarketProj.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarketProj.Models.Models
{
    public class Product : Entity
    {
        public Product(string name,
            string model,
            string color,
            string size,
            double discountPrice,
            double discountPercent,
            Gender gender,
            Clothes clothes,
            DateTime date)
        {
            Name = name;
            Model = model;
            Color = color;
            Size = size;
            DiscountPrice = discountPrice;
            DiscountPercent = discountPercent;
            Gender = gender;
            Clothes = clothes;
            Date = date;
        }

        public string Name { get; set; }
        public string Model { get; set; }
        public double Price { get; private set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public double DiscountPrice { get; set; }
        public double DiscountPercent { get; set; }
        public virtual ICollection<Assets> Assets { get; set; }
        public Gender Gender { get; set; }
        public Clothes Clothes { get; set; }
        public DateTime Date { get; set; }


        public void SetPrice(double price)
        {
            if (price < 1)
            {
                throw new Exception("price must be more than zero");
            }

            Price = price;
        }
    }
}

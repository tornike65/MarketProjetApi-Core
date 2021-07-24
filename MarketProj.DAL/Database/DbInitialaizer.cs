using MarketProj.Infrastructure.Enums;
using MarketProj.Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarketProj.DAL.Database
{
    class DbInitialaizer
    {
        public static void SeedData(ModelBuilder modelBuilder)
        {
            //create clothes seed-data(Product)
            var upper = new Product("Buisnes Shirt", "Nike", "White", "32", 0, 0, Gender.Male, Clothes.Upper, DateTime.Now) { Id = Guid.NewGuid() };
            upper.SetPrice(20);

            var lower = new Product("Buisnes Short", "Levis", "Black", "32", 0, 0, Gender.Male, Clothes.Lower, DateTime.Now) { Id = Guid.NewGuid() };
            lower.SetPrice(25);

            var shoes = new Product("Sport Nice", "Adidas", "Black", "32", 0, 0, Gender.Female, Clothes.Shoes, DateTime.Now) { Id = Guid.NewGuid() };
            shoes.SetPrice(25);

            var other = new Product("Hat", "Hugo", "Blue", "32", 0, 0, Gender.Female, Clothes.Other, DateTime.Now) { Id = Guid.NewGuid() };
            other.SetPrice(12.5);

            var other2 = new Product("Earrings Golden", "Diamond", "Blue", "32", 0, 0, Gender.Female, Clothes.Other, DateTime.Now) { Id = Guid.NewGuid() };
            other2.SetPrice(200.5);

            modelBuilder.Entity<Product>().HasData(new List<Product>
            {
                upper,
                lower,
                shoes,
                other,
                other2,
            });

            
            //create Assets data-seed(Assets)
            var upperAssets = new List<Assets>()
            {
                new Assets("https://www.llbeanbusiness.com/static/cms-img/classic-oxford-shirts-f19.jpg",AssetsType.Image,upper.Id),
                new Assets("https://images-na.ssl-images-amazon.com/images/I/61TWxMB8LFL._AC_UX679_.jpg",AssetsType.Image,upper.Id),
            };

            var lowerAssets = new List<Assets>()
            {
                new Assets("https://i.ebayimg.com/images/g/RgUAAOSwatBb8s0m/s-l1600.jpg",AssetsType.Image,lower.Id),
                new Assets("https://i.ebayimg.com/images/g/op0AAOSwhnlb8s0f/s-l1600.jpg",AssetsType.Image,lower.Id),
            };

            var otherAssets = new List<Assets>()
            {
                new Assets("https://i.ebayimg.com/images/g/fkUAAOSwG4pctJCS/s-l1600.jpg",AssetsType.Image,other.Id),
                new Assets("https://i.ebayimg.com/images/g/fkUAAOSwG4pctJCS/s-l1600.jpg",AssetsType.Image,other.Id),
            };


            var AllAssets = lowerAssets.Concat(upperAssets).Concat(otherAssets);

            modelBuilder.Entity<Assets>().HasData(AllAssets);

            //create UserCartProducts data-seed (UserProducts)

            modelBuilder.Entity<UserProducts>().HasData(new List<UserProducts>
            {
                new UserProducts(new Guid("2e5e7149-2410-4997-a4b0-e634b36039a0"),upper.Id),
                new UserProducts(new Guid("2e5e7149-2410-4997-a4b0-e634b36039a0"),lower.Id),
                new UserProducts(new Guid("84a6eda2-2ba2-43ed-8006-b07de7403e3d"),lower.Id),
            });
        }
    }
}

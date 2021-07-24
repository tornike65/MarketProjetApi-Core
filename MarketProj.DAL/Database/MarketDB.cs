using MarketProj.DAL.Configurations;
using MarketProj.Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarketProj.DAL.Database
{
    public class MarketDB : DbContext
    {
        public MarketDB(DbContextOptions<MarketDB> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<UserProducts> UserProducts { get; set; }
        public DbSet<ProductListItem> ProductListItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            DbInitialaizer.SeedData(modelBuilder);
        }
    }
}

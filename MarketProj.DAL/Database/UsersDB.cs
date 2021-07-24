using MarketProj.Models.Entities;
using MarketProj.Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarketProj.DAL.Database
{
    public class UsersDB : DbContext
    {
        public UsersDB(DbContextOptions<UsersDB> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<TemporaryUser> TempUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            DbUsersInitialaizer.DataSeed(modelBuilder);
        }
    }
}

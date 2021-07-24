using MarketProj.Models.Constants;
using MarketProj.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarketProj.DAL.Database
{
    class DbUsersInitialaizer
    {
        public static void DataSeed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new List<User>
            {
                new User(){Id=new Guid("84a6eda2-2ba2-43ed-8006-b07de7403e3d"), Email="levandoliashvili1@gmail.com", Password="admin123", Role=Role.Admin, Username="admin"},
                new User(){Id=new Guid("2e5e7149-2410-4997-a4b0-e634b36039a0"), Email="levandoliashvili2@gmail.com", Password="user123", Role=Role.User, Username="user"},
            });
        }
    }
}

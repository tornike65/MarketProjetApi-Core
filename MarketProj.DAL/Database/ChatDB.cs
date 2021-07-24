using MarketProj.Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarketProj.DAL.Database
{
    public class ChatDB : DbContext
    {
        public ChatDB(DbContextOptions<ChatDB> dbContext) : base(dbContext)
        {

        }

        public DbSet<ChatMessage> ChatMessages { get; set; }
    }
}

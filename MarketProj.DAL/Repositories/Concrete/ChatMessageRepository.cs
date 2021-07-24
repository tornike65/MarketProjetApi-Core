using MarketProj.DAL.Database;
using MarketProj.DAL.Repositories.Abstract;
using MarketProj.DAL.Repositories.Abstract.Base;
using MarketProj.Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MarketProj.DAL.Repositories.Concrete
{
    public class ChatMessageRepository : BaseRepository<ChatMessage>, IChatMessageRepository
    {
        public ChatMessageRepository(ChatDB context) : base(context)
        {
        }

        
    }
}

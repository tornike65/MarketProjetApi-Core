using MarketProj.DAL.Repositories.Abstract;
using MarketProj.Models.Models;
using MarketProj.Services.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MarketProj.Services.Services.Concrete
{
    public class ChatMessageService : IChatMessageService
    {
        private readonly IChatMessageRepository _chatMessageRepository;

        public ChatMessageService(IChatMessageRepository chatMessageRepository)
        {
            _chatMessageRepository = chatMessageRepository;
        }
        public async Task SentMessageAsync(Guid reciveId, Guid senderId, string message)
        {
            var chatMessage = new ChatMessage(reciveId, reciveId);
            chatMessage.SetMessasge(message);
            await _chatMessageRepository.AddAsync(chatMessage);
        }
    }
}

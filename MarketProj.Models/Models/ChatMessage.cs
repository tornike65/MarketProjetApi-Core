using MarketProj.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MarketProj.Models.Models
{
    public class ChatMessage : Entity
    {
        public ChatMessage(Guid senderUserId, Guid reciveUserId)
        {
            SenderUserId = senderUserId;
            ReciveUserId = reciveUserId;
            MessageDate = DateTime.Now;
        }

        public Guid SenderUserId { get; private set; }
        public Guid ReciveUserId { get; private set; }

        [MaxLength(500)]
        public string Message { get; private set; }
        public DateTime MessageDate { get; }
        

        public void SetMessasge(string message)
        {
            if (message.Length > 500)
                throw new Exception("message too long");
            Message = message;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MarketProj.Models.DTOs.OutDTOs
{
    public class ChatMessageOutDTO
    {
        public ChatMessageOutDTO(Guid senderUserId, Guid reciveUserId, DateTime dateSent, string message)
        {
            SenderUserId = senderUserId;
            ReciveUserId = reciveUserId;
            DateSent = dateSent;
            Message = message;
        }

        public Guid SenderUserId { get; set; }
        public Guid ReciveUserId { get; set; }
        public DateTime DateSent { get; set; }
        public string Message { get; set; }
    }
}

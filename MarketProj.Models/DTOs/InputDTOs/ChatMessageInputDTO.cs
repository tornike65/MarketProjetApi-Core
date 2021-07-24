using System;
using System.Collections.Generic;
using System.Text;

namespace MarketProj.Models.DTOs.InputDTOs
{
    public class ChatMessageInputDTO
    {
        
        public Guid ReciveUserId { get; set; }
        public string Message { get; set; }
    }
}

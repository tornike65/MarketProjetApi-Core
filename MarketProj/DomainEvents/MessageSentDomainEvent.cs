using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketProj.DomainEvents
{
    public class MessageSentDomainEvent : INotification
    {
        public MessageSentDomainEvent(Guid userReciveId, Guid userSentId, string message, DateTime originalSentDate)
        {
            UserReciveId = userReciveId;
            UserSentId = userSentId;
            Message = message;
            OriginalSentDate = originalSentDate;
        }

        public Guid UserReciveId { get; set; }
        public Guid UserSentId { get; set; }
        public string Message { get; set; }
        public DateTime OriginalSentDate { get; set; }
    }
}

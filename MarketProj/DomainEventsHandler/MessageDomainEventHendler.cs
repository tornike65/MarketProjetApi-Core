using MarketProj.DomainEvents;
using MarketProj.Models.DTOs.OutDTOs;
using MarketProj.Services.Services.Abstract;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MarketProj.DomainEventsHandler
{
    public class MessageDomainEventHendler : INotificationHandler<MessageSentDomainEvent>
    {
        private readonly IHubNotificationHelper _hubNotificationHelper;
        private const string chatMessageMethodName = "MessageReceived";
        public MessageDomainEventHendler(IHubNotificationHelper hubNotificationHelper)
        {
            _hubNotificationHelper = hubNotificationHelper;
        }

        public async Task Handle(MessageSentDomainEvent notification, CancellationToken cancellationToken)
        {
            var messageOutDto = new ChatMessageOutDTO(notification.UserSentId
                ,notification.UserReciveId
                ,notification.OriginalSentDate
                ,notification.Message);

            await _hubNotificationHelper.SentNotificationToUser(messageOutDto, notification.UserReciveId.ToString(), chatMessageMethodName);
           
        }
    }
}

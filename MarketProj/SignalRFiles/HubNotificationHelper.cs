using MarketProj.Services.Services.Abstract;
using MarketProj.Services.Services.Concrete;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketProj.SignalRFiles
{
    public class HubNotificationHelper : IHubNotificationHelper
    {
        private readonly IHubContext<MarketHub> _hubContext;
        private readonly ISignalRConnectionManeger _signalRConnectionManeger;
        private const string _transactionMethodName = "TransactionSuccessfull";

        public HubNotificationHelper(IHubContext<MarketHub> hubContext, ISignalRConnectionManeger signalRConnectionManeger)
        {
            _hubContext = hubContext;
            _signalRConnectionManeger = signalRConnectionManeger;
        }

        public IEnumerable<string> GetOnlineUsers()
        {
            return _signalRConnectionManeger.OnlineUsers;
        }

        public async Task<Task> SentNotificationToUser(object message, string userName, string methodName)
        {
            var userConnections = _signalRConnectionManeger.GetConnections(userName);
            if (userConnections.Count == 0)
                return Task.CompletedTask;

            foreach (var userConnection in userConnections)
            {
                var proxy = _hubContext.Clients.Clients(userConnection);
                await proxy.SendAsync(methodName, message);
            }
            return Task.CompletedTask;
        }

        public async Task SentToAll(object message,string methodName)
        {
            var users =_signalRConnectionManeger.OnlineUsers;
            if (users == null)
                return;

            foreach (var user in users)
            {
                await SentNotificationToUser(message, user, methodName);
            }
        }

        public async Task TransactionIsSuccessfull(decimal money,string userName)
        {
            await SentNotificationToUser(money, userName, _transactionMethodName);
        }
    }
}

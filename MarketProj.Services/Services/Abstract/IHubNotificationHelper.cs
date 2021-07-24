using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MarketProj.Services.Services.Abstract
{
    public interface IHubNotificationHelper 
    {
        Task SentToAll(object message,string methodName);
        Task<Task> SentNotificationToUser(object message,string userName,string methodName);
        Task TransactionIsSuccessfull(decimal money,string userName);
        IEnumerable<string> GetOnlineUsers();

    }
}

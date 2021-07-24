using System;
using System.Collections.Generic;
using System.Text;

namespace MarketProj.Services.Services.Abstract
{
    public interface ISignalRConnectionManeger
    {
        public IEnumerable<string> OnlineUsers { get;}
        void AddConnection(string userName, string connectionId);
        void RemoveConnection(string connectionId);
        HashSet<string> GetConnections(string userName);
    }
}

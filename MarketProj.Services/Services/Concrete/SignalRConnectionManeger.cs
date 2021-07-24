using MarketProj.Services.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarketProj.Services.Services.Concrete
{
    public class SignalRConnectionManeger : ISignalRConnectionManeger
    {
        public IEnumerable<string> OnlineUsers { get { return userMap.Keys; } }

        private static Dictionary<string, HashSet<string>> userMap = new Dictionary<string, HashSet<string>>();
        public void AddConnection(string userName, string connectionId)
        {
            lock (userMap)
            {
                if (!userMap.ContainsKey(userName))
                {
                    userMap[userName] = new HashSet<string>();
                }
                userMap[userName].Add(connectionId);
            }
        }

        public HashSet<string> GetConnections(string userName)
        {
            lock (userMap)
            {
                var connections = userMap.GetValueOrDefault(userName);
                return connections;
            }
        }

        public void RemoveConnection(string connectionId)
        {
            lock (userMap)
            {
                foreach (var username in userMap.Keys)
                {
                    if (!userMap.ContainsKey(username))
                    {
                        continue;
                    }
                    if (userMap[username].Contains(connectionId))
                    {
                        userMap[username].Remove(connectionId);
                        break;
                    }
                }
            }
        }
    }
}

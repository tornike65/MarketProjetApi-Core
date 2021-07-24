using MarketProj.Services.Services.Abstract;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MarketProj.SignalRFiles
{
    public class MarketHub : Hub
    {
        private readonly ISignalRConnectionManeger _signalRConnectionManeger;

        public MarketHub(ISignalRConnectionManeger signalRConnectionManeger)
        {
            _signalRConnectionManeger = signalRConnectionManeger;
        }

        public override Task OnConnectedAsync()
        {
            _signalRConnectionManeger
                .AddConnection(Context.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Name).Value, Context.ConnectionId);
            return base.OnConnectedAsync();
        }

        public override Task OnDisconnectedAsync(Exception exception)
        {
            _signalRConnectionManeger.RemoveConnection(Context.ConnectionId);
            return base.OnDisconnectedAsync(exception);
        }

        public async Task<string> GetConnectionId()
        {
            if (Context==null || Context?.User==null)
            {
                return null;
            }

             _signalRConnectionManeger
                .AddConnection(Context.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Name).Value, Context.ConnectionId);

            return await Task.Run(()=> Context.ConnectionId);
        }
    }
}

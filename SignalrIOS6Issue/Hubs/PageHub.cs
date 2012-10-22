using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SignalR.Hubs;

namespace SignalrIOS6Issue.Hubs
{
    public class PageHub : Hub
    {
        public void clientInit()
        {
            Caller.ClientId = Caller.ClientId ?? Guid.NewGuid();

            var state = new { };
            Caller.gotClientState(state);

            //Clients[_DISPLAY].gotClientConnect(state);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace MunchProject
{
    [HubName("munchHub")]
    public class MunchHub : Hub
    {
        public void Hello()
        {
            Clients.All.hello();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace MunchProject
{
    public class MunchHub : Hub
    {
        public void Hello()
        {
            Clients.All.hello();
        }
    }
}
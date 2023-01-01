using Microsoft.AspNetCore.SignalR;
using Mvc.Models.Concrete;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc.Hubs
{
    public class OrderHub : Hub
    {
        public async Task SendData(string message)
        {
            await Clients.All.SendAsync("SendData", message);
        }
    }
}

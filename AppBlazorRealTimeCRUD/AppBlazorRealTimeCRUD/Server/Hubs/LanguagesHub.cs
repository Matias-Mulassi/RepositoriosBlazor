using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppBlazorRealTimeCRUD.Server.Hubs
{
    public class LanguagesHub : Hub
    {
        public async Task SendMessage()
        {
            await Clients.All.SendAsync("ReceiveMessage"); //Mensaje enviado a todos aquellos que quieran escuchar.
        }


    }
}

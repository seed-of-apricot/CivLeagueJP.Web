using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace CivLeagueJP.Web.Controllers
{
    public class SignalRHub : Hub
    {
        public Task Test1()
        {
            return Clients.AllExcept(new List<string> { "1" }).InvokeAsync("Test1");
        }
        public Task Test2()
        {
            return Clients.AllExcept(new List<string> { "2" }).InvokeAsync("Test2");
        }
    }
}
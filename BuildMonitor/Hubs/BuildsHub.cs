using BuildMonitor.Models;
using Microsoft.AspNet.SignalR;

namespace BuildMonitor.Hubs
{
    public class BuildsHub : Hub
    {
        public void BuildStatusChanged(Build build)
        {
            Clients.All.broadcastMessage(build);
        }
    }
}
using BuildMonitor.Models;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace BuildMonitor.Hubs
{
    public interface IBuildsHub
    {
        void BuildStatusChanged(Build build);
    }

    [HubName("buildsHub")]
    public class BuildsHub : Hub, IBuildsHub
    {
        public void BuildStatusChanged(Build build)
        {
            Clients.All.broadcastMessage(build);
        }
    }
}
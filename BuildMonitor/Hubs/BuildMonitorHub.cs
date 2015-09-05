using BuildMonitor.Models;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace BuildMonitor.Hubs
{
    public interface IBuildMonitorHub
    {
        void BuildStatusChanged(Build build);
        void ProjectStatusChanged(Project project);
    }

    [HubName("buildMonitorHub")]
    public class BuildMonitorHub : Hub, IBuildMonitorHub
    {
        public void BuildStatusChanged(Build build)
        {
            Clients.All.buildStatusChanged(build);
        }

        public void ProjectStatusChanged(Project project)
        {
            Clients.All.projectStatusChanged(project);
        }
    }
}
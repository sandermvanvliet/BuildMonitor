using System;
using BuildMonitor.Hubs;
using BuildMonitor.Models;
using Microsoft.AspNet.SignalR;

namespace BuildMonitor.Jobs
{
    public class RefreshBuildsJob
    {
        private static IHubContext<IBuildsHub> hub;

        public static void Refresh()
        {
            if (hub == null)
            {
                hub = GlobalHost.ConnectionManager.GetHubContext<IBuildsHub>("buildsHub");
            }

            hub.Clients.All.BuildStatusChanged(new Build
            {
                Name = "Some Build",
                Status = RandomStatus()
            });
        }

        private static string RandomStatus()
        {
            switch (new Random().Next(1, 4))
            {
                case 1:
                    return "inprogress";
                case 2:
                    return "succeeded";
                case 3:
                    return "failed";
                default:
                    return "partiallysucceeded";
            }
        }
    }
}
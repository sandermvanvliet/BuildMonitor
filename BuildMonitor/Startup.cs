using Hangfire;
using Hangfire.MemoryStorage;
using Owin;

namespace BuildMonitor
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();

            GlobalConfiguration.Configuration.UseMemoryStorage();

            app.UseHangfireDashboard();
            app.UseHangfireServer();
        }
    }
}